using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROYECT_2._0
{
    public class AuthenticationAndAuthorization : User
    {
        List<User> UsersList = new List<User>();
        public void SecurityLoging()
        {
            int stopCount = 0;
            while (stopCount != 1)
            {
                Console.WriteLine("[1 - Login] [2 - Sign Up] [3 - EXIT]");
                string LoginOrSign = Console.ReadLine();

                switch (LoginOrSign)
                {
                    case "1":
                        Login();
                        break;

                    case "2":
                        SignUp();
                        break;

                    case "3":
                        stopCount = 1;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        public void Login()
        {
            foreach (User user in UsersList)
            {
                if (UsersList.Count > 0 && user.Access == true)
                {
                    Console.WriteLine("Email: ");
                    string Email = Console.ReadLine().ToLower();
                    Console.WriteLine("Password: ");
                    int Password = int.Parse(Console.ReadLine());

                    LoginProcess(Email, Password, user);
                }
                else
                {
                    Console.WriteLine("--------------------------------------------------\n" +
                                      "Sorry, You havent a user, please, create your User\n" +
                                      "---------------------------------------------------");
                }
            }
        }

        public void LoginProcess(string Email, int Password, User user)
        {
            if (Email == user.Email && Password == user.Password)
            {
                Console.WriteLine("You have access to the Menu");
                Menu();

            }
            else if (Email != user.Email && Password != user.Password)
            {
                Console.WriteLine("The Password and The Email is not correct");
            }
            else if (Email != user.Email && Password == user.Password)
            {
                Console.WriteLine("The Email is not correct");
            }
            else if (Email == user.Email && Password != user.Password)
            {
                Console.WriteLine("The Password is not correct");
            }

        }

        public void SignUp()
        {
            Console.WriteLine("Name: ");
            string Name = Console.ReadLine().ToLower();
            Console.WriteLine("Email: ");
            string Email = Console.ReadLine().ToLower();
            Console.WriteLine("Password (Only Numbers): ");
            var Password = int.Parse(Console.ReadLine());

            User NewUser = new()
            {
                name = Name,
                Email = Email,
                Password = Password,
                Access = true
            };

            UsersList.Add(NewUser);

            Console.WriteLine($"-------------------------------------------------\n" +
                              $"The User {NewUser.name} Have been created \n" +
                              $"-------------------------------------------------\n" +
                              $"Email: {NewUser.Email} \nPassword: {NewUser.Password} " +
                              $"\nAccess: {NewUser.Access}" +
                              $"\n-------------------------------------------------");
        }

    }
}
