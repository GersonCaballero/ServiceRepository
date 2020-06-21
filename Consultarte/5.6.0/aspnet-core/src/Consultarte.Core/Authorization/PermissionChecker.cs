using Abp.Authorization;
using Consultarte.Authorization.Roles;
using Consultarte.Authorization.Users;

namespace Consultarte.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
