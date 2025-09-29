namespace IgMoS.ServiceDefaults.Common.Abstractions
{
    internal interface IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
