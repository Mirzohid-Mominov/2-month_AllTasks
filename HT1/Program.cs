/*string name, surname;
int age;

Console.Write("Ismingizni kiriting: ");
name = Console.ReadLine();

Console.Write("Familiyangizni kiriting: ");
surname = Console.ReadLine();

Console.Write("Yoshingizni kiriting: ");
age =  int.Parse(Console.ReadLine());

Console.WriteLine($"{surname} {name}, {age} yosh");*/

//Bugungi vaqt
DateTime time = DateTime.Now;
Console.WriteLine(time);

//1970-yil 1-yanvar
DateTime dat = DateTime.Parse("01/01/1971");
Console.WriteLine(dat);

//75-yosh
ushort age = 75;

//35.5 $
float money = 35.5f;

// Max Developer
string fulname = "Max Developer";


// Primitive
string name = "Jamol";
int yosh = 38;
double height = 1.78D;

//Complex
DateTime vaqt = DateTime.Now;

string matn = "salom dunyo men 12 yoshman";
string[] str = matn.Split(" ");
Console.WriteLine(str[1]);

// value type
char letter = 'J';
int population = 34_920_000;

Console.WriteLine($"Value types: {letter}, {population}");

//reference type
string gap = "Hello Tashkent";
Console.WriteLine($"Reference type: {gap}");