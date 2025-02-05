using Eshop.Catalog.Api.Products.CreateProductHandler;

namespace Eshop.Catalog.Api.Products.GetProductsByCatagory
{
    public record GetProductsResponse(IEnumerable<Product> Products);
    public class GetProductsByCategoryEndPoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/products/category/{category}", async (string category, ISender sender) =>
            {
                var result = await sender.Send(new GetproductByCategoryQuery(category));

                var response = result.Adapt<GetProductsResponse>();

                return Results.Ok(response);
            }).WithName("Get Product By Category")
              .Produces<CreateProductResponse>(StatusCodes.Status200OK)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Get Product By Category")
              .WithSummary("Get product By Category");
        }
    }
}
