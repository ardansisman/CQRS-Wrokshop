using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CQRS_Wrokshop.Domain.Entities.Enums
{
    public enum PaymentType
    {
        [Display(Name = "Online Ödeme")]
        Online = 0,
        [Display(Name = "Kapıda Ödeme")]
        CashOnDelivery = 1,
    }
}
