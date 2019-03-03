using System.Threading.Tasks;
using Abp.Application.Services;
using ide2www.Authorization.Accounts.Dto;

namespace ide2www.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
