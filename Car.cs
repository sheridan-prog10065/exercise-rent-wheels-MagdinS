namespace RentWheelsApp;

public class Car : Vehicle //Car IS-A Vehicle
{
	private const decimal PRICE_PER_KM = 4.99m;
	private const double LUXARY_PREMIUM_FACTOR = 1.25;
	
	public Car(string make) : base(make)
	{
	}

	public  decimal CalculateRentalCost(Rental contract)
	{
		//the cost is calculated based on price per km and 
		//the luxary premium factor for luxary  models
		return 100m;
	}
}
