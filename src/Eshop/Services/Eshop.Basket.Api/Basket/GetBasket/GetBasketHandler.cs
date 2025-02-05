namespace Eshop.Basket.Api.Basket.GetBasket
{
    public record GetBasketQuery(string UserName) : IEshopQuery<GetBasketResult>;
    public record GetBasketResult(ShoppingCart Cart);
    public class GetBasketQueryHandler : IEshopQueryHandler<GetBasketQuery, GetBasketResult>
    {
        public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
        {
            //GetBasket the basket from db
            // Simulating async database call (Replace with actual async DB call)
            await Task.Delay(10, cancellationToken);

            return new GetBasketResult(new ShoppingCart("New"));
        }
    }
}
