using System.Reflection.Metadata;
using System.Reflection;

//N17 - HT2 - copy, static

//ChatMessage modelidan foydalaning ( unique Id, SentTime, EditedTime, Content )
//unda quyidagi konstruktorlar bo'lsin
//- parameterized ( content ) -konstruktorda Id, SentTime va Content ga qiymat berilsin
//- copy ( chatMessage ) -chatMessage objectidagi barcha qiymatlarni o'ziga o'zlashtirsin, EditedDate ga hozirgi vaqt qo'yilsin

//Chat servicedan foydalaning 
//unda quyidagi propertylar bo'lsin
//- Messages - ChatMessage tipidagi kolleksiya

//unda quyidagi methodlar bo'lsin 
//- Add ( content ) -content valid ekanligini tekshirib, ChatMessage dan object yaratib, kolleksiyaga qo'shilsin - invalid bo'lsa - exception, yaratilgan message Id sini qaytarsin
//- Update ( id, content ) -kolleksiyadan Id bo'yicha topib, contentni validate qilib, topilgan message dan copy olinsin, content update qilinib, kolleksiyaga qo'shilsin, topilmasa - exception
//- Display - messagelarni jo'natilgan ketma ketligi bo'yicha ekranga chiqarsin, bunda agar bitta message dan bir nechtasi bolsa - ya'ni edit qilingan bo'lsa, oxirgi edit qilingan versiyasi chiqsin

//MessageValidator static servicedan foydaning 
//unda quyidagi methodlar bo'lsin
//- IsValidMessage ( content ) -xabar valid ekanligini tekshirsin

//Example : 

//Bu ishlash jarayoni, konsolga shunday chiqishi shartmas

//add - Hi everybody
//add - Let's get started
//add - We'll start the meeting in 10 minutes
//update - We'll start the meeting in 10 minutes -> Sorry guys, we are having technical issues, let's wait for another 10 minutes
//update - Sorry guys, we are having technical issues, let's wait for another 10 minutes -> I'm really sorry meeting is cancelled

//Display

//Hi everybody - 02.08.2023 18:10
//Let's get started - 02.08.2023 18:15
//I'm really sorry meeting is cancelled - 02.08.2023 18:45


internal class ChatMessage
{
    public int Id { get;  }
    public DateTime SendTime { get; }
    public DateTime ChangedTime { get; private set; }
    public string Content { get; set; }

    public ChatMessage(int id, DateTime sendTime, string content) 
    {
        Id = id;
        SendTime = sendTime;
        Content = content;
    }

    public ChatMessage(ChatMessage chatMessage)
    {
        Id = chatMessage.Id;
        SendTime = chatMessage.SendTime;
        Content = chatMessage.Content;
        ChangedTime = DateTime.Now;
    }




}
