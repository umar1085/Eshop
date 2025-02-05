using MediatR;

namespace EshopUtilityBlock.CQRSBlock
{
    public interface IEshopCommandHandler<in TCommand> : IEshopCommandHandler<TCommand , Unit>
        where TCommand : IEshopCommand<Unit>
    {

    }
    public interface IEshopCommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand: IEshopCommand<TResponse>
        where TResponse : notnull
    {
    }
}
