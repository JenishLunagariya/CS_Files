// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
namespace myApplication{
    class Login{
        // string loginpass = File.ReadAllText("password.txt");
        public string LoginPassword{
            get;set;
        }
        public string LoginUsername{
            get;set;
        }

        public Login(){
            string writeuserName = "Jenish";
            if (File.ReadAllText("password.txt") == ""){
                string writepassWord = "12345678";
                File.WriteAllText("password.txt",writepassWord);
            }
             
            File.WriteAllText("username.txt",writeuserName);
            this.LoginPassword = File.ReadAllText("password.txt");
            this.LoginUsername = File.ReadAllText("username.txt");
            File.Encrypt("username.txt");
            File.Encrypt("password.txt");
        }
        public void setLoginPassword(string password){
            File.WriteAllText("password.txt",password);
        }
        public string getLoginPassword(){
            LoginPassword = File.ReadAllText("password.txt");
            return LoginPassword;
        }   
        public void decryptFile(){
            File.Decrypt("username.txt");
            File.Decrypt("password.txt");
        }
    }
    class Program:Login{

        static void Main(string[] args){
            Console.WriteLine("Hello, Please enter your login credentials");
            Login loginCredentials = new Login();
           
            Console.Write("username: ");
            string userName = Console.ReadLine();
            Console.Write("password: ");
            string passWord = Console.ReadLine();
            string loginuserName = loginCredentials.LoginUsername;
            string loginuserPassword = loginCredentials.LoginPassword;

            // check login credentials;
            if (userName == loginuserName && passWord == loginuserPassword){
                Console.WriteLine("Credentials are correct!");

                Console.WriteLine("Do you want to change password? ");
                string answer = Console.ReadLine();
                if (answer == "y"){
                Console.WriteLine("Enter old password: ");
                string oldpassWord = Console.ReadLine();
                if (oldpassWord == loginuserPassword){
                    Console.WriteLine("Enter new Password: ");
                    string newpassWord = Console.ReadLine();
                    loginCredentials.setLoginPassword(newpassWord);
                    // loginCredentials.LoginPassword = newpassWord;
                    Console.WriteLine("Password is updated!");
                }else{
                    Console.WriteLine("Old password is wrong.");
                }
                loginuserPassword = loginCredentials.getLoginPassword();
                Console.WriteLine("Current password: "+loginuserPassword);
                
            }
            }else{
                Console.WriteLine("username or password is incorrect!");
            }
        }
    }
}

