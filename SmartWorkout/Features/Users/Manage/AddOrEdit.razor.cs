using Microsoft.AspNetCore.Components;
using WorkoutApp.BusinessService.Interfaces;
using WorkoutApp.DTOs;

namespace SmartWorkout.Features.Users.Manage
{
    public partial class AddOrEdit : ComponentBase
    {
        [Inject]
        protected IUserService UserService
        {
            get; set;
        }

        [Inject]
        protected AppNavigation Navigation
        {
            get; set;
        }
        [Parameter]
        public Guid? UserId { get; set; }
        public UserDto? User { get; set; }
        protected string Title = "Add";
        protected bool IsLoading = true;
        private Action _submit;

        protected override void OnParametersSet()
        {
            if (UserId != null)
            {
                Title = "Edit";
                User = UserService.GetById((Guid)UserId);
                _submit = UpdateUser;
                IsLoading = false;
                return;

            }
            IsLoading = false;
            User = new UserDto();

            _submit = AddUser;
        }
        protected void SaveUser()
        {
            _submit.Invoke();
            Navigation.NavigateToHome();
        }

        private void AddUser()
        {
            UserService.AddUser(user: User);
        }
        private void UpdateUser()
        {
            UserService.UpdateUser(user: User);
        }
    }
}
