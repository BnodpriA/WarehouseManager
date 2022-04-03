using System.Linq;
using WarehouseManager.Shared.Constants.Localization;
using WarehouseManager.Shared.Settings;

namespace WarehouseManager.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}