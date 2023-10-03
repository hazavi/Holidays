using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MærkeDag.Data
{
    public class BirthdayDbService
    {
        private readonly HolidayDbContext _dbContext;

        public BirthdayDbService(HolidayDbContext birthdayDbContext)
        {
           
            _dbContext = birthdayDbContext;
        }

        public async Task<List<Birth>> GetBirthdays()
        {
            return await _dbContext.Birthdays.ToListAsync();
        }

        //Add Birthday
        public async Task<bool> AddBirthday(Birth birthday)
        {
            await _dbContext.Birthdays.AddAsync(birthday);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //Get User data by ID
        public async Task<Birth> GetInfoByID(int id)
        {
            Birth birthday = await _dbContext.Birthdays.FirstOrDefaultAsync(x=> x.ID == id);
            return birthday;
        }

        //Update BDAY User data
        public async Task<bool> UpdateUser(Birth birthday)
        {
            _dbContext.Birthdays.Update(birthday);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //Delete User data
        public async Task<bool> DeleteUser(Birth birthday)
        {
            _dbContext.Birthdays.Remove(birthday);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }

}
