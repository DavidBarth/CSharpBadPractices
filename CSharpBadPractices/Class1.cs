using System;
namespace CSharpBadPractices
{
    public class DiscountManager
    {
        public decimal ApplyDiscount(decimal price, AccountStatus accountStatus, int timeOfHavingAccountInYears)
        {
            decimal priceAfterDiscountApplied = 0;
            decimal discountForLoyaltyInPercentage = (timeOfHavingAccountInYears > 5) ? (decimal)5 / 100 : (decimal)timeOfHavingAccountInYears / 100;
            if (accountStatus == AccountStatus.NotRegistered)
            {
                priceAfterDiscountApplied = price;
            }
            else if (accountStatus == AccountStatus.SimpleCustomer)
            {
                priceAfterDiscountApplied = (price - (0.1m * price)) - discountForLoyaltyInPercentage * (price - (0.1m * price));
            }
            else if (accountStatus == AccountStatus.ValuableCustomer
            {
                priceAfterDiscountApplied = (0.7m * price) - discountForLoyaltyInPercentage * (0.7m * price);
            }
                     else if (accountStatus == AccountStatus.MostValuableCustomer)
            {
                priceAfterDiscountApplied = (price - (0.5m * price)) - discountForLoyaltyInPercentage * (price - (0.5m * price));
            }
            return priceAfterDiscountApplied;
        }
    }
}


