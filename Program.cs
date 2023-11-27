using Account;

Registration user1= new Registration();
// user1.Register();
var loginStatus = false;


do{    
     var dataDictionary = user1.Login();
     loginStatus = (bool) dataDictionary["isMatch"];
    
     if(loginStatus){
        string username = (string)dataDictionary["username"];
        // Console.WriteLine(username);
       Console.WriteLine($"Welcome {username}");
       break;

 }else{
    loginStatus = (bool)dataDictionary["isMatch"];
    if(loginStatus){
       string username = (string)dataDictionary["username"];
       Console.WriteLine($"Welcome {username}");
       break;
    } 
 }


} while(!loginStatus);



