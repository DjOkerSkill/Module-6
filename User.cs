using System;


namespace ConsoleApp4
{
    internal class User
    {
        private int age;
        private string login;
        private string mail;

        public int Age
        {
            get { return age; }
            set
            {
                if (age < 18) Console.WriteLine("your less 18 age");
                else age = value;
            }

        }
        public string Login
        {
            get { return login; }

            set 
            { 
                if (login.Length < 3 ) 
                    Console.WriteLine("логин должен быть длинной от 3 символов");

                else login = value; 
            }
        }
        public string Mail 
        {
            get { return Mail; }

            set
            {
                if (!mail.Contains("@"))
                    Console.WriteLine("Почта должна содержать символ @");

                else login = value;
            }
        }
    }
}
