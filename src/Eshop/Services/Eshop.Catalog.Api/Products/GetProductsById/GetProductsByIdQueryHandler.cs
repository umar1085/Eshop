namespace Eshop.Catalog.Api.Products.GetProductsById
{
    public record GetProductsByIdQuery(Guid Id) : IEshopQuery<GetProductsResult>;
    public record GetProductsResult(Product Products);
    internal class GetProductsByIdQueryHandler(IDocumentSession session, ILogger<GetProductsByIdQueryHandler> logger)
        : IEshopQueryHandler<GetProductsByIdQuery, GetProductsResult>
    {
        public async Task<GetProductsResult> Handle(GetProductsByIdQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("GetProductsByIdQueryHandler handle the {@query}", request);

            var product = await session.LoadAsync<Product>(request.Id, cancellationToken);

            if (product is null)
            {
                throw new productNotFoundExeption(request.Id);
            }

            return new GetProductsResult(product);

        }
    }
}
