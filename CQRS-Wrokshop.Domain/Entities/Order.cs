using CQRS_Wrokshop.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CQRS_Wrokshop.Domain.Entities
{
    [Table("orders", Schema = "public")]
    public class Order
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentType PaymentType { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
