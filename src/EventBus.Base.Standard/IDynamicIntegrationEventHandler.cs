using System.Threading.Tasks;

namespace EventBus.Base.Standard
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
