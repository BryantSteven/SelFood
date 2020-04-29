using System;
using Xamarin.Forms;
using firebasesample.Services.FirebaseDB;
using SelFood.Services.Droid.Services.FirebaseDB;

[assembly: Dependency(typeof(FirebaseDBService))]
namespace SelFood.Services.Droid.Services.FirebaseDB
{
    public class FirebaseDBService : IFirebaseDBService
    {
        //FirebaseDatabase database;
        public void Connect()
        {
            //database = FirebaseDBService.GetInstance(MainActivity.app);
        }

        public void GetMessage()
        {
            //var userId = authService.GetUserId();
            //databaseReference = database.GetReference("messages/" + userId);
            //databaseReference.AddValueEventListener(new ValueEventListener());
        }

        public string GetMessageKey()
        {
            throw new NotImplementedException();
        }

        public void SetMessage(string message)
        {
            throw new NotImplementedException();
        }
        //public class ValueEventListener : Java.Lang.Object, IValueEventListener
        //{
        //    //public void OnCancelled(DatabaseError error) { }

        //    //public void OnDataChange(DataSnapshot snapshot)
        //    //{
        //    //    String message = snapshot.Value.ToString();
        //    //    MessagingCenter.Send(FirebaseDBService.KEY_MESSAGE, FirebaseDBService.KEY_MESSAGE, message);


        //    //}
        //}

    }
}
