using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

//public class DataStore <T> where T : struct
//{
//    public T Data { get; set; }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        DataStore<int> dataStore = new DataStore<int>();
//        DataStore<char> dataStore1 = new DataStore<char>();
//        DataStore<double> dataStore2 = new DataStore<double>();
//        DataStore<ArrayList> dataStore3 = new DataStore<ArrayList>();
//    }
//}

//public class DataStore1 <T> where T : class, new()
//{
//    public T Data1 { get; set; }
//}

//class Program1
//{
//    static void Main(string[] args)
//    {
//        DataStore1<string> hello = DataStore1<string>();
//        DataStore1<MyStruct> hello1 = DataStore1<MyStruct>();
//    }
//}

//class DataStore3<T> where T : class, new()
//{
//    public T Data { get; set; }
//}

//DataStore3<MyClass> store4 = new DataStore3<MyClass>(); // valid
//DataStore3<ArrayList> num = new DataStore3<ArrayList>(); // valid


//class DataStore4<T> where T : IEnumerable
//{
//    public T Data { get; set; }
//}

//DataStore4<ArrayList> store = new DataStore4<ArrayList>(); // valid
//DataStore4<List> store1 = new DataStore4<List>(); // valid
//DataStore<string> store2 = new DataStore<string>(); // compile-time error 
//DataStore<int> store3 = new DataStore<int>(); // compile-time error 
public class Training
{
    public string Name { get; set; }
    public int Cost { get; set; }
}

public class Trainings : Collection<Training>
{
    public Training this[string name]
    {
        get { return this.Items.First(s => string.Equals(s.Name, name, StringComparison.OrdinalIgnoreCase)); }
    }
}









