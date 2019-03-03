using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ide2www.Roles.Dto;
using ide2www.Users.Dto;

namespace ide2www.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
