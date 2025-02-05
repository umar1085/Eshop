namespace Eshop.Basket.Api.Basket.DeleteBasket
{
    public record DeleteBasketQuery(string UserName) : IEshopCommand<DeleteBasketResult>;
    public record DeleteBasketResult(bool IsSuccess);
    public class DeleteBasketHandler : IEshopCommandHandler<DeleteBasketQuery, DeleteBasketResult>
    {
        public async Task<DeleteBasketResult> Handle(DeleteBasketQuery command, CancellationToken cancellationToken)
        {
            // Simulating async database call (Replace with actual async DB call)
            await Task.Delay(10, cancellationToken);

            return new DeleteBasketResult(true);
        }
    }
}
