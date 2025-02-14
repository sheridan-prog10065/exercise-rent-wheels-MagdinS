namespace RentWheelsApp;

public partial class VehicleInventoryPage : ContentPage
{
	private SpeedyRentalShop _rentalShop;
	
	public VehicleInventoryPage(SpeedyRentalShop rentalShop)
	{
		//initialize the business logic service before any controls are created
		_rentalShop = rentalShop;
		
		InitializeComponent();
		
		//connect the collection view with the list of vehicles
		_lstVehicleInventory.ItemsSource = _rentalShop.Vehicles;
	}

	private void OnAddVehicle(object sender, EventArgs e)
	{
		//Read the vehicle properties
		string vehicleMake = _txtMake.Text;
		byte passCapacity = byte.Parse(_txtPassCapacity.Text);
		double mileage = double.Parse(_txtMileage.Text);
		string licensePlate = _txtLicensePlate.Text;

		//Create a vehicle object
		Vehicle newVehicle = new Vehicle(vehicleMake);
		
		//Set the vehicle properties to the user input
		newVehicle.PassengerCapacity = passCapacity;
		newVehicle.Mileage = mileage;
		newVehicle.LicensePlate = licensePlate;
		
		//Add the vehicle to the vehicle inventory of the rental shop
		_rentalShop.Vehicles.Add(newVehicle);
	}

	private void OnClear(object sender, EventArgs e)
	{
		//TODO: implement clearing the form
	}
}