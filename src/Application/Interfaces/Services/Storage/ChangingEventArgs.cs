using System.Diagnostics.CodeAnalysis;

namespace WarehouseManager.Application.Interfaces.Services.Storage
{
    [ExcludeFromCodeCoverage]
    public class ChangingEventArgs : ChangedEventArgs
    {
        public bool Cancel { get; set; }
    }
}