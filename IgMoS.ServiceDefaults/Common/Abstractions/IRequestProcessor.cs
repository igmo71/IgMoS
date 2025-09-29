namespace IgMoS.ServiceDefaults.Common.Abstractions
{
    public interface IRequestProcessor<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        Task<TResponse> Process(TRequest request, Func<Task<TResponse>> next, CancellationToken ct);
    }
}
