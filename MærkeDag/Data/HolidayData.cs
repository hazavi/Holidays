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
                Name = "Nytårsdag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 6),
                Name = "Skærtorsdag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 7),
                Name = "Langfredag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 9),
                Name = "Påskedag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 4, 10),
                Name = "2. Påskedag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 5),
                Name = "Store bededag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 18),
                Name = "Kristi Himmelfartsdag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 19),
                Name = "Banklukkedag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 28),
                Name = "Pinsedag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 5, 29),
                Name = "2. Pinsedag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 6, 5),
                Name = "Grundlovsdag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 24),
                Name = "Juleaftensdag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 25),
                Name = "Juledag / 1. juledag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 26),
                Name = "2. juledag",
            },
            new Holiday
            {
                Date = new DateTime(2023, 12, 31),
                Name = "Nytårsaftensdag",
            },
        };

            return holidays;
        }
    }

}