namespace Exercise3_2_Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserError> UserErrors = new List<UserError>();

            UserErrors.Add(new NumericInputError());
            UserErrors.Add(new TextInputError());
            UserErrors.Add(new NumericInputError());
            UserErrors.Add(new NumericInputError());
            UserErrors.Add(new TextInputError());
            UserErrors.Add(new TextInputError());

            foreach (var error in UserErrors) 
            {
                error.UEMessage();
            }

            Console.ReadLine();

        }
    }
}
