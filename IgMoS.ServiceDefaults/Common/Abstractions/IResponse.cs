namespace IgMoS.ServiceDefaults.Common.Abstractions;

public interface IResponse<TValue> where TValue : class, new()
{
    public TValue Value { get; }
}