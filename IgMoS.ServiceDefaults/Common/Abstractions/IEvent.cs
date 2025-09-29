namespace IgMoS.ServiceDefaults.Common.Abstractions
{
    public interface IEvent<TValue>
    {
        public DateTime Occured { get; }
        public TValue Value { get; }
    }
}
