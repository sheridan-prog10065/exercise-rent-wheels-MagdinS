namespace RentWheelsApp;

public struct Rental
{
	#region Field Variables
	
	private DateTime _startDate;
	private DateTime _endDate;
	private Vehicle _vehicle;
	
	#endregion
	
	#region Constructors

	public Rental(Vehicle vehicle, DateTime startDate, DateTime endDate)
	{
		_vehicle = vehicle;
		_startDate = startDate;
		_endDate = endDate;
	}

	#endregion

	#region Properties

	public Vehicle Vehicle
	{
		get { return _vehicle; }
	}

	public DateTime StartDate
	{
		get { return _startDate; }
		set { _startDate = value; }
	}

	public DateTime EndDate
	{
		get { return _endDate; }
		set { _endDate = value; }
	}

	public TimeSpan Duration
	{
		get { return EndDate - StartDate; }
	}

	#endregion
}