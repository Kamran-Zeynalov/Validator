
namespace AccountValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? writeEmail = Console.ReadLine();
            try
            {
                bool result = EmailValidator.Validate(writeEmail);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}