namespace Triangle;

internal class Triangle
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double x, double y, double z)
    {
        if(!isTriangle(x, y, z))
        {
            Console.WriteLine("Uchburchak yasab bo'lmaydi!");
        }
        A = x;
        B = y;
        C = z;

    }

    public double Perimetr { get => A + B + C; }
  
    public bool isTriangle(double x, double y, double z)
    {
        return x < y + z && y < x + z && z < y + x;
        
    }

    public double Area
    {
        get
        {
            var p = Perimetr / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
      
}
