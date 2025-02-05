namespace Eshop.Basket.Api.Basket.StoreBasket
{
    public record StoreBasketCommand(ShoppingCart Cart) : IEshopCommand<StoreBasketResult>;
    public record StoreBasketResult(string UserName);
    public class StoreBasketHandler() : IEshopCommandHandler<StoreBasketCommand, StoreBasketResult>
    {
        public async Task<StoreBasketResult> Handle(StoreBasketCommand command, CancellationToken cancellationToken)
        {
            ShoppingCart Cart = command.Cart;
            // Simulating async database call (Replace with actual async DB call)
            await Task.Delay(10, cancellationToken);


            return new StoreBasketResult(Cart.UserName);
        }
    }
}
