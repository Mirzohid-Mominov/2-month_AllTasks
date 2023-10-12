namespace Tortburchak;

public class Yuzasi
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double D { get; set; }
    public double Dio { get; set; }  //Dioganal


    public Yuzasi(int[] xLar, int[] yLar)
    {
        if (!isTortburchak(xLar, yLar))
        {
            Console.WriteLine("Bu nuqtalardan to'rtburchak yasab bo'lmaydi!");
            Environment.Exit(0);
        }

        A = Masofa(xLar[0], xLar[1], yLar[0], yLar[1]);
        B = Masofa(xLar[1], xLar[2], yLar[1], yLar[2]);
        C = Masofa(xLar[2], xLar[3], yLar[2], yLar[3]);
        D = Masofa(xLar[3], xLar[0], yLar[3], yLar[0]);

        Dio = Masofa(xLar[1], xLar[3], yLar[1], yLar[3]);
    }



    public bool isTortburchak(int[] xLar, int[] yLar)
    {
        var x = xLar.Distinct().Count();
        var y = yLar.Distinct().Count();
        if (x <= 2 || y <= 2)
            return false;
        return true;
    }

    public double Masofa(int x1, int x2, int y1, int y2)
    {
        return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    }


    public double Perimetr1 { get => A + D + Dio; }
    public double Perimetr2 { get => B + C + Dio; }

    public double Area1
    {
        get
        {
            var p = Perimetr1 / 2;
            return Math.Sqrt(p * (p - A) * (p - D) * (p - Dio));
        }
    }

    public double Area2
    {
        get
        {
            var p = Perimetr2 / 2;
            return Math.Sqrt(p * (p - B) * (p - C) * (p - Dio));
        }
    }


    public double TArea
    {
        get
        {
            return Math.Round(Area1 + Area2, 2);
        }


    }



}
