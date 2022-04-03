using System.Collections.Generic;

namespace WarehouseManager.Application.Responses.Identity
{
    public class GetAllRolesResponse
    {
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
}