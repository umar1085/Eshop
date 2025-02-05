namespace Eshop.Basket.Api.Basket.StoreBasket
{
    public record StoreBasketRequest(ShoppingCart Cart);
    public record StoreBasketResponse(string UserName);
    public class StoreBasketEndponts
    {
        ////public void AddRoutes(IEndpointRouteBuilder app)
        ////{
        ////    app.MapPost("/Basket", async (ShoppingCart request, ISender sender) =>
        ////    {
        ////        var command = request.Adapt<StoreBasketCommand>();

        ////        var result = await sender.Send(command);

        ////        var response = result.Adapt<StoreBasketResponse>();

        ////        return Results.Created($"/basket/{response.UserName}", response);

        ////    }).WithName("CreateProduct")
        ////      .Produces<StoreBasketResponse>(StatusCodes.Status201Created)
        ////      .ProducesProblem(StatusCodes.Status400BadRequest)
        ////      .WithSummary("Create Product")
        ////      .WithSummary("Create product");
        ////}
    }
}
