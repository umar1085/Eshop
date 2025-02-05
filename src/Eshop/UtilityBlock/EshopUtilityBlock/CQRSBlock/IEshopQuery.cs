using MediatR;

namespace EshopUtilityBlock.CQRSBlock
{
    public interface IEshopQuery<out TResponse> : IRequest<TResponse> 
        where TResponse : notnull
    {
    }
}
