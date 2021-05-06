using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Spiralize.Classes
{
  class Spiral
  {
    public double rotations;
    public double maxRadio;
    public double amplitudeVolume;
    public double frequency;
    public double stepSample;
    public Bitmap sourceImage;

    public List<Coordinate> points = new List<Coordinate>();
    public List<Coordinate> Create()
    {
      if (stepSample == 0)
      {
        return points;
      }

      if (sourceImage != null)
      {
        this.CreateWithSource();
      }
      else
      {
        this.CreateBlank();
      }
      return points;
    }

    private List<Coordinate> CreateBlank()
    {
      double maxAmplitude = (amplitudeVolume / 100) * maxRadio / (4 * rotations);

      double maxAngle = rotations * 2 * Math.PI;
      double radioConstant = maxRadio / (rotations * 4 * Math.PI);

      double initAngle = 0;

      // quadratic formula, only the positive solution needed
      // (-b + sqrt(b*b-4ac))/2a
      // a2 = 2*a
      // c2n = -2*c
      double a2 = radioConstant;
      double b;
      double c2n = 2 * stepSample;

      points.Clear();
      while (initAngle < maxAngle)
      {
        double amplitude = maxAmplitude * Math.Sin(frequency * initAngle * initAngle);
        double xVariant = amplitude * Math.Sin(initAngle);
        double yVariant = amplitude * Math.Cos(initAngle);

        double xCoordinate = Math.Sin(initAngle) * (radioConstant * initAngle);
        double yCoordinate = Math.Cos(initAngle) * (radioConstant * initAngle);

        points.Add(new Coordinate(xCoordinate + xVariant, yCoordinate + yVariant));
        b = radioConstant * initAngle;
        double stepTaken = (-b + Math.Sqrt(b * b + a2 * c2n)) / (a2);
        initAngle += stepTaken;
      }
      return points;
    }

    private List<Coordinate> CreateWithSource()
    {
      this.maxRadio = sourceImage.Width / 2;
      int offset = sourceImage.Width / 2;

      double maxAmplitude = (amplitudeVolume / 100) * maxRadio / (4 * rotations);

      double maxAngle = rotations * 2 * Math.PI;
      double radioConstant = maxRadio / (rotations * 2 * Math.PI);

      double initAngle = 0;

      // quadratic formula, only the positive solution needed
      // (-b + sqrt(b*b-4ac))/2a
      // a2 = 2*a
      // c2n = -2*c
      double a2 = radioConstant;
      double b;
      double c2n = 2 * stepSample;

      points.Clear();
      while (initAngle < maxAngle)
      {

        double xCoordinate = Math.Sin(initAngle) * (radioConstant * initAngle);
        double yCoordinate = Math.Cos(initAngle) * (radioConstant * initAngle);
        
        double colorLevel = GrayPercentage(sourceImage.GetPixel((int)xCoordinate + offset, (int)yCoordinate + offset));

        double amplitude = (colorLevel/100) * maxAmplitude * Math.Sin(frequency * initAngle * initAngle);
        double xVariant = amplitude * Math.Sin(initAngle);
        double yVariant = amplitude * Math.Cos(initAngle);

        points.Add(new Coordinate(xCoordinate + xVariant, yCoordinate + yVariant));
        b = radioConstant * initAngle;
        double stepTaken = (-b + Math.Sqrt(b * b + a2 * c2n)) / (a2);
        initAngle += stepTaken;
      }
      return points;
    }

    private double GrayPercentage(Color color)
    {
      return 100 - (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) * 100 / 255;
    }

    bool ValidatePoints()
    {
      return this.points.Count != 0;
    }


    private Coordinate GetSpiralHighestValues()
    {
      if (!ValidatePoints())
      {
        return null;
      }
      Coordinate max = new Coordinate(points[0]);
      foreach (Coordinate c in points)
      {
        if (c.x > max.x) { max.x = c.x; }
        if (c.y > max.y) { max.y = c.y; }
      }
      return max;
    }
    private Coordinate GetSpiralLowestValues()
    {
      if (!ValidatePoints())
      {
        return null;
      }
      Coordinate min = new Coordinate(points[0]);
      foreach (Coordinate c in points)
      {
        if (c.x < min.x) { min.x = c.x; }
        if (c.y < min.y) { min.y = c.y; }
      }
      return min;
    }
    private List<Coordinate> MoveSpiral(Coordinate p)
    {
      if (!ValidatePoints())
      {
        return points;
      }
      List<Coordinate> result = new List<Coordinate>();
      foreach (Coordinate c in points)
      {
        result.Add(new Coordinate(c.x + p.x, c.y + p.y));
      }
      return result;
    }

    public Bitmap Draw()
    {
      if (!ValidatePoints())
      {
        return null;
      }
      Coordinate minValues = GetSpiralLowestValues();
      points = MoveSpiral(-minValues);
      points = MoveSpiral(new Coordinate(2, 2));

      Coordinate maxValues = GetSpiralHighestValues();

      Bitmap result = new Bitmap((int)maxValues.x + 2, (int)maxValues.y + 2);
      Graphics g = Graphics.FromImage(result);
      Pen p = new Pen(Color.Black);
      for (int i = 0; i < points.Count - 1; i++)
      {
        //g.DrawEllipse(p,
        //new Rectangle((int)spiral[i].x - 2, (int)spiral[i].y - 2, 4, 4));
        g.DrawLine(p,
          new Point((int)points[i].x, (int)points[i].y),
          new Point((int)points[i + 1].x, (int)points[i + 1].y));
      }
      return result;
    }

    internal void CreateFromImage(Bitmap image)
    {
      this.sourceImage = image;
      Spiral aux = new Spiral
      {
        rotations = this.rotations,
        maxRadio = image.Width / 2,
        frequency = this.frequency,
        amplitudeVolume = this.amplitudeVolume,
        stepSample = this.stepSample,
        sourceImage = image,
      };




    }
  }
}
