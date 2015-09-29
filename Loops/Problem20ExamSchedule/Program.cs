using System;

namespace Problem20ExamSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            int durationHours = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());

            if (partOfTheDay == "PM")
            {
                hours = hours + 12;
                if (hours == 24)
                {
                    hours = 0;
                }
            }

            DateTime myDataTime = new DateTime(2010, 8, 18, hours, minutes, 0);
            DateTime result = myDataTime.AddHours(durationHours).AddMinutes(durationMinutes);

            Console.WriteLine("{0:hh:mm:tt}",result);
        }
    }
}
