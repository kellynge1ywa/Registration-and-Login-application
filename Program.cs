namespace registrationsystem;

class Program
{
    static void Main(string[] args)
    {
        // Directory.CreateDirectory(@"D:\Teach2Give\assignments\Account\Registrations");
        // File.Create(@"D:\Teach2Give\assignments\Account\Registrations\data1.txt");
        // string path = @"D:\Teach2Give\assignments\Account\Registrations\data1.txt";
        // Console.WriteLine("Welcome to the registration system \n");
        // Console.WriteLine("Enter Your Username");
        // string username = Console.ReadLine();
        // Console.WriteLine("Enter Your Password");
        // string password = Console.ReadLine();
        // // Register the User
        // Action.Registraton(username,password,path);

        // Login the user 
        bool loginStatus = false;
        do {
         string path = @"D:\Teach2Give\assignments\Account\Registrations\data1.txt";
         Console.WriteLine("Enter Your Username");
         string username = Console.ReadLine();
         Console.WriteLine("Enter Your Password");
         string password = Console.ReadLine();

         var dataDictionary = Action.Login(username,password,path);

         loginStatus = (bool)dataDictionary["isMatch"];

         if(loginStatus){
                Console.WriteLine($"Welcome:{dataDictionary["username"]}");
                break;
         } else{
                Console.WriteLine("Invalid Username or Password");
         }
            

        }while(!loginStatus);


    }
}
