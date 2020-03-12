using System.Collections.Generic;
using MvC5.Roles.Dto;
using MvC5.Users.Dto;

namespace MvC5.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}