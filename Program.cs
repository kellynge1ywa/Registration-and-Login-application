namespace registrationsystem;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Choose option 1 to Register 2 to Login \n");
        string option = Console.ReadLine();
        int UserId = 1;
        if(option == "1"){
        // Directory.CreateDirectory(@"D:\Teach2Give\assignments\Account\Registrations");
        // File.Create(@"D:\Teach2Give\assignments\Account\Registrations\data1.txt");
        string path = @"D:\Teach2Give\assignments\Account\Registrations\data1.txt";
        Console.WriteLine("Welcome to the registration system \n");
        Console.WriteLine("Enter Your Username");
        string username = Console.ReadLine();
        Console.WriteLine("Enter Your Password");
        string password = Console.ReadLine();

        // Register the User
        Action.Registraton(username,password,UserId,path);
        UserId ++;

        }else if(option == "2"){
         Dictionary<string , string> admin = new Dictionary<string, string>(){
            {"username","admin"},
            {"password","1234"}
         };
        Console.WriteLine("Welcome to the Login system \n");
        // Login the user 
        bool loginStatusUser = false;
        bool loginStatusAdmin = false;
        do {
         string path = @"D:\Teach2Give\assignments\Account\Registrations\data1.txt";

         Console.WriteLine("Enter Your Username");
         string username = Console.ReadLine();
         Console.WriteLine("Enter Your Password");
         string password = Console.ReadLine();

         var dataDictionary = Action.Login(username,password,path);

         loginStatusUser = (bool)dataDictionary["isMatch"];
         loginStatusAdmin = (bool)dataDictionary["isAdmin"];
         string bookPath = @"D:\Teach2Give\assignments\Account\Registrations\book.txt";

         if(loginStatusUser){
                Console.WriteLine($"Welcome:{dataDictionary["username"]}");
                Console.WriteLine("BOOKS IN STORE \n\n");
                Console.WriteLine("Choose a book based  on the book ID");
                string bookId = Action.readBookStore(bookPath);

                // purchase the book

                Action.bookPurchase(bookId , bookPath , (string)dataDictionary["username"]);
                break;
         } else{
         if(loginStatusAdmin){
               // File.Create(bookPath);

               Action.createPublicaton(1,"introduction","introduction to c#", bookPath);

            // add a new book and save it in book.txt 
                Console.WriteLine($"Welcome:mR.ADMIN");
                break;
         }else{

                Console.WriteLine("Invalid Username or Password");
         }
         }

        }while(!loginStatusUser || !loginStatusAdmin );


        }else{
            Console.WriteLine("Invalid Option");
        }
    }
}
