namespace Eshop.Basket.Api.Basket.GetBasket
{
    public record GetBasketResponse(ShoppingCart Cart);
    public class GetBasketEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/Basket{UserName}", async (string UserName, ISender send) =>
            {

                var result = await send.Send(new GetBasketQuery(UserName));

                var response = result.Adapt<GetBasketResponse>();

                return Results.Ok(response);
            })
                .WithName("Get Basket")
              .Produces<GetBasketResponse>(StatusCodes.Status200OK)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Get Basket")
              .WithSummary("Get Basket");
        }
    }
}
