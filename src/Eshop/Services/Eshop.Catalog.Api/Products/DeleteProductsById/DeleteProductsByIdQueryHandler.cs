namespace Eshop.Catalog.Api.Products.DeleteProductsById
{
    public record DeleteProductQuery(Guid Id) : IEshopCommand<DeleteProductResult>;
    public record DeleteProductResult(bool IsSuccess);

    public class DeleteProductsByIdQueryHandler(IDocumentSession session, ILogger<DeleteProductsByIdQueryHandler> logger)
        : IEshopCommandHandler<DeleteProductQuery, DeleteProductResult>
    {
        public async Task<DeleteProductResult> Handle(DeleteProductQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("DeleteProductsByIdQueryHandler.Hander called by {@request}", request);

            ////var product = await session.LoadAsync<Product>(request.Id, cancellationToken);
            ////if (product is null)
            ////{
            ////    throw new productNotFoundExeption();
            ////}

            session.Delete<Product>(request.Id);
            await session.SaveChangesAsync(cancellationToken);
            return new DeleteProductResult(true);
        }
    }
}
