using System.Text.Json;
using WarehouseManager.Application.Interfaces.Serialization.Options;

namespace WarehouseManager.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}