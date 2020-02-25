using  data_soruce_mil.daos;
using data_soruce_mil.services;
namespace localforsure_rest_api.factory
{
    public class Factory
    {

        private static UserService _userService;
        private static  TestPurhaseIntentionService _intentionService;
        public static UserService GetUserService()
        {
            if (_userService == null)
            {
                UserDao  userDao = new UserDao();
                _userService = new UserService(userDao);
            }


            return _userService;
        }

        public static TestPurhaseIntentionService GetTestPurhaseIntentionService()
        {
            if (_intentionService == null)
            {
                TestPurchaseIntentiomDao intentiomDao = new TestPurchaseIntentiomDao();
            _intentionService = new TestPurhaseIntentionService(intentiomDao);
            }

            return _intentionService;

        }
    }
}