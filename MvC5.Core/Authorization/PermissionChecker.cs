using Abp.Authorization;
using MvC5.Authorization.Roles;
using MvC5.Authorization.Users;

namespace MvC5.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
