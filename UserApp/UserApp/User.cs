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
        public User() {
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
                }
            } while (!inputController.IsValidName(LastName));
        }

            //Input Gender
            public void InputUserGender()
            {
                do
                {
                    Console.Write("Enter gender (Male, Female, Unknown): ");
                    try
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), ignoreCase: true);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid gender.");
                        InputUserGender();
                    }
                } while (!Gender.IsDefined(typeof(Gender), Gender));
            }
        
        public override string ToString()
        {
            string ageInfo = (Age < 10) ? "I am just a kid!" : $"I am {Age} years old.";
            return $"Hi, my name is {FirstName} {LastName}. I am {Age} years old. I am {Gender}.";
        }
    }
}

