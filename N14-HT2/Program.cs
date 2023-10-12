using N14_HT2_CL;

namespace N14_HT2;

public class Program
{
    static void Main(string[] args)
    {
        UltimateClassroomAttendance obj = new UltimateClassroomAttendance();

        obj.Mark("Iskandar", true);
        obj.Mark("John", false);
        obj.Mark("Messi", false, "Americaga ketgan!");
        obj.Mark("Ronaldu", false);
        obj.Mark("Jasur", false, "Toshkentga ketgan!");
        obj.Mark("Bob", true, "Bu comment chiqmasligi kerak!");
        obj.Display();



    }
}