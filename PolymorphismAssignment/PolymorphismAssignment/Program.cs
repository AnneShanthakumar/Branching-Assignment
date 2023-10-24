class Program
{
    static void Main()
    {
        // Create an object of type IQuittable using polymorphism
        IQuittable quittableEmployee = new Employee
        {
            FirstName = "John",
            LastName = "Doe"
        };

        // Call the Quit() method on the IQuittable object
        quittableEmployee.Quit();
    }
}
