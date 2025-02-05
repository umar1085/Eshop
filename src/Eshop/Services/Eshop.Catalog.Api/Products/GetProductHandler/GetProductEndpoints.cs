using Eshop.Catalog.Api.Products.CreateProductHandler;

namespace Eshop.Catalog.Api.Products.GetProductHandler
{
    public record GetProductsRequest(int? Paganumber = 1, int? PagaSize = 10);
    public record GetProductsResponse(IEnumerable<Product> Products);
    public class GetProductEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/products", async ([AsParameters] GetProductsRequest request, ISender sender) =>
            {
                var query = request.Adapt<GetProductsQuery>();

                var result = await sender.Send(query);

                var response = result.Adapt<GetProductsResponse>();

                return Results.Ok(response);

            }).WithName("Get Product")
              .Produces<CreateProductResponse>(StatusCodes.Status201Created)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Get Product")
              .WithSummary("Get product");
        }
    }
}
