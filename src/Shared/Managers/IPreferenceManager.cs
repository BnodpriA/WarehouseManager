using WarehouseManager.Shared.Settings;
using System.Threading.Tasks;
using WarehouseManager.Shared.Wrapper;

namespace WarehouseManager.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}