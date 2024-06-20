using Microsoft.AspNetCore.Components;
using WorkoutApp.BusinessService.Interfaces;
using WorkoutApp.DTOs;

namespace SmartWorkout.Features.Users.Overview
{
    public partial class Overview : ComponentBase
    {
        private List<UserDto> _users = new();

        protected string SearchString { get; set; } = string.Empty;
        [Inject]
        private IUserService IUserService { get; set; }

        public List<UserDto> Users;

        protected override void OnInitialized()
        {
            Users = IUserService.GetAll().ToList();
            _users = Users;
        }
        protected void FilterUser()
        {
            if (!string.IsNullOrEmpty(SearchString))
            {
                Users = _users.Where(x => x.Name.StartsWith(SearchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else
            {
                Users = _users;
            }
        }
        public void ResetSearch()
        {
            SearchString = string.Empty;
            Users = _users;
        }

        public void DeleteUser(Guid id)
        {
            IUserService.DeleteUser(id);
            Users = IUserService.GetAll().ToList();
        }
    }
}
