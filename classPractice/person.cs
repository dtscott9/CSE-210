public class Person
{
    protected string _firstName;
    protected string _lastName;

    protected int _age;

    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetFirstName(string firstName)
    {
        
        _firstName = firstName;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }

    public int GetAge()
    {
        return _age;
    }

    public void SetAge(int age)
    {
        _age = age;
    }

    public void DisplayName()
    {
        Console.WriteLine($"{_firstName} {_lastName}");
    }

    public void displayDetails()
    {
        Console.WriteLine($"{_firstName} {_lastName} -- Age: {GetAge()}");
    }

}