
using Eshop.Catalog.Api.Products.DeleteProductsById;
using Eshop.Catalog.Api.Products.UpdateProducts;
using FluentValidation;

namespace Eshop.Catalog.Api.Products.CreateProductHandler
{
    public class ProductValidator : AbstractValidator<CreateProductCommand>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is Required");
            RuleFor(x => x.Category).NotEmpty().WithMessage("Category is Required");
            RuleFor(x => x.ImageFile).NotEmpty().WithMessage("ImageFile is Required");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
        }
    }

    public class UpdaeProductValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdaeProductValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID is Required");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is Required").Length(125).WithMessage("Name lenght is 125 charcter");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
        }
    }

    public class DeleteProductValidator : AbstractValidator<DeleteProductQuery>
    {
        public DeleteProductValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID is Required");
        }
    }
}
