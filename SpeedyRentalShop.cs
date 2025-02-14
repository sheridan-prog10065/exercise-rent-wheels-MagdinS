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

		InitializeDefaultVehicles();
	}

	private void InitializeDefaultVehicles()
	{
		Vehicle vehicle1 = new Vehicle("Honda");
		vehicle1.LicensePlate = "ABC 1234";
		vehicle1.Mileage = 1055;
		vehicle1.PassengerCapacity = 5;
		_vehicleCollection.Add(vehicle1);
		
		Vehicle vehicle2 = new Vehicle("Toyota");
		vehicle2.LicensePlate = "XYZ 584";
		vehicle2.Mileage = 755;
		vehicle2.PassengerCapacity = 5;
		_vehicleCollection.Add(vehicle2);
		
		Vehicle vehicle3 = new Vehicle("Chevy");
		vehicle3.LicensePlate = "RTS 204";
		vehicle3.Mileage = 75607;
		vehicle3.PassengerCapacity = 5;
		_vehicleCollection.Add(vehicle3);
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