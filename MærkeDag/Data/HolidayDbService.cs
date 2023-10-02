using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MærkeDag.Data
{
    // Create a service to manage the BirthdayDbContext
    public class HolidayDbService
    {
        private readonly HolidayDbContext _dbContext;

        public HolidayDbService(HolidayDbContext holidayDbContext)
        {

            _dbContext = holidayDbContext;
        }

        public async Task<List<Holiday>> GetHolidays()
        {
            return await _dbContext.Holiday.ToListAsync();
        }

        //Add Birthday
        public async Task<bool> AddHoliday(Holiday holiday)
        {
            await _dbContext.Holiday.AddAsync(holiday);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //Get User data by ID
        public async Task<Holiday> GetInfo(int id)
        {
            Holiday holiday = await _dbContext.Holiday.FirstOrDefaultAsync(x => x.Id == id);
            return holiday;
        }

        //Update BDAY User data
        public async Task<bool> Update(Holiday holiday)
        {
            _dbContext.Holiday.Update(holiday);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //Delete User data
        public async Task<bool> Delete(Holiday holiday)
        {
            _dbContext.Holiday.Remove(holiday);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
