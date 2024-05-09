namespace UserApp
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public readonly int Age;
        Gender Gender { get; set; }

        //Конструктор без параметрів
        //В конструкторі дефолтні значення
        public User()
        {
            FirstName = "";
            LastName = "";
            Age = 0;
            Gender = Gender.Unknown;
        }

        // Конструктор, що задає вік
        public User(int age)
        {
            FirstName = "";
            LastName = "";
            Age = age;
            Gender = Gender.Unknown;
        }

        public void InputUserName(InputController inputController)
        {
            //Input First Name
            do
            {
                Console.Write("Enter First Name: ");
                FirstName = Console.ReadLine();
                if (!inputController.IsValidName(FirstName))
                {
                    Console.WriteLine("Invalid input. Please enter a valid first name.");
                    Console.WriteLine();
                }
            } while (!inputController.IsValidName(FirstName));


            //Input Last Name
            do
            {
                Console.Write("Enter Last Name: ");
                LastName = Console.ReadLine();
                if (!inputController.IsValidName(LastName))
                {
                    Console.WriteLine("Invalid input. Please enter a valid last name.");
                    Console.WriteLine();
                }
            } while (!inputController.IsValidName(LastName));
        }

        //Input Gender (5 attempts for invalide input)
        public void InputUserGender()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Enter gender (Male, Female, Unknown): ");
                try
                {
                    Gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), ignoreCase: true);
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

        public override string ToString()
        {
            if (Age < 10)
            {
                return "I am a baby.";
            }
            else
            {
                return $"Hi, my name is {FirstName} {LastName}. I am {Age} years old. I am {Gender}.";
            }
        }
    }
}

