﻿namespace IgMoS.ServiceDefaults.Common.Abstractions
{
    public interface IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        Task<TResponse> Handle(TRequest request, CancellationToken ct);
    }
}
