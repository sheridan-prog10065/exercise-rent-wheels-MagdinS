using System.Collections.ObjectModel;

namespace RentWheelsLib;

public class SpeedyRentalShop
{
	private ObservableCollection<Rental> _rentalCollection;
	private ObservableCollection<Vehicle> _vehicleCollection;
	
	public SpeedyRentalShop()
	{
		_rentalCollection = new ObservableCollection<Rental>();
		_vehicleCollection = new ObservableCollection<Vehicle>();
		
		//load default vehicles
		CreateDefaultVehicles();
	}

	private void CreateDefaultVehicles()
	{
		//create first vehicle and add it to the list
		Vehicle vehicle1 = new Car("Honda");
		vehicle1.Mileage = 10000;
		vehicle1.LicensePlate = "ABD 3456";
		vehicle1.PassengerCapacity = 5;
		_vehicleCollection.Add(vehicle1);

		//create second vehicle and add it to the list
		Vehicle vehicle2 = new Truck("Toyota");
		vehicle2.Mileage = 900;
		vehicle2.LicensePlate = "FGH 1204";
		vehicle2.PassengerCapacity = 7;
		_vehicleCollection.Add(vehicle2);		

		//create third vehicle and add it to the list
		Vehicle vehicle3 = new Van("Chevy");
		vehicle3.Mileage = 75000;
		vehicle3.LicensePlate = "XYZ 3688";
		vehicle3.PassengerCapacity = 6;
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

	public void RentVehicle(Rental rental)
	{
		//Step 1: Validate the input
		if (rental.Vehicle == null)
		{
			//TODO: throw InvalidRentalAgreement
		}

		if (rental.EndDate <= rental.StartDate)
		{
			//TODO: throw InvalidRentalAgreement
		}

		//Step 2: Use the Input
		_rentalCollection.Add(rental);
	}
}