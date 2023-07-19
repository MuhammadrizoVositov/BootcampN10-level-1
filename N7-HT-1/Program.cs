// See https://aka.ms/new-console-template for more information
var workStart = new TimeOnly(8,00,00);
var workEnd = new TimeOnly(8,00,00);
var meetingStart = new DateTime[4];
{
    new DateTime(2023, 08, 10, 08,00,00);
    new DateTime(2023, 07, 18, 08, 00, 00);
    new DateTime(2023, 10, 14, 08, 00, 00);
    new DateTime(2023, 09, 11, 08, 00, 00);
}
var meetingEnd = new TimeSpan[4]
{
    TimeSpan.FromMinutes(30),
    TimeSpan.FromMinutes(40),
    TimeSpan.FromMinutes(10),
    TimeSpan.FromMinutes(20),
};
for (int i = 0; i < 4; i++)
{
    meetingStart[i] = meetingStart[i + 1].AddMinutes(meetingEnd[i]);
    if (meetingStart[i].Hour > workStart.Hour || )
    {


    }
}
