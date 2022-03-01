// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person p1 = new Person();

p1.SetFirstName("Phillip");
p1.SetLastName("Stevenson");
p1.SetAge(31);

Student s1 = new Student();
s1.SetFirstName("Gilbert");
s1.SetLastName("McGee");
s1.SetAge(22);
s1.setStudentId("123abc");

s1.displayDetails();

s1.displayStudentInfo();
