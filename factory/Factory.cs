using  data_soruce_mil.daos;
using data_soruce_mil.services;
namespace localforsure_rest_api.factory
{
    public class Factory
    {

        public static UserService GetUserService()
        {
            UserDao  userDao = new UserDao();
            return  new UserService(userDao);
        }
    }
}