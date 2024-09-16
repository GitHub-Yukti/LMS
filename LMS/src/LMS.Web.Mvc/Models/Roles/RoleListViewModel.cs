using System.Collections.Generic;
using LMS.Roles.Dto;

namespace LMS.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
