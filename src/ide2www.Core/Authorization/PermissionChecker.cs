using Abp.Authorization;
using ide2www.Authorization.Roles;
using ide2www.Authorization.Users;

namespace ide2www.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
