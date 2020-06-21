using System.Threading.Tasks;
using Consultarte.Configuration.Dto;

namespace Consultarte.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
