namespace N14___HT2;

internal class Program
{
    static void Main(string[] args)
    {
        Planner planner1 = new Planner();
        planner1.Add("Tug'ulgan kun! ", new TimeOnly(12, 40, 35));
        planner1.Add("To'y! ", new TimeOnly(23, 15, 10));
        planner1.Add("Imtihon! ", new TimeOnly(23, 15, 10));
        planner1.Display();


        UltimatePlanner planner2 = new UltimatePlanner();
        planner1.Add("Tug'ulgan kun! ", new TimeOnly(12, 40, 35));
        planner1.Add("To'y! ", new TimeOnly(23, 15, 10));
        planner1.Add("Imtihon! ", new TimeOnly(23, 15, 10));
        planner1.Display();

        planner2.Add("Tug'ulgan kun! ", new DateOnly(2022, 2, 12));
        planner2.Add("To'y! ", new DateOnly(2022, 2, 12));
        planner2.Add("Imtihon! ", new DateOnly(2023, 12, 23));
        planner2.Display();



    }
}