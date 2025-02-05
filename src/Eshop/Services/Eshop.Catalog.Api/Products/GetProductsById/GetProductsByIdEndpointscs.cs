using Eshop.Catalog.Api.Products.CreateProductHandler;

namespace Eshop.Catalog.Api.Products.GetProductsById
{
    //public record GetProductResultByIdQuery(Guid  id): IQuery(GetProductResultById);
    public record GetProductsResponse(Product Products);

    public class GetProductsByIdEndpointscs : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/products/{id}", async (Guid Id, ISender sender) =>
            {
                var result = await sender.Send(new GetProductsByIdQuery(Id));

                var response = result.Adapt<GetProductsResponse>();

                return Results.Ok(response);
            }).WithName("Get Product By Id")
              .Produces<CreateProductResponse>(StatusCodes.Status200OK)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Get Product By Id")
              .WithSummary("Get product By Id");
        }
    }
}
