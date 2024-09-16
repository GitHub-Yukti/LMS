using System.Collections.Generic;
using LMS.Roles.Dto;

namespace LMS.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}