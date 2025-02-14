using System.Collections.ObjectModel;

namespace RentWheelsApp;

public class SpeedyRentalShop
{
	private ObservableCollection<Rental> _rentalCollection;
	private ObservableCollection<Vehicle> _vehicleCollection;
	
	public SpeedyRentalShop()
	{
		_rentalCollection = new ObservableCollection<Rental>();
		_vehicleCollection = new ObservableCollection<Vehicle>();
	}

	public ObservableCollection<Rental> Rentals
	{
		get
		{
			return _rentalCollection;
		}
	}

	public ObservableCollection<Vehicle> Vehicles
	{
		get
		{
			return _vehicleCollection;
		}
	}
}