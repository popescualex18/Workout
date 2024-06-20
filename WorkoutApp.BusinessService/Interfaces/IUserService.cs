using WorkoutApp.DTOs;

namespace WorkoutApp.BusinessService.Interfaces
{
    public interface IUserService
    {
        IList<UserDto> GetAll();
        UserDto? GetById(Guid id);
        void UpdateUser(UserDto user);
        void AddUser(UserDto user);
        void DeleteUser(Guid id);
    }
}
