using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshopUtilityBlock.CQRSBlock
{
    public interface IEshopQueryHandler<in TQuery, TResponse>:IRequestHandler<TQuery,TResponse>
        where TQuery : IEshopQuery<TResponse>
        where TResponse : notnull
    {
    }
}
