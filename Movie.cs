using System;
using System.Collections.Generic;
using System.Text;

namespace YesPlanetGefen
{
    public class Movie
    {
        string Name { get; set; }
        int StartHour { get; set; }
        int StartMinute { get; set; }
        int RunTimeInMinutes { get; set; }
        public Movie(string name, int startHour, int startMinute, int runTime)
        {
            Name = name;
            StartHour = startHour;
            StartMinute = startMinute;
            RunTimeInMinutes = runTime;
        }

        public HoursAndMinutes CalculateEndOfMovie()
        {
            int minutesPastMidnightAtEndOfMovie = StartHour * 60 + StartMinute + RunTimeInMinutes;
            int hoursPastMidnightAtEndOfMovie = minutesPastMidnightAtEndOfMovie / 60;
            int endHour = hoursPastMidnightAtEndOfMovie % 24;
            int endMinute = (StartMinute + RunTimeInMinutes) % 60;
            return new HoursAndMinutes
            {
                Hours = endHour,
                Minutes = endMinute
            };
        }

        public string CalculateEndOfMovieAsString()
        {
            HoursAndMinutes result = CalculateEndOfMovie();
            return $"{result.Hours.ToString("00")}:{result.Minutes.ToString("00")}"; // .ToString("00") turns 0:1 to 00:01 (at least to digits)
        }
    }
}
