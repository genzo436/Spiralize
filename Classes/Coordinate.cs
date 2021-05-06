using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Spiralize.Classes
{
  class Coordinate
  {
    public double x, y;

    public Coordinate() {
      x = 0;
      y = 0;
    }

    public Coordinate(Coordinate coordinate)
    {
      this.x = coordinate.x;
      this.y = coordinate.y;
    }

    public Coordinate(double x, double y)
    {
      this.x = x;
      this.y = y;
    }
    public static Coordinate operator -(Coordinate a) => new Coordinate(-a.x, -a.y);
    public static Coordinate operator -(Coordinate a, Coordinate b) => a+(-b);
    public static Coordinate operator +(Coordinate a, Coordinate b) => new Coordinate(a.x + b.x, a.y + b.y);
    public static Coordinate operator *(Coordinate a, Coordinate b) => new Coordinate(a.x * b.x, a.y * b.y);

    public double DistanceTo(Coordinate point)
    {
      Coordinate aux = point - this;
      return aux.Mod();
    }

    public double Mod()
    {
      Coordinate aux = this * this;
      return Math.Sqrt(aux.x + aux.y);
    }
    public Point ToPoint()
    {
      return new Point((int)Math.Round(x), (int)Math.Round(y));
    }
    public override string ToString()
    {
      return x.ToString() + " : " + y.ToString();
    }
  }
}
