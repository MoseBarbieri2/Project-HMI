using System.Threading.Tasks;

namespace Project_HMI.web.SignalR
{
    public interface IPublishDomainEvents
    {
        Task Publish(object evnt);
    }
}
