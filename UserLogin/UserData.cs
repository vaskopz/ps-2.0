using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogin
{
    public static class UserData
    {
        private static List<User> _testUsers = new List<User>(3);

        public static List<User> testUsers
        {
            get {
              //  ResetTestUserData();
                return _testUsers; 
            }
            set { _testUsers = value; }
        }

        public static void ResetTestUserData()
        {
            User testUser = new User();
            
            testUser.username = "Vladimir";
            testUser.password = "password";
            testUser.facultyNumber = 121220043;
            testUser.role = 1;
            testUser.created = DateTime.Now;
            testUser.activeUntil = DateTime.MaxValue;
            _testUsers.Add(testUser);

            testUser = new User();
            testUser.username = "Ivan";
            testUser.password = "password";
            testUser.facultyNumber = 121220049;
            testUser.role = 4;
            testUser.created = DateTime.Now;
            testUser.activeUntil = DateTime.MaxValue;
            _testUsers.Add(testUser);

            testUser = new User();
            testUser.username = "Kalina";
            testUser.password = "password";
            testUser.facultyNumber = 121220126;
            testUser.role = 4;
            testUser.created = DateTime.Now;
            testUser.activeUntil = DateTime.MaxValue;
            _testUsers.Add(testUser);
        }

        public static User IsUserPassCorrect(String username, String password)
        {
            return (from user in _testUsers
                    where user.username.Equals(username)
                    && user.password.Equals(password)
                    select user).First();
/*            foreach (User user in _testUsers)
            {
                if (user.username.Equals(username) && user.password.Equals(password))
                {
                    return user;
                }
            }
            return null;*/
        }

        public static bool SetUserActiveUntil(String username, DateTime newActiveUntil)
        {
            foreach (User user in _testUsers)
            {
                if (user.username == username)
                {
                    user.activeUntil = newActiveUntil;
                    Logger.LogActivity(Activities.USER_ACTIVE_UNTIL_CHANGED);
                    return true;
                }
            }

            return false;
        }

        public static bool AssignUserRole(int userid, UserRoles newRole)
        {
            /*            foreach (User user in _testUsers)
                        {
                            if (user.username == username)
                            {
                                user.role = (int) newRole;
                                Logger.LogActivity(Activities.USER_ROLE_CHANGED);
                                return true;
                            }
                        }*

                        return false;*/

            UserContext context = new UserContext();

            User usr =
            (from u in UserData.testUsers
             where u.UserId == userid
             select u).First();
            usr.role = (int) newRole;
            context.SaveChanges();
            Logger.LogActivity(Activities.USER_ROLE_CHANGED);
            
            if (usr != null)
            {
                return true;
            }
            return false;
        }
    }
}
