using System;


enum categories{

    Electronics=1,
    food =5,
    Automotive =6,
    Art=2,
    Fashion=8

}

public enum WeekDays
{
    Monday ,  
    Tuesday ,  
    Wednesday,  
    Thursday,  
    Friday  ,  
    Saturday  ,  
    Sunday    
}

public class FlagsEnumExample
{
    public static void Main()
    {
        System.Console.WriteLine(WeekDays.Monday);
        System.Console.WriteLine(WeekDays.Tuesday);
        System.Console.WriteLine(WeekDays.Wednesday);
        System.Console.WriteLine(WeekDays.Thursday);
        System.Console.WriteLine(WeekDays.Friday);
        System.Console.WriteLine(WeekDays.Saturday);
        System.Console.WriteLine(WeekDays.Sunday);

     System.Console.WriteLine(WeekDays.Friday);
        int day=(int) WeekDays.Friday;
    System.Console.WriteLine(day);

    var wd =(WeekDays) 5;
    System.Console.WriteLine(wd);
    }
}