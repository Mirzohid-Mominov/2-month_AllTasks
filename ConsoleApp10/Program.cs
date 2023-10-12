//N32 - T4 service, polymorphism, class types, encapsulation

//MessageConstants static tipidan foydalaning
//Music modelidan foydalaning ( id, name, singerName )

//MusicService abstract serivcedan dan foydalaning
//- virtual SwitchNext -keyingi qo'shiqqa o'tkazish
//- virtual SwitchPrevious - oldingi qo'shiqqa o'tkazish
//- virtual DisplayCurrentSong - hozirgi qo'shiqni ekranga message bilan chiqarish
//- abstract Add(name, singerName) - qo'shiqni saqlab qo'yish

//OptimizedMusicService sealed service dan foydalaning
//- unda MusicService dan inheritance oling va quyidagi methodlarni qo'shing
//- private SwitchToFirst -birinchi qo'shiqqa o'tkazish
//- private SwitchToLast -oxirgi qo'shiqqa o'tkazish
//- private IsCurrentTheLastOne -hozirgi qo'shiq oxirgi ekanligini tekshirish
//- private IsCurrentTheFirstOne -hozirgi qo'shiq birinchi ekanligini tekshirish
//- SwiitchNext, SwitchPrevious methodlarini override qiling va tepada yozilgan methodlardan foydalaning
//- Add methodini override qiling va agar shu songName va singerName qiymatli qo'shiq bo'lmasagina qo'shadigan qiling

//MessageConstants quyidagi konstantalar bo'lsin
//- CurrentMusicMessage - "Currently playing {{MusicName}} {{SingerName}}
//- MusicNameToken - "{{MusicNameToken}}"
//- UserNameToken - "{{UserNameToken}}"


using ServicePolymorphism_T4;

var musics = new 