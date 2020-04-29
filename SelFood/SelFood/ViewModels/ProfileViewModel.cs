using firebasesample.Services.FirebaseDB;
using System;
using Xamarin.Forms;

namespace SelFood.ViewModels
{
    class ProfileViewModel
    {
        private IFirebaseDBService _firebaseDatabaseService;

        public ProfileViewModel() {
            _firebaseDatabaseService = DependencyService.Get<IFirebaseDBService>();
            _firebaseDatabaseService.Connect();
            _firebaseDatabaseService.GetMessage();
            MessagingCenter.Subscribe<String, String>(this, _firebaseDatabaseService.GetMessageKey(), (sender, args) =>
            {
                var message = (args);

            });
        }
    }
}
