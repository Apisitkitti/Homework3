using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to enter the vertices of the polygon
        Console.WriteLine("Enter the vertices of the polygon (at least 3 points):");

        // Initialize an empty list to store the vertices
        List<Tuple<double, double>> vertices = new List<Tuple<double, double>>();

        // Read in the vertices until the user enters (0, 0)
        while (true)
        {
            // Read in the next vertex
            Console.Write("Vertex {0}: ", vertices.Count + 1);
            Vector2 Point = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
            
            // Check if the user entered (0, 0)
            if (Point.GetX() == 0 && Point.GetY() == 0)
            {
                // Stop reading in vertices
                break;
            }
            else
            {
                // Add the vertex to the list
                vertices.Add(new Tuple<double, double>(Point.GetX(), Point.GetY()));
            }
        }

        // Prompt user to enter the point to check
        Console.WriteLine("Enter the point to check:");
        Vector2 P = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));

        // Determine if the point is inside or outside the polygon
        bool isInside = IsPointInsidePolygon(vertices, P);

        // Output the result
        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }

    static bool IsPointInsidePolygon(List<Tuple<double, double>> vertices, Vector2 Point    )
    {
        // Initialize a counter for the number of intersections
        int numIntersections = 0;

        // Iterate over all edges of the polygon
        for (int i = 0; i < vertices.Count; i++)
        {
            // Get the two vertices of the current edge
            Tuple<double, double> vertex1 = vertices[i];
            Tuple<double, double> vertex2 = vertices[(i + 1) % vertices.Count];

            // Check if the current edge intersects the ray extending to the right from the point
            if ((vertex1.Item2 > Point.GetY()) != (vertex2.Item2 > Point.GetY()) && 
                Point.GetX() < (vertex2.Item1 - vertex1.Item1) * (Point.GetY() - vertex1.Item2) / (vertex2.Item2 - vertex1.Item2) + vertex1.Item1)
            {
                // Toggle the intersection counter
                numIntersections++;
            }
        }

        // If the number of intersections is odd, the point is inside the polygon; otherwise, it is outside
        return numIntersections % 2 == 1;
    }
}
