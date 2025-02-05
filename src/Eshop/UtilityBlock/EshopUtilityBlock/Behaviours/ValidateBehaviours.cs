using EshopUtilityBlock.CQRSBlock;
using FluentValidation;
using MediatR;

namespace EshopUtilityBlock.Behaviours
{
    public class ValidateBehaviours<TRequest, TResponse>(IEnumerable<IValidator<TRequest>> validate) 
       : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IEshopCommand<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);

            var validations = await Task.WhenAll(validate.Select(x => x.ValidateAsync(context, cancellationToken)));

            var faliours = validations.Where(x =>x .Errors.Any()).SelectMany(x=> x.Errors).ToList();

            if(faliours.Any())
            {
                throw new ValidationException(faliours);
            }

            return await next();
        }
    }
}
