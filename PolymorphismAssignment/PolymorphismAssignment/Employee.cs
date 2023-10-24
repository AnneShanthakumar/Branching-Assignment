using System;

// Define the Employee class which inherits from Person and implements IQuittable
public class Employee : IQuittable
{
    // Properties of the Employee class
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit.");
    }
}
