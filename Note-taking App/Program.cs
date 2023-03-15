// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
namespace myApplication{
    class Login{
        public string LoginPassword{
            get;set;
        }
        public string LoginUsername{
            get;set;
        }
        
    }
    class Program:Login{

        static void Main(string[] args){
            Console.WriteLine("Hello, Please enter your login credentials");
            Console.Write("username: ");
            string userName = Console.ReadLine();
            Console.Write("password: ");
            string passWord = Console.ReadLine();
            Console.Write("User is "+userName+" with password "+passWord+"\n");
            Login loginCredentials = new Login();
            loginCredentials.LoginUsername = "Jen";
            loginCredentials.LoginPassword = "123";
            string loginuserName = loginCredentials.LoginUsername;
            string loginuserPassword = loginCredentials.LoginPassword;
            // Console.WriteLine(loginuserName==null);
            if (userName == loginuserName && passWord == loginuserPassword){
                Console.WriteLine("Credentials are correct!");
            }else{
                Console.WriteLine("username or password is incorrect!");
            }
            Console.WriteLine("Do you want to change password? ");
            string answer = Console.ReadLine();
            if (answer == "y"){
                Console.WriteLine("Enter old password: ");
                string oldpassWord = Console.ReadLine();
                if (oldpassWord == loginuserPassword){
                    Console.WriteLine("Enter new Password: ");
                    string newpassWord = Console.ReadLine();
                    loginCredentials.LoginPassword = newpassWord;
                    Console.WriteLine("Password is updated!");
                }else{
                    Console.WriteLine("Old password is wrong.");
                }
                loginuserPassword = loginCredentials.LoginPassword;
                Console.WriteLine("Current password: "+loginuserPassword);
            }
            

        }
    }
}

