namespace Eshop.Basket.Api.Basket.BasketValidation
{
    public class BasketValidation : AbstractValidator<StoreBasketCommand>
    {
        public BasketValidation()
        {
            RuleFor(x => x.Cart).NotNull().WithMessage("Cart can not be null");
            RuleFor(x => x.Cart.UserName).NotNull().WithMessage("UserName is Requied");

        }
    }

    public class GetBasketValidation : AbstractValidator<GetBasketQuery>
    {
        public GetBasketValidation()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("User Name is Required");           

        }
    }

    public class DeleteBasketValidation : AbstractValidator<DeleteBasketQuery>
    {
        public DeleteBasketValidation()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("User Name is Required");

        }
    }
}
