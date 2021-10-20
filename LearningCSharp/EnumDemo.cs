using System;

public enum EMeetingDays
{
    Monday, Tuesday, Wednesday, Thursday, Friday
}

public class EnumDemo
{
    static void Main(string[] args)
    {
        EMeetingDays meetingDay = EMeetingDays.Thursday;
        Console.WriteLine(meetingDay);
    }
}
