using EshopUtilityBlock.Exceptions;

namespace Catalog.api.Exeptions
{
    public class productNotFoundExeption: NotFoundException
    {
        public productNotFoundExeption(Guid Id) : base("Product", Id)
        {
            
        }
    }
}
