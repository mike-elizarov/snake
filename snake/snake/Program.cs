// See https://aka.ms/new-console-template for more information

{
    Point p1 = new Point(1, 3, '*');
   
    p1.Draw();

    Point p2 = new Point(4, 5, '#');
    
    p2.Draw();

    Point p3 = new Point(6, 7, '*');

    p3.Draw();

    Point p4 = new Point(8, 9, '#');

    p4.Draw();

    Point p5 = new Point(10, 11, '*');
    
    p5.Draw();

    Point p6 = new Point(12, 13, '#');

    p6.Draw();

    List<char> charlist = new List<char>();
    charlist.Add('*');
    charlist.Add('#');
    charlist.Add('*');
    charlist.Add('#');
    charlist.Add('*');
    charlist.Add('#');


    
    /*foreach(int i in numlist)
    {
        Console.WriteLine(i);
    }*/

    List<Point> plist = new List<Point>();
    plist.Add(p1);
    plist.Add(p2);
    plist.Add(p3);
    plist.Add(p4); 
    plist.Add(p5);
    plist.Add(p6);



    Console.ReadLine();
}
