namespace Eshop.Catalog.Api.Products.DeleteProductsById
{
    public record DeleteProductResponse(bool IsSuccess);
    public class DeleteProductsByIdEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/products/Delete/{Id}", async (Guid Id, ISender sender) =>
            {
                var result = await sender.Send(new DeleteProductQuery(Id));

                var response = result.Adapt<DeleteProductResponse>();
                return Results.Ok(response);
            })
               .WithName("DeleteProduct")
               .Produces<DeleteProductResponse>(StatusCodes.Status200OK)
               .ProducesProblem(StatusCodes.Status400BadRequest)
               .WithSummary("Delete Product")
               .WithSummary("Delete product");
        }
    }
}
