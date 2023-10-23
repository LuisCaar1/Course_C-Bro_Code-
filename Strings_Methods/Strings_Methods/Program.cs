namespace Strings_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Luis Carrasco";
            String phoneNumber = "123-456-7890";


            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-","");
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0, "Mr.");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length); 

            String firstName = fullName.Substring(0, 4);
            String lastName = fullName.Substring(5, 8);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            

        }
    }
}