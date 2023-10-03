using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MærkeDag.Data
{
    public class HolidayDbService
    {
        private readonly HolidayDbContext _dbContext;

        public HolidayDbService(HolidayDbContext holidayDbContext)
        {

            _dbContext = holidayDbContext;
        }

        public async Task<List<Holiday>> GetBirthdays()
        {
            return await _dbContext.Holidays.ToListAsync();
        }

        //Add Birthday
        public async Task<bool> AddHoliday(Holiday holiday)
        {
            await _dbContext.Holidays.AddAsync(holiday);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //Get User data by ID
        public async Task<Holiday> GetInfoByID(int id)
        {
            Holiday holiday = await _dbContext.Holidays.FirstOrDefaultAsync(x => x.ID == id);
            return holiday;
        }

        //Update BDAY User data
        public async Task<bool> Update(Holiday holiday)
        {
            _dbContext.Holidays.Update(holiday);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //Delete User data
        public async Task<bool> Delete(Holiday holiday)
        {
            _dbContext.Holidays.Remove(holiday);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }

}
