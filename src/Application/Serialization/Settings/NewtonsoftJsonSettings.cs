
using WarehouseManager.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace WarehouseManager.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}