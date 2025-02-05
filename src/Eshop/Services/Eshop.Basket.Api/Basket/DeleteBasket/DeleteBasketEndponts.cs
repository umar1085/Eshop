
namespace Eshop.Basket.Api.Basket.DeleteBasket
{
    public record DeleteBasketRequest(string UserName);
    public record DeleteBasketResponse(bool IsSuccess);
    public class DeleteBasketEndponts
    {
        ////public void AddRoutes(IEndpointRouteBuilder app)
        ////{
        ////    app.MapGet("/Basket{UserName}", async (string UserName, ISender send) =>
        ////    {
        ////        var result = await send.Send(new DeleteBasketQuery(UserName));

        ////        var response = result.Adapt<DeleteBasketResponse>();

        ////        return Results.Ok(response);
        ////    })
        ////        .WithName("Delete Basket")
        ////      .Produces<GetBasketResponse>(StatusCodes.Status200OK)
        ////      .ProducesProblem(StatusCodes.Status400BadRequest)
        ////      .WithSummary("Delete Basket")
        ////      .WithSummary("Delete Basket");
        ////}
    }
}
