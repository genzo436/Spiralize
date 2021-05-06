using Spiralize.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Spiralize
{
  public partial class ImageDialog : Form
  {
    public Bitmap image, canvasImage, outputImage;
    readonly Graphics gCanvas;
    readonly Pen pen = new Pen(Color.Black, 2);
    public ImageDialog(String file)
    {
      InitializeComponent();
      this.ControlBox = false;
      image = new Bitmap(file);
      canvasImage = new Bitmap(image);
      gCanvas = Graphics.FromImage(canvasImage);
    }

    private void ImageDialog_Load(object sender, EventArgs e)
    {
      pictureBoxInput.Image = canvasImage;
    }
    private Coordinate GetRelativeCoords(PictureBox canvas, Coordinate position)
    {
      Int32 realW = canvas.Image.Width;
      Int32 realH = canvas.Image.Height;
      Int32 currentW = canvas.ClientRectangle.Width;
      Int32 currentH = canvas.ClientRectangle.Height;
      Double zoomW = (currentW / (Double)realW);
      Double zoomH = (currentH / (Double)realH);
      Double zoomActual = Math.Min(zoomW, zoomH);
      Double padX = zoomActual == zoomW ? 0 : (currentW - (zoomActual * realW)) / 2;
      Double padY = zoomActual == zoomH ? 0 : (currentH - (zoomActual * realH)) / 2;

      Int32 realX = (Int32)((position.x - padX) / zoomActual);
      Int32 realY = (Int32)((position.y - padY) / zoomActual);
      return new Coordinate(realX, realY);
    }

    Coordinate cursorStart, cursorEnd;
    Rectangle crop;
    bool drawing = false;
    private void PictureBoxInputMouseDown(object sender, MouseEventArgs e)
    {
      ((PictureBox)sender).SizeMode = PictureBoxSizeMode.Zoom;
      drawing = true;
      Coordinate currentPosition = new Coordinate(e.X, e.Y);
      cursorStart = GetRelativeCoords((PictureBox)sender, currentPosition);
    }

    private void PictureBoxInputMouseMove(object sender, MouseEventArgs e)
    {
      if (!drawing)
      {
        return;
      }
      Coordinate currentPosition = new Coordinate(e.X, e.Y);
      cursorEnd = GetRelativeCoords((PictureBox)sender, currentPosition);
      int radiusCursor = (int)cursorStart.DistanceTo(cursorEnd);

      crop = new Rectangle(
        (int)cursorStart.x - radiusCursor, (int)cursorStart.y - radiusCursor,
        2 * radiusCursor, 2 * radiusCursor);

      gCanvas.DrawImage(image,new Point(0,0));
      gCanvas.DrawEllipse(pen, crop);
      gCanvas.DrawLine(pen, cursorStart.ToPoint(), cursorEnd.ToPoint());

      pictureBoxInput.Image = canvasImage;
    }
    private void PictureBoxInputMouseUp(object sender, MouseEventArgs e)
    {
      drawing = false;
      outputImage = CropEllipse(image, crop);
      pictureBoxOutput.Image = outputImage;
    }
    private Bitmap CropEllipse(Bitmap image, Rectangle crop)
    {

      if(crop.Width == 0 || crop.Height == 0)
      {
        return null;
      }

      Bitmap maskImage = new Bitmap(image);
      SolidBrush brush = new SolidBrush(Color.Black);
      Graphics gMask = Graphics.FromImage(maskImage);
      gMask.Clear(Color.White);
      gMask.FillEllipse(brush, crop);

      // Offset Variables
      int xInit = crop.X;
      int yInit = crop.Y;
      int xEnd = crop.X + crop.Width;
      int yEnd = crop.Y + crop.Height;
      int xOffset = xInit < 0 ? -xInit : 0;
      int yOffset = yInit < 0 ? -yInit : 0;

      xInit = InsideLimits(xInit, image.Width);
      xEnd = InsideLimits(xEnd, image.Width);
      yInit = InsideLimits(yInit, image.Height);
      yEnd = InsideLimits(yEnd, image.Height);

      if(xInit == xEnd || yInit == yEnd)
      {
        return null;
      }

      Bitmap result = new Bitmap(crop.Width, crop.Height);
      gMask = Graphics.FromImage(result);
      Rectangle reCrop = new Rectangle(xInit, yInit, xEnd-xInit, yEnd -yInit);
      gMask.DrawImage(image.Clone(reCrop, image.PixelFormat), new Point(xOffset, yOffset));

      return result;
      for (int i = 0; i < result.Width; i++)
      {
        for (int j = 0; j < result.Height; j++)
        {
          int xPos = crop.X + i;
          int yPos = crop.Y + j;
          if (xPos >= 0 && xPos < image.Width && yPos >= 0 && yPos < image.Height)
          {
            Color pixelMask = maskImage.GetPixel(xPos, yPos);
            if (pixelMask.R == 255)
            {
              result.SetPixel(i, j, Color.White);
            }
          }
          else
          {
            result.SetPixel(i, j, Color.White);
          }
        }
      }
      return result;
    }

    private int InsideLimits(int value, int maxValue)
    {
      if (value < 0)
      {
        return 0;
      }
      if (value > maxValue)
      {
        return maxValue;
      }
      return value;
    }
  }
}
