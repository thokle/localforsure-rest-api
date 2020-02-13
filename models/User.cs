namespace localforsure_rest_api.models
{
    public class User
    {
        
        private long _id;
        private string _firstname;
        private string _lastname;
        private string _username;
        private string _password;
        private long _lattiude;
        private long longitude;
        private int zipcode;
        
        public long Id
        {
            get => _id;
            set => _id = value;
        }

        public string Firstname
        {
            get => _firstname;
            set => _firstname = value;
        }

        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }

        public string Username
        {
            get => _username;
            set => _username = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public long Lattiude
        {
            get => _lattiude;
            set => _lattiude = value;
        }

        public long Longitude
        {
            get => longitude;
            set => longitude = value;
        }

        public int Zipcode
        {
            get => zipcode;
            set => zipcode = value;
        }

       
        
       }
}