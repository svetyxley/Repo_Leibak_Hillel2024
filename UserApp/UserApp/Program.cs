using UserApp;

var inputController = new InputController(); 
var usercontroller = new UserController();
var user1 = new User(10);

//Input  user's data
usercontroller.InputUserName(inputController, user1);
usercontroller.InputUserGender(user1);
//Output  user's data
Console.WriteLine();
Console.WriteLine(user1);