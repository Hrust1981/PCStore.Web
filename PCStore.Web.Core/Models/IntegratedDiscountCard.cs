﻿namespace PCStore.Web.Core.Models
{
    public class IntegratedDiscountCard : DiscountCard
    {
        private int _discount = 15;
        public override int Discount => _discount;
    }
}
