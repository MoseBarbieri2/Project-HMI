using System.Threading.Tasks;

namespace Template_UMI.web1.SignalR
{
    public interface IPublishDomainEvents
    {
        Task Publish(object evnt);
    }
}
