using System;

Internal class Aspirant : Student 
{
	private  string Work {  get; set; }

	public Aspirant(string name,string surname , string group, string work) : base(name,surname,group)
	{
		Work = work;
	}
	public override void Print()
	{
		base.Print();
	}
}
