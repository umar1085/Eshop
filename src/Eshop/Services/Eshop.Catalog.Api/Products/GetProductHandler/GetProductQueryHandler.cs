namespace Eshop.Catalog.Api.Products.GetProductHandler
{
    public record GetProductsQuery(int? Paganumber = 1, int? PagaSize = 10) : IEshopQuery<GetProductsResult>;
    public record GetProductsResult(IEnumerable<Product> Products);

    internal class GetProductQueryHandler(IDocumentSession session, ILogger<GetProductQueryHandler> logger)
        : IEshopQueryHandler<GetProductsQuery, GetProductsResult>
    {
        public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
        {
            logger.LogInformation("GetProductQueryHandler.Handle called with {@query}", query);

            var products = await session.Query<Product>()
                .ToPagedListAsync(query.Paganumber ?? 1, query.PagaSize ?? 10, cancellationToken);

            return new GetProductsResult(products);
        }
    }
}
