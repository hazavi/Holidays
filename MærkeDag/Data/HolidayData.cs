using System;
using System.Collections.Generic;

namespace MærkeDag.Data
{

    public static class HolidayData
    {
        public static List<Holiday> GetHolidaysForMonth(DateTime month)
        {
            // Replace this mock data with the provided holiday data
            var holidays = new List<Holiday>
        {
            new Holiday
            {
                Date = new DateTime(2023, 1, 1),
                LocalName = "Nytårsdag",
                Name = "New Year's Day"
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 6),
                LocalName = "Skærtorsdag",
                Name = "Maundy Thursday"
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 7),
                LocalName = "Langfredag",
                Name = "Good Friday"
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 9),
                LocalName = "Påskedag",
                Name = "Easter Sunday"
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 10),
                LocalName = "2. Påskedag",
                Name = "Easter Monday"
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 5),
                LocalName = "Store bededag",
                Name = "General Prayer Day"
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 18),
                LocalName = "Kristi Himmelfartsdag",
                Name = "Ascension Day"
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 19),
                LocalName = "Banklukkedag",
                Name = "Bank closing day"
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 28),
                LocalName = "Pinsedag",
                Name = "Pentecost"
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 29),
                LocalName = "2. Pinsedag",
                Name = "Whit Monday"
            },
            new Holiday
            {
                Date = new DateTime(2023, 6, 5),
                LocalName = "Grundlovsdag",
                Name = "Maundy Thursday"
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 24),
                LocalName = "Juleaftensdag",
                Name = "Christmas Eve"
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 25),
                LocalName = "Juledag / 1. juledag",
                Name = "Christmas Day"
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 26),
                LocalName = "2. juledag",
                Name = "St. Stephen's Day"
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 31),
                LocalName = "Nytårsaftensdag",
                Name = "New Year's Eve"
            },
        };

            return holidays;
        }
    }

}
