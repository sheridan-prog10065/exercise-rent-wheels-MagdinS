namespace RentWheelsApp;

public class Car : Vehicle //Car IS-A Vehicle
{
	private const decimal PRICE_PER_DAY = 4.99m;
	private const double LUXARY_PREMIUM_FACTOR = 1.25;
	
	public Car(string make) : base(make)
	{
	}

	public override decimal CalculateRentalCost(Rental contract)
	{
		//the cost is calculated based on price per day and 
		//the luxary premium factor for luxary  models: Ferrari and Lamborghini
		if (_make == "Ferrari" || _make == "Lamborghini")
		{
			//rental is for luxary car, apply a premium
			return PRICE_PER_DAY * contract.Duration.Days * (decimal)LUXARY_PREMIUM_FACTOR;
		}
		else
		{
			//regular car
			return PRICE_PER_DAY * contract.Duration.Days;
		}
		
	}
}
