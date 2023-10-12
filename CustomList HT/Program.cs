

internal class Program
{
    private static void Main(string[] args)
    {
        var MyList = new CustomList_HT.CustomList<int>();

        //Add orqali bittalab qo'shish 

        MyList.Add(11);
        MyList.Add(22);
        MyList.Add(33);
        MyList.Add(44);

        MyList.AddRange(5, 6, 7, 8, 9, 10);

        Console.WriteLine(MyList);

        MyList.Insert(1, 451);

        MyList.InsertRange(2, 5, 6, 7);


        MyList.Remove(2);


        MyList.RemoveAt(1);


        var arrayB = new int[5];
        MyList.CopyTo(arrayB);

        var arrayC = new int[10];
        MyList.CopyTo(arrayC);

        Console.WriteLine(MyList.Contains(5));
        Console.WriteLine(MyList.Contains(103));


        Console.WriteLine(MyList.IndexOf(10));

    }
}