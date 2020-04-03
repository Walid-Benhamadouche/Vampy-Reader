using System;

namespace Vampy_Reader
{
	public class Book
	{
		public string name { get; set; }
		public string backGroundImagePath { get; set; }
		public int numberOfPages { get; set; }
		public int currentPage { get; set; }
		public string bookPath { get; set; }
		// adding more proprities later

		public Book(string name, string backGroundImagePath, int numberOfPages, int currentPage, string bookPath)
		{
			this.name = name;
			this.backGroundImagePath = backGroundImagePath;
			this.numberOfPages = numberOfPages;
			this.currentPage = currentPage;
			this.bookPath = bookPath;
		}
		//ToDo:
	}

}