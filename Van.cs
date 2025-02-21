namespace RentWheelsApp;

public class Van: Vehicle // Van IS-A Vehicle
{
	private const decimal PRICE_PER_DAY = 23.99m;
	private const double LARGE_PREMIUM_FACTOR = 1.3;

	public Van(string make) : base(make)
	{
	}
	
	public override decimal CalculateRentalCost(Rental contract)
	{
		//Vans have a large premimum factor. Check the number of a passengers (greater than 6)
		if (_passengerCapacity > 6)
		{
			//large van; apply a premium factor
			return PRICE_PER_DAY * contract.Duration.Days * (decimal)LARGE_PREMIUM_FACTOR;
		}
		
		//van with regular capacity
		return PRICE_PER_DAY * contract.Duration.Days;
	}	

}
