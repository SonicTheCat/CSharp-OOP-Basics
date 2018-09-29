using System;

class PriceCalculator
{
    private decimal pricePerNight;
    private int countOfNights;
    private SeasonMultiplier season;
    private DiscountType discount;

    public PriceCalculator(Func<string> readData)
    {
        var tokens = readData().Split();

        pricePerNight = decimal.Parse(tokens[0]);
        countOfNights = int.Parse(tokens[1]);
        season = Enum.Parse<SeasonMultiplier>(tokens[2]);
        discount = tokens.Length > 3 ?
            Enum.Parse<DiscountType>(tokens[3]) : DiscountType.None;
    }

    public decimal TotalPrice()
    {
        var total = (pricePerNight * countOfNights) * (int)season;
        var discountPercantage = ((decimal)100 - (int)discount) / 100;
        return total * discountPercantage;
    }
}