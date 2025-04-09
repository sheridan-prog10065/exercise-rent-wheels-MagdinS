namespace RentWheelsLib;

public class Truck : Vehicle //Truck IS-A Vehicle
{
	private const decimal PRICE_PER_DAY = 29.99M;

	public Truck(string make) : base(make)
	{
		
	}

	public override decimal CalculateRentalCost(Rental contract)
	{
		//the cost is calculated based on price per day
		return PRICE_PER_DAY * contract.Duration.Days;
	}

}
