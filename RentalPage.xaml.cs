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
        _lstRentals.ItemsSource = _rentalShop.Rentals;

    }

    private async void OnCreateRental(object sender, EventArgs e)
    {
        try
        {
            //Read the contract input information the user has entered
            DateTime startDate = _dtpStartDate.Date;
            DateTime endDate = _dtpEndDate.Date;
            Vehicle selectedVehicle = (Vehicle)_lstVehicleInventory.SelectedItem;

            //Create a rental contract structure
            Rental rental = new Rental(selectedVehicle, startDate, endDate);

            //Add the contract to the list of contracts in the rental shop
            _rentalShop.Rentals.Add(rental);
        }
        catch (ArgumentNullException ex)
        {
            await DisplayAlert("Error", "Please select rental dates and desired vehicle.", "I guess...");
        }
    }
}
