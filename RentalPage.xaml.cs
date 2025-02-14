namespace RentWheelsApp;

public partial class RentalPage : ContentPage
{
    private SpeedyRentalShop _rentalShop;
    
    public RentalPage(SpeedyRentalShop rentalShop)
    {
        //initialize the business logic service before any controls are created
        _rentalShop = rentalShop;
        
        InitializeComponent();
        
        //link the vehicle inventory view with the list of vehicles
        _lstVehicleInventory.ItemsSource = _rentalShop.Vehicles;
        _lstRentals.ItemsSource = _rentalShop.Rentals; ;

    }

    private void OnCreateRentalAgreement(object sender, EventArgs e)
    {
        //read the data entered by the user
        DateTime startDate = _dtpStartDate.Date;
        DateTime endDate = _dtpEndDate.Date;
        Vehicle vehicle = _lstVehicleInventory.SelectedItem as Vehicle;
        
        //create a rental contract
        Rental rental = new Rental();
        rental.StartDate = startDate;
        rental.EndDate = endDate;
        rental.Vehicle = vehicle;
        
        //record the rental contract
        _rentalShop.Rentals.Add(rental);
    }
}
