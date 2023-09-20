using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MærkeDag.Data
{
    // Create a service to manage the BirthdayDbContext
    public class BirthdayDbService
    {
        private readonly BirthdayDbContext _dbContext;

        public BirthdayDbService(BirthdayDbContext birthdayDbContext)
        {
           
            _dbContext = birthdayDbContext;
        }

        public async Task<List<Birthday>> GetBirthdays()
        {
            return await _dbContext.Birthdays.ToListAsync();
        }

        //Add Birthday
        public async Task<bool> AddBirthday(Birthday birthday)
        {
            await _dbContext.Birthdays.AddAsync(birthday);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //Get User data by ID
        public async Task<Birthday> GetInfoByID(int id)
        {
            Birthday birthday = await _dbContext.Birthdays.FirstOrDefaultAsync(x=> x.ID == id);
            return birthday;
        }

        //Update BDAY User data
        public async Task<bool> UpdateUser(Birthday birthday)
        {
            _dbContext.Birthdays.Update(birthday);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //Delete User data
        public async Task<bool> DeleteUser(Birthday birthday)
        {
            _dbContext.Birthdays.Remove(birthday);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }

}
