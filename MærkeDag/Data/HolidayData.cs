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
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 6),
                LocalName = "Skærtorsdag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 7),
                LocalName = "Langfredag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 9),
                LocalName = "Påskedag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 10),
                LocalName = "2. Påskedag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 5),
                LocalName = "Store bededag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 18),
                LocalName = "Kristi Himmelfartsdag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 19),
                LocalName = "Banklukkedag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 28),
                LocalName = "Pinsedag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 29),
                LocalName = "2. Pinsedag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 6, 5),
                LocalName = "Grundlovsdag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 24),
                LocalName = "Juleaftensdag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 25),
                LocalName = "Juledag / 1. juledag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 26),
                LocalName = "2. juledag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 31),
                LocalName = "Nytårsaftensdag",
            },
        };

            return holidays;
        }
    }

}
