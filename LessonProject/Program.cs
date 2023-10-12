using LessonProject;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text.Json;

// Add
// Read
// Update
// Delete

string filePath = @"D:\All_Homework\Person.txt";
string jsonData = File.ReadAllText(filePath);
//var people = JsonSerializer.Deserialize<List<Person>>(jsonData);
var people = new List<Person>();


var a = Console.ReadLine();
var b = Convert.ToByte(Console.ReadLine());
//var c = Convert.ToByte(Console.ReadLine());

var person = new Person()
{
    Id = people.Last().Id + 1,
    Name = a,
    Age = b
};

people.Add(person);

var resultJson = JsonSerializer.Serialize(people);
File.WriteAllText(filePath, resultJson);

foreach(var item in people)
{
    Console.WriteLine($"Id : {item.Id}\tName : {item.Name}\t{item.Age}");
}


////var result = new List<Person>()
////{
////    new Person{Id = 1, Name = "Abdurahmon", Age = 20},
////    new Person{Id = 2, Name = "Azizbek", Age = 17},

////};
//string path = @"C:\Users\HP\Downloads\Telegram Desktop\Model.txt";

////StreamReader reader = new StreamReader(path);
////var people = JsonSerializer.Deserialize<List<Person>>(reader.ReadLine());
////foreach(var item in people)
////{
////    Console.WriteLine("\n"+ item.Name);
////}



////string jsonPerson = JsonSerializer.Serialize(result);
//// StreamReader
//// StreamWriter


////using (StreamWriter writer = new StreamWriter(path))
////{
////    writer.Write(jsonPerson);
////}



////Console.Write("Name : ");
////string name = Console.ReadLine();

////Console.Write("Age  : ");
////byte age = Convert.ToByte(Console.ReadLine());

////result.Add(new Person { Id = result.Last().Id + 1, Name = name, Age = age});    
////foreach(var item in result)
////{
////    Console.WriteLine($"Id : {item.Id}\tName : {item.Name}\tAge : {item.Age}");
////}

