namespace Eshop.Catalog.Api.Products.GetProductsByCatagory
{
    public record GetproductByCategoryQuery(string category) : IEshopQuery<GetProductsResult>;
    public record GetProductsResult(IEnumerable<Product> Products);
    internal class GetProductsByCategoryQueryHandler(IDocumentSession session, ILogger<GetProductsByCategoryQueryHandler> loggerInfo)
        : IEshopQueryHandler<GetproductByCategoryQuery, GetProductsResult>
    {
        public async Task<GetProductsResult> Handle(GetproductByCategoryQuery request, CancellationToken cancellationToken)
        {
            loggerInfo.LogInformation("GetProductsByCategoryQueryHandler handle by {@query}", request);

            var products = await session.Query<Product>()
                .Where(p => p.Category.Contains(request.category)).ToListAsync(cancellationToken);

            return new GetProductsResult(products);
        }
    }
}
