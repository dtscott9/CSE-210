public class Student : Person
{
    private string _studentId;

    public string getStudentId()
    {
        return _studentId;
    }

    public void setStudentId(string id)
    {
        _studentId = id;
    }

    public void displayStudentInfo()
    {
        Console.WriteLine($"{_studentId} - {_lastName}, {_firstName}");
    }
}