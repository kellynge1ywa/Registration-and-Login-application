using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account
{
    public class Registration
    {
        public void Register(){
            var pathName=@"D:\Teach2Give\assignments\Account\Registrations";
            Directory.CreateDirectory(pathName);

            var filePath= @"D:\Teach2Give\assignments\Account\Registrations\data1.txt";
            //  File.Create(filePath);
            Console.WriteLine("Enter username: ");
            string Username=Console.ReadLine();
            File.WriteAllText(filePath,Username);
            File.AppendAllText(filePath,"\n");
            Console.WriteLine("Enter password: ");
            string Password=Console.ReadLine();
            File.AppendAllText(filePath,Password);




            // Console.WriteLine($"Username:{Username}");
            // Console.WriteLine($"Password: {Password}");

            
           
            
        }

        public Dictionary<string,object> Login(){
            var filePath= @"D:\Teach2Give\assignments\Account\Registrations\data1.txt";
        
            bool isMatch = false;
            string[] data=File.ReadAllLines(filePath);

            Console.WriteLine("Enter username: ");
            string Username=Console.ReadLine();
            
            
            Console.WriteLine("Enter password: ");
            string Password=Console.ReadLine();
            

            for (int i = 0; i < data.Length; i++)
            {
                bool isUserNameMatch = Username.Equals(data[0]);
                bool isUserPassMatch = Password.Equals(data[1]);
                // Console.WriteLine(isUserNameMatch);
                // Console.WriteLine(isUserPassMatch);

              isMatch =  (isUserNameMatch && isUserPassMatch) ? true : false;
            
            }
            Dictionary<string,object> user = new Dictionary<string, object>();
            user.Add("isMatch",isMatch);
            user.Add("username",Username);


            return user;
    

        }

        
    }
}