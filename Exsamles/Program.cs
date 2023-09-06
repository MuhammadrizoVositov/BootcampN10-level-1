

//Product modelidan foydalaning ( id, name, description )
//-bunda id init-only bo'lsin
//- name va description read-only bo'lsin ( private set )
//- name va descriptino getter methodi ichida name va description ni validate qiling ( regex dan foydalanish ixtiyoriy, is null or white space yetarli )
//-parameterized constructorda name va description bo'lsin
//- copy constructor orqali Product ni copy qiladigan qiling

//- Product modelidan bir nechta object yarating ( valid va invalid )
//-Singleton pattern ishlatilgan ProductService ni yarating
//- unda Add methodi bo'lsin ( name, description ), agar product yaratishda exception bo'lsa konsolga exception chiqsin
//- unda Clone methodi bo'lsin ( id ) - u product ni topib, copy qilinganini kolleksiyaga qo'shib qo'ysin
//- unda Display methodi hamma productlarni ekranga chiqarsin

//- ProductService dan instance oling, valid invalid modellar qo'shib, Clone methodi orqali clonelar qilib, ekranga chiqaring



//N32-T4 service, polymorphism, class types, encapsulation

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



using Exsamles;
ProductService productService = ProductService.










//Product validProduct1 = new Product( "samsung", "sef");
//Product validProduct2 = new Product("Iphone", "pro");
//Product inValidProduct1 = new Product( "Nokia", "sjdc");
//Product inValidProduct2 = new Product("Motorola", "gfds");


