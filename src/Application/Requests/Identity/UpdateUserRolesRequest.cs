using WarehouseManager.Application.Responses.Identity;
using System.Collections.Generic;

namespace WarehouseManager.Application.Requests.Identity
{
    public class UpdateUserRolesRequest
    {
        public string UserId { get; set; }
        public IList<UserRoleModel> UserRoles { get; set; }
    }
}