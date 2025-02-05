namespace Eshop.Catalog.Api.Products.CreateProductHandler
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        : IEshopCommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    public class CreateProductCommandHandler
        (IDocumentSession session)
        : IEshopCommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //Create Product entity from command object 
            // Save entity into database 
            // return the result CreateProductResult as Guid Id 

            ////var result = await validate.ValidateAsync(command, cancellationToken);
            ////var error = result.Errors.Select(x => x.ErrorMessage).ToList();

            ////if (error.Any())
            ////{
            ////    throw new ValidationException(error.FirstOrDefault());
            ////}

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            // Save entity into database 
            session.Store(product);
            await session.SaveChangesAsync(cancellationToken);
            // return the result CreateProductResult as Guid Id 
            return new CreateProductResult(product.Id);
        }
    }
}
