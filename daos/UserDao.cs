using System.Collections.Generic;
using localforsure_rest_api.models;

namespace localforsure_rest_api.daos
{
    public class UserDao
    {
        public User CreateUser(User user)
        {
            return user;
        }

        public List<User> GetAllUsers()
        {
            
            return  new List<User>(){ new User()
                {
                    Firstname = "Thonas",
                    Lastname = "Kleist",
                    Username = "thokle",
                    Password = "342434423",
                    Zipcode = 2060,
                    Lattiude = 23234234234234,
                    Longitude = 234234234234234,
                    Id = 1
                },
            
                new User()
                {
                    Firstname = "Louise",
                    Lastname = "Kleist",
                    Username = "thokle",
                    Password = "342434423",
                    Zipcode = 2060,
                    Lattiude = 23234234234234,
                    Longitude = 234234234234234,
                    Id = 1
                }};
            
            
        }
    }
}