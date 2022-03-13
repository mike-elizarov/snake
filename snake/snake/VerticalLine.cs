using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class VerticalLine : Figure
    {
      public VerticalLine(int yHi, int yLo, int x, char sym)
      {
        plist = new List<Point>();
        for(int y = yHi; y <= yLo; y++)
        {
            Point p = new Point(x, y, sym);
            plist.Add(p);
        }
      }
     
    }