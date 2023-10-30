using System.ComponentModel.DataAnnotations;

namespace _22_DataAnotation
{
    [Serializable]
    public class User
    {
        [Required(ErrorMessage ="Id not defined")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name not set")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Erroe lenght")]
        public string Name { get; set ; }//""
        [Required(ErrorMessage = "Age not set")]
        [Range(1,120,ErrorMessage ="Age error")]
        public int Age { get; set; }//1......100
        [EmailAddress]
        public string Email { get; set; }//"slkdghs@gmail.com"
        [Phone]
        public string Phone { get; set; }//"+__ ___ ___ "
        [Required]
        public string Login { get; set; }//"kdgkdsjhgksd"
        [Required]
        public string Password { get; set; }//
        [Required]
        [Compare(nameof(Password), ErrorMessage ="Password not confirm")]
        public string ConfirmPassword { get; set; }// = password
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            bool isValid = true;
            do
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter age");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Login");
                string login = Console.ReadLine();

                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                Console.WriteLine("Confirm password");
                string confirmPassword = Console.ReadLine();

                Console.WriteLine("Enter email");
                string email = Console.ReadLine();

                Console.WriteLine("Enter phone");
                string phone = Console.ReadLine();

               
                user.Id = 1;
                user.Name = name;
                user.Age = age;
                user.Password = password;
                user.ConfirmPassword = confirmPassword;
                user.Email = email;
                user.Phone = phone;
                user.Login = login;


         

                var result = new List<ValidationResult>();
                var context = new ValidationContext(user);
                if (!(isValid = Validator.TryValidateObject(user, context, result, true)))
                {
                    foreach (ValidationResult error in result)
                    {
                        Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                    }
                }


            } while (!isValid);

            Console.WriteLine("Model is valid");
        }
    }
}