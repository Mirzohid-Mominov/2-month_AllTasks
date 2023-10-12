
public class Meeting
{
    public Meeting(string name, TimeSpan duration)
    {
        Name = name;
        Duration = duration;
    }

    public string Name { get; set; }
    public TimeSpan Duration { get; set; }

    public static Meeting operator +(Meeting meeting1, Meeting meeting2)
    {
        return new Meeting($"Combined : {meeting1.Name}\t{meeting2.Name}", meeting1.Duration + meeting2.Duration);
    }
}

public class MeetingService
{
   
    public static void Main(string[] args)
    {
        List<Meeting> _meetingList = new List<Meeting>()
        {
        new Meeting("Conference", TimeSpan.FromHours(2)),
        new Meeting("JobInterview", TimeSpan.FromHours(3)),
        };


        var totalDuration = TimeSpan.Zero;

        foreach( var meeting in _meetingList )
        {
            Console.WriteLine($"Name : {meeting.Name}\tDuration  : {meeting.Duration}");
            totalDuration += meeting.Duration;
        }
        Console.WriteLine($"Total Duration : {totalDuration}");

    }
}

