namespace RentWheelsApp;

public class Vehicle
{
	#region Field Variables

	protected string _make;
	protected double _mileage;
	protected byte _passengerCapacity;
	protected string _licensePlate;

	private const decimal DEFAULT_PRICE_PER_DAY = 67;
	#endregion
	
	#region Constructors

	public Vehicle(string make)
	{
		_make = make;
		_mileage = 0;
		_passengerCapacity = 0;
		_licensePlate = "N/A";
	}
	
	#endregion
	
	#region Properties

	public string Make
	{
		get { return _make; }
		set { _make = value; }
	}

	public double Mileage
	{
		get { return _mileage; }
		set { _mileage = value; }
	}

	public byte PassengerCapacity
	{
		get { return _passengerCapacity; }
		set { _passengerCapacity = value; }
	}

	public string LicensePlate
	{
		get { return _licensePlate; }
		set { _licensePlate = value; }
	}

	#endregion
	
	#region Methods

	public override string ToString()
	{
		return $"{_make}: {_licensePlate} with {_mileage} km and {_passengerCapacity} passengers.";
	}

	public virtual decimal CalculateRentalCost(Rental contract)
	{
		return DEFAULT_PRICE_PER_DAY * contract.Duration.Days;
	}
	
	#endregion
}