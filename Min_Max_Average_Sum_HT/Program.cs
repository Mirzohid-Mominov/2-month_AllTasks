
//N27 - HT2 - min, max, average, sum, group, distinct

//- Topics enum dan foydalaning(Fun, IT, Gaming, Business)

//- VideoPost modelidan foydalaning(id, title, description, likes, dislikes, topic )
//-VideoPost tipidagi listga 10 ta video qo'shing

//ulardan quyidagilarni ekranga chiqaring
//- eng ko'p like olgani
//- eng kam dislike olgani
//- likelar o'rtachasi
//- barcha videolardagi dislikelar soni
//- videolarni faqat title va description bo'yicha projection qilib ( Select ) 
//- videolardan topic bo'yicha unique qilib ( Distinct ) 
//- videolarni topic bo'yicha guruhlab


using Min_Max_Average_Sum_HT;
using System.Text.Json;
using System.Threading.Channels;

var videoPosts = new List<VideoPost>
{
    new VideoPost("Funny Cat Compilation", "Watch these hilarious cats in action!", 25_000, 500, Topics.Fun),
    new VideoPost("Advanced Web Development Techniques", "Learn the latest web development tricks.", 10_000, 300, Topics.IT),
    new VideoPost("Epic Gaming Moments", "Witness incredible gaming highlights.", 50_000, 1_000, Topics.Gaming),
    new VideoPost("Entrepreneurial Success Stories", "Discover the secrets behind successful businesses.", 8_000, 200, Topics.Business),
    new VideoPost("How to Tell Jokes Like a Pro", "Master the art of delivering jokes.", 15_000, 1_500, Topics.Fun),
    new VideoPost("Cybersecurity Essentials", "Protect your online presence with these tips.", 12_000, 400, Topics.IT),
    new VideoPost("Speedrun: The Legend of Zara", "Watch the fastest playthrough of this classic game.", 30_000, 800, Topics.Gaming),
    new VideoPost("Investing in Stocks 101", "Learn the basics of stock market investment.", 7_000, 300, Topics.Business),
    new VideoPost("Stand-up Comedy Showcase", "Laugh out loud with these hilarious comedians.", 18_000, 2_000, Topics.Fun),
    new VideoPost("Creating User-Friendly UI/UX", "Design interfaces that users will love.", 14_000, 500, Topics.IT)
};

Console.WriteLine("Eng kop like toplagani : ");
Console.WriteLine(videoPosts.MaxBy(x => x.Likes) + "\n");

Console.WriteLine("eng kam dislike olgani");
Console.WriteLine(videoPosts.MinBy(x => x.DisLikes) + "\n");

Console.WriteLine("likelar o'rtachasi");
Console.WriteLine(videoPosts.Average(x => x.Likes));

Console.WriteLine("barcha videolardagi dislikelar soni");
Console.WriteLine(videoPosts.Sum(x => x.DisLikes));

Console.WriteLine("videolarni faqat title va description bo'yicha projection qilib ( Select ) ");
var hello = videoPosts.Select(video => new {video.Title, video.Description}).ToList();
hello.ForEach(video => Console.WriteLine($"Title: {video.Title} | Description : {video.Description}"));
Console.WriteLine();


Console.WriteLine("videolardan topic bo'yicha unique qilib ( Distinct ) ");
var hello1 = videoPosts.DistinctBy(x => x.Topics).ToList();
hello1.ForEach(Console.WriteLine);
Console.WriteLine();

var groupedUsers = videoPosts.GroupBy(
    video => video.Topics,
    (topic, videos) => new
    {
        Topic = topic,
        Videos = videos.ToList()
    });


Console.WriteLine(JsonSerializer.Serialize(groupedUsers));



