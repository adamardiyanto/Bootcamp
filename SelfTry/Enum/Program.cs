public enum Day{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

static class Program{
    static void Main(){
        Day today = Day.Monday;
        switch (today){
            case Day.Sunday:
                Console.WriteLine("Sunday");
                break;
            case Day.Monday:
                Console.WriteLine("Monday");
                break;
            case Day.Tuesday:
                Console.WriteLine("Tuesday");
                break;
        }

        foreach (var day in Enum.GetValues(typeof(Day))){
            Console.WriteLine(day);
        }

        Day day1 = Day.Monday;
        int dayNumber = (int)day1;
        string dayString = day1.ToString();
        Console.WriteLine(dayString);
        Console.WriteLine(dayNumber);

        string dayOfWeekString = "Tuesday";
        Console.WriteLine(typeof(Day));
        Console.WriteLine(dayOfWeekString);
        Day day2 = (Day)Enum.Parse(typeof(Day), dayOfWeekString);
        Console.WriteLine(day2);

        string invalidString = "Sunday";
        Day dayOfWeek;
        if (Enum.TryParse<Day>(invalidString, out dayOfWeek)){
            Console.WriteLine(dayOfWeek);
        }else{
            Console.WriteLine("Invalid day");
        }



    }
}