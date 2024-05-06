using UserApp;

var inputController = new InputController();
var user1 = new User(10);

//Input  user's data
user1.InputUserName(inputController);
user1.InputUserGender();
//Output  user's data
Console.WriteLine(user1);