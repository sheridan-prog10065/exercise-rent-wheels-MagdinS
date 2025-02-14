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

    }
}
