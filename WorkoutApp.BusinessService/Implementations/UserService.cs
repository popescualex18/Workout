using Workout.DataAccessLayer;
using WorkoutApp.BusinessService.Interfaces;
using WorkoutApp.Domain;
using WorkoutApp.DTOs;

namespace WorkoutApp.BusinessService.Implementations
{
    public class UserService : IUserService
    {
        private readonly WorkoutDbContext _dbContext;
        public UserService(WorkoutDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddUser(UserDto user)
        {
            var userToAdd = new User
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
            };
            _dbContext.Users.Add(userToAdd);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(Guid id)
        {
            var existingUser = _dbContext.Users.Find(id);
            if (existingUser != null)
            {
                _dbContext.Users.Remove(existingUser);
                _dbContext.SaveChanges();
            }
        }

        public IList<UserDto> GetAll()
        {
            return _dbContext.Users.Select(x => new UserDto
            {
                Email = x.Email,
                Id = x.Id,
                Name = x.Name,
                Password = x.Password,
            }).ToList();
        }

        public UserDto? GetById(Guid id)
        {
            User? user = _dbContext.Users.Find(id);
            if (user != null)
            {
                return new UserDto
                {
                    Email = user.Email,
                    Id = user.Id,
                    Name = user.Name,
                    Password = user.Password,
                };
            }
            return null;
        }

        public void UpdateUser(UserDto user)
        {
            var existingUser = _dbContext.Users.Find(user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                _dbContext.Users.Update(existingUser);
                _dbContext.SaveChanges();
            }
        }
    }
}
