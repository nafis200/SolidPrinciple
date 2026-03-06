<!-- kiss complicated -->

<!-- keep it simple stupid -->

public class priceCalculator
{
    public double Price { get; set; }

    public double DiscountPercentage { get; set; }

    public double Taxpercentage { get; set; }

    public double Calculate()
    {
        double discount = Price * DiscountPercentage / 100;
        
        double tax = Price * Taxpercentage / 100;

        return Price - discount * tax;
    }
}


<!-- now kiss it -->

<!-- break calculate function -->

public class priceCalculator
{
    public double Price { get; set; }

    public double DiscountPercentage { get; set; }

    public double Taxpercentage { get; set; }

    public double CalculateDiscount()
    {
        double discount = Price * DiscountPercentage / 100;
        return discount;
    }

    public double CalculateTax()
    {
         double tax = Price * Taxpercentage / 100;
         return tax;
    }



    public double Calculate()
    {
        
        double discount = CalculateDiscount();

        double tax = CalculateTax();

        return Price - discount * tax;
    }
}
