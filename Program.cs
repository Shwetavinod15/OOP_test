namespace OOP_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person student = new Person ();
            Console.WriteLine(student.getName());

            Person student1 = new Person { FirstName = "Sameer", LastName = "Enjapuri" };
            Console.WriteLine(student.getName());

            Person student2 = new Person();
            Console.WriteLine(student1.salutation + " " + student2.getName());

            Person student3 = new Person ("Sameer", "Enjapuri", "");
            Console.WriteLine(student3.salutation + " " + student3.FirstName+ " "+student3.LastName);

            Person student4 = new Person { FirstName = "Sameer", LastName = "Enjapuri", salutation = "Mr" };
            Console.WriteLine(student4.getName());



        }
    }
}
