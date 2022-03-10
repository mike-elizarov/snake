using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   internal class HorizontalLine
    {
        List<Point> plist;

        public HorizontalLine(int xLeft, int xWright, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xWright; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }

        public void Drow()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }