﻿// See https://aka.ms/new-console-template for more information

{
    Point p1 = new Point(1, 3, '*');
   
    p1.Draw();

    Point p2 = new Point(4, 5, '#');
    
    p2.Draw();

    HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
    line.Draw();

    VerticalLine line1 = new VerticalLine(5, 10, 15, '+');
    line1.Draw();

    Console.ReadLine();
}
