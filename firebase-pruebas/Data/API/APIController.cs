using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace firebase_pruebas.Data.API
{
    public class APIController
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "tR91FLbzKUIoulcdrBwVRLhe5oNdEKwu0Ft2zBrO",
            BasePath = "https://crud-firebase-67d8a-default-rtdb.firebaseio.com/"
        };

        public IFirebaseClient client;

        public APIController()
        {
            client = new FirebaseClient(config);
        }
    }
}
