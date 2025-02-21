namespace RentWheelsApp;

public class Van: Vehicle // Van IS-A Vehicle
{
	private const decimal PRICE_PER_DAY = 23.99m;
	private const double LARGE_PREMIUM_FACTOR = 1.3;

	public Van(string make) : base(make)
	{
	}
	
	public decimal CalculateRentalCost(Rental contract)
	{
		return 400m;
	}	

}
