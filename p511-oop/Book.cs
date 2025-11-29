using System;



Inetrnal class Book
{ private string author {  get; set; }
  private string name { get; set; }
  private string pages { get; set; }
  private string publishing	{ get; set; }
  private string year { get; set; }
	public Book(string author, string name, string pages, string publishing, string year)
    {
		this.author = author;
		this.name = name;
		this.pages = pages;
		this.publishing = publishing;
		this.year = year;
	}
}
