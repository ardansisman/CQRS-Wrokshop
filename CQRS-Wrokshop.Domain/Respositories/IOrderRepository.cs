using CQRS_Wrokshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Wrokshop.Domain.Respositories
{
   public interface IOrderRepository:IRepository<Order>
    {
    }
}
