using WarehouseManager.Application.Requests.Mail;
using System.Threading.Tasks;

namespace WarehouseManager.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}