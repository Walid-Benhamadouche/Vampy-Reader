using System;

namespace Vampy_Reader
{
	public class Book
	{
		public string name { get; set; }
		public string backGroundImagePath { get; set; }
		public int numberOfPages { get; set; }
		public int currentPage { get; set; }
		// adding more proprities later

		public Book(string name, string backGroundImagePath, int numberOfPages, int currentPage)
		{
			this.name = name;
			this.backGroundImagePath = backGroundImagePath;
			this.numberOfPages = numberOfPages;
			this.currentPage = currentPage;
		}
		//ToDo:
	}

}