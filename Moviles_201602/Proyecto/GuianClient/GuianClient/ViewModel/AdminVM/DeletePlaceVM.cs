using GuianClient.ServicePlace;
namespace GuianClient.ViewModel.AdminVM
{
    public class DeletePlaceVM
    {
        private ServicePlaceClient ServicePlace;
        public void DeletePlace(int PlaceID)
        {
            ServicePlace = new ServicePlaceClient();
            ServicePlace.deletePlace(ServicePlace.getPlaceByID(PlaceID));
        }
    }
}