using IgMoS.ServiceDefaults.Common.Abstractions;
using System.Diagnostics.CodeAnalysis;

namespace IgMoS.ServiceDefaults.Common
{
    public class Response<TValue> : IResponse<TValue> where TValue : class, new()
    {
        private Response(TValue value)
        {
            IsSuccess = true;
            Value = value;
            Error = null;
        }

        private Response(Error error)
        {
            IsSuccess = false;
            Value = default;
            Error = error;
        }

        [MemberNotNullWhen(true, nameof(Value))]
        [MemberNotNullWhen(false, nameof(Error))]
        public bool IsSuccess { get; }
        public TValue? Value { get; }
        public Error? Error { get; }

        // Helper methods for constructing the `Result<T>`
        public static Response<TValue> Success(TValue value) => new(value);
        public static Response<TValue> Fail(Error error) => new(error);

        // Allow converting a T directly into Result<T>
        public static implicit operator Response<TValue>(TValue value) => Success(value);
        public static implicit operator Response<TValue>(Error error) => Fail(error);
    }
}
