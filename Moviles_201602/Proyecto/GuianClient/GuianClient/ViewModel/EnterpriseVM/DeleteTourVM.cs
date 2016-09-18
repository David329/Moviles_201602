using GuianClient.ServiceTour;
namespace GuianClient.ViewModel.EnterpriseVM
{
    public class DeleteTourVM
    {
        private ServiceTourClient ServiceTour;
        public void DeleteTour(int TourID)
        {
            ServiceTour = new ServiceTourClient();
            ServiceTour.deleteTour(ServiceTour.getTourByID(TourID));
        }
    }
}