using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum PriceReason
    {
        BuildersWish = 0,
        ProjectChange = 1,
        AdditionalPrice = 2,
        AfterBill = 3,
        DiscountedPrice = 4,
        AfterOffer = 5,
        AgreedPrice = 6,
        ByUnitPrice = 7,
        Other = 8
    }
}
