using System;
class Program
{
    
    static void Main()
    {
        Vector2 P1 = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
        Vector2 P2 = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
        Vector2 P3 = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
        Cal(P1,P2,P3);
    }
    static void Cal(Vector2 P1 , Vector2 P2, Vector2 P3)
    {
        double a = 2 * (P2.GetX() - P1.GetX());
        double b = 2 * (P2.GetY() - P1.GetY());
        double c = Math.Pow(P2.GetX(),2) + Math.Pow(P2.GetY(),2) - Math.Pow(P1.GetX(),2) - Math.Pow(P1.GetY(),2);
        double d = 2 * (P3.GetX() - P2.GetX());
        double e = 2 * (P3.GetY() - P2.GetY());
        double f = Math.Pow(P3.GetX(),2)+Math.Pow(P3.GetY(),2)-Math.Pow(P2.GetX(),2)-Math.Pow(P2.GetY(),2);

        double h = (b * f - e * c) / (b * d - e * a);
        double k = (d * c - a * f) / (b * d - e * a);
        double r = Math.Sqrt(Math.Pow((P1.GetX() - h),2)  + Math.Pow(P1.GetY() - k,2));
       
        Console.WriteLine("This is Answer");
        Console.WriteLine("{0}", h);
        Console.WriteLine("{0}", k);
        Console.WriteLine("{0}", r);
    }
}