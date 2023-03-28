class Program {
    static void Main(string[] args) 
    {
       
        
        Vector2 Point1 = new(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
        Vector2 Point2 = new(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
         double[] r = {double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine())};

        double d = Math.Sqrt(Math.Pow(Point2.GetX() - Point1.GetX(), 2) + Math.Pow(Point2.GetY() - Point1.GetY(), 2));
        Calculate(r,d,Point1,Point2);

    }
    static void Calculate(double[] r,double d, Vector2 Point1 , Vector2 Point2)
    {
        if (d <= r[0] + r[1]) 
        {
            double a = (Math.Pow(r[0], 2) - Math.Pow(r[1], 2) + Math.Pow(d, 2)) / (2 * d);
            double h = Math.Sqrt(Math.Pow(r[0], 2) - Math.Pow(a,2));
            double x3 = Point1.GetX() + a * (Point2.GetX() - Point1.GetX()) / d;
            double y3 = Point1.GetY() + a * (Point2.GetY() - Point1.GetY()) / d;
            double x4 = x3 - h * (Point2.GetY() - Point1.GetY()) / d;
            double y4 = y3 + h * (Point2.GetX() - Point1.GetX()) / d;
            double x5 = x3 + h * (Point2.GetY() - Point1.GetY()) / d;
            double y5 = y3 - h * (Point2.GetY() - Point1.GetX()) / d;

            if(d == r[0] + r[1])
            {
                Console.WriteLine(x4);
                Console.WriteLine(y4);
            }
            else
            {
                Console.WriteLine(x4);
                Console.WriteLine(y4);
                Console.WriteLine(x5);
                Console.WriteLine(y5);
            }

        }
    }
}