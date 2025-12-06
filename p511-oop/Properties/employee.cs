using System;


internal class Employee
{
	private string surname {  get; set; }
    private string name { get; set; }
	private string surname2 { get; set; }
	private string date {  get; set; }
	private string number { get; set; }
	private string email { get; set; }
	private string jobtitle { get; set; }
	private string responsibilities { get; set; }


	public void Emploe()
	{
		Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Отчество: {surname2}, Дата рождения: {date}, Адрес эл.почты: {email}, Должность: {jobtitle}, Обязанности: {responsibilities}");
	} 

	public Employee(string surname, string name , string surname2 , string date , string number , string email , string jobtitle , string responsibilities)
	{
		this.surname = surname;
		this.name = name;
		this.surname2 = surname2;
		this.date = date;
		this.number = number;
		this.email = email;
		this.jobtitle = jobtitle;
		this.responsibilities = responsibilities;

	}
}
