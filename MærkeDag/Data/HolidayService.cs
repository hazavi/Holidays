// HolidayService.cs
using System.Collections.Generic;
using System.Linq;

namespace MærkeDag.Data
{


    public class HolidayService
    {
        private List<Holiday> holidays = new List<Holiday>();

        public List<Holiday> GetHolidays()
        {
            return holidays;
        }

        public void AddHoliday(Holiday holiday)
        {
            holidays.Add(holiday);
        }

        public void UpdateHoliday(DateTime date, Holiday updatedHoliday)
        {
            var existingHoliday = holidays.FirstOrDefault(h => h.Date == date);
            if (existingHoliday != null)
            {
                // Update properties of existingHoliday with updatedHoliday
                existingHoliday.LocalName = updatedHoliday.LocalName;
                existingHoliday.Date = updatedHoliday.Date;
            }
        }

        public void DeleteHoliday(string name)
        {
            var existingHoliday = holidays.FirstOrDefault(h => h.LocalName == name);
            if (existingHoliday != null)
            {
                holidays.Remove(existingHoliday);
            }
        }
    }

}
