namespace RentWheelsLib;

/// <summary>
/// Custom exception handling for invalid vehicle operations
/// </summary>
public class InvalidVehicleException : Exception
{
	public InvalidVehicleException(string message) : base(message)
	{
	}

}

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
		set
		{
			//valid the new make
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new InvalidVehicleException("Cannot set the vehicle make. Value is invalid");
			}

			_make = value;
		}
	}

	public double Mileage
	{
		get { return _mileage; }
		set
		{
			double newMileage = value;
			if (newMileage < _mileage)
			{
				throw new InvalidVehicleException("The new mileage must be greater than the current mileage. The new mileage was not set");
			}

			_mileage = value;
		}
	}

	public byte PassengerCapacity
	{
		get { return _passengerCapacity; }
		set
		{
			int newPassengerCapacity = value;

			if (newPassengerCapacity < 2 || newPassengerCapacity > 10)
			{
				throw new InvalidVehicleException(
					"Invalid passenger capacity. The passenger capacity must be between 2 and 10");
			}

			_passengerCapacity = value;
		}
	}

	public string LicensePlate
	{
		get { return _licensePlate; }
		set
		{
			string newLicensePlate = value;

			if (newLicensePlate.Length < 2 || newLicensePlate.Length > 8)
			{
				throw new InvalidVehicleException(
					"Invalid license plate number. A license plate must have 6 characters");
			}

			_licensePlate = value;
		}
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