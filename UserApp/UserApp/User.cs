namespace UserApp
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public readonly int Age;
        public Gender Gender { get; set; }

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

