using System.Threading.Tasks;
using Abp.Application.Services;
using ide2www.Sessions.Dto;

namespace ide2www.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
