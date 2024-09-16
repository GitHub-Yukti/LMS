using System.Collections.Generic;
using LMS.Roles.Dto;

namespace LMS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
