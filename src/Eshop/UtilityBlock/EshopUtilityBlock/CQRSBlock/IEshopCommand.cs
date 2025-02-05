using MediatR;

namespace EshopUtilityBlock.CQRSBlock
{
    public interface IEshopCommand : IEshopCommand<Unit>;
    public interface IEshopCommand<out TResponse> : IRequest<TResponse>
    {
    }
}
