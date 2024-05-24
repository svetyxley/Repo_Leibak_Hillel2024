namespace UserApp
{
    internal class UserController
    {
        public void InputUserName(InputController inputController, User user)
        {
            //Input First Name
            do
            {
                Console.Write("Enter First Name: ");
                user.FirstName = Console.ReadLine();
                if (!inputController.IsValidName(user.FirstName))
                {
                    Console.WriteLine("Invalid input. Please enter a valid first name.");
                    Console.WriteLine();
                }
            } while (!inputController.IsValidName(user.FirstName));


            //Input Last Name
            do
            {
                Console.Write("Enter Last Name: ");
                user.LastName = Console.ReadLine();
                if (!inputController.IsValidName(user.LastName))
                {
                    Console.WriteLine("Invalid input. Please enter a valid last name.");
                    Console.WriteLine();
                }
            } while (!inputController.IsValidName(user.LastName));
        }

        //Input Gender (5 attempts for invalide input)
        public void InputUserGender(User user)
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Enter gender (Male, Female, Unknown): ");
                try
                {
                    user.Gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), ignoreCase: true);
                    i = 4;
                }
                catch (ArgumentException)
                {
                    if (i < 4) //outpot ma
                    {
                        Console.WriteLine("Invalid input. Please enter a valid gender.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("You have used five attempts and entered incorrect data. Your Gender will be set up а default value: Unknown");
                    }
                }
            }
        }
    }
}
