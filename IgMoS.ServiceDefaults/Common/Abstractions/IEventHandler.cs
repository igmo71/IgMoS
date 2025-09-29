namespace IgMoS.ServiceDefaults.Common.Abstractions
{
    public interface IEventHandler<TEvent>
    {
        Task Handle(TEvent @event, CancellationToken ct);
    }
}
