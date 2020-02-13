using System.Collections.Generic;
using localforsure_rest_api.daos;
using localforsure_rest_api.models;

namespace localforsure_rest_api.services
{
    public class UserService
    {
        private UserDao _userDao;
        
        public UserService()
        {
            _userDao = new UserDao();
        }

        public List<User> GetAllUsers()
        {
            return _userDao.GetAllUsers();
        }
    }
}