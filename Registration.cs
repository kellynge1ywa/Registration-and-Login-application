using System;

namespace registrationsystem
{
    public class Action
    {
        public static void Registraton (string username , string password, int UserId , string path){
            Dictionary< string,string> user=new Dictionary<string, string>();
            user.Add("UserId", UserId.ToString());
            user.Add("Username",username);
            user.Add("Password",password);
            
            File.AppendAllText(path,UserId.ToString());
            File.AppendAllText(path,"\n");
            File.AppendAllText(path,username);
            File.AppendAllText(path,"\n");
            File.AppendAllText(path,password);
            File.AppendAllText(path,"\n");
        }
        public static Dictionary<string,object> Login(string username , string password , string path){

            string[] data = File.ReadAllLines(path);
           
            bool isMatch = false;
            bool isAdmin = false;
            for (int i = 0; i < data.Length; i++)
            { 
                isMatch = (data[1] == username && data[2] == password) ? true : false;
                isAdmin = (data[5] == username && data[6] == password) ? true : false;
            }

            Dictionary<string,object> user = new Dictionary<string,object>();
            user.Add("username",username);
            user.Add("isMatch",isMatch);
            user.Add("isAdmin",isAdmin);

            return user;   
        }
        public static void createPublicaton (int bookId , string name , string desc , string path){
            // Write to a file 


            File.WriteAllText(path,bookId.ToString());
            File.AppendAllText(path,"\n");
            File.AppendAllText(path,name);
            File.AppendAllText(path,"\n");
            File.AppendAllText(path,desc);


        }
        public static void bookPurchase(string bookId, string path, string userId){
            var book=File.ReadAllLines(path);
            for (int i = 0; i < book.Length; i++)
            {
                if(book[0] == bookId){
                    Console.WriteLine($"You have purchased a book");
                    string ordersPath = @"D:\Teach2Give\assignments\Account\Registrations\orders.txt";
                    // File.Create(ordersPath);
                    File.WriteAllText(ordersPath,"\t\t\t\tORDERS\t\t\t \n");
                    File.AppendAllText(ordersPath,userId);
                    File.AppendAllText(ordersPath,"\n");
                    File.AppendAllText(ordersPath,bookId);

                    return;
                    
                } else{
                    Console.WriteLine($"The book does not exist");
                    return;
                    
                }
            }


        }
        public static string readBookStore (string path){

            var books = File.ReadAllLines(path);

                Console.WriteLine("Book iD :   Book Title \n");
                Console.WriteLine($"{books[0]} :  {books[1]}");

                string bookId = Console.ReadLine();
                return bookId;

        }
        
    }
    
}
