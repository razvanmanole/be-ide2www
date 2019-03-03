using System.Threading.Tasks;
using ide2www.Configuration.Dto;

namespace ide2www.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
