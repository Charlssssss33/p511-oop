using System;


Internal class Student
{
	protected string Name { get; set; }
	protected string Surname { get; set; }
	protected string Sroup { get; set; }

	public Student(string name,string surname , string group)
	{
		Name = name;
		Surname = surname;
		Sroup = group;
	}
    public virtual void Print()
    {
		Console.WriteLine("Student:");
		Console.writeLine($"Name: {Name}");
		Console.WiteLine($"Surname: {surname}");
	}
	
	
		

	
}
