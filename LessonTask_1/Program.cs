
using LessonTask_1;
using System.Diagnostics.Metrics;
using System.Net;
using System.Text.Json;

WebClient client = new WebClient();

string savePath = @"C:\Users\HP\Downloads\Telegram Desktop\AllCountries (2).txt";

string jsonFile = File.ReadAllText(savePath);

var result = JsonSerializer.Deserialize<List<Country>>(jsonFile);

foreach(var item in result.Distinct)
{
    client.DownloadFile(result[0].Flag.Svg, )
}






