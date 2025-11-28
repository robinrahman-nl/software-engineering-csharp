using System;

namespace BiblioInheritance
{
  class Book : Resource
    {
      public string[] Authors
        {
            get; private set;
        }
      
      public int PageCount
        {
            get; private set;
        }

// 7. Add a Book constructor that takes three string parameters and one int. 
//    It should call the base constructor with the values corresponding to Title and Category, 
//    then directly set the Author and PageCount properties with the other values.
        public Book (string title, string category, string[] authors, int pagecount) : base (title, category)
        {
            this.Authors = authors;
            this.PageCount = pagecount;
        }

    public override void GetInfo()
    {
      Console.WriteLine("##################################################################################");
      string authorList = string.Join(", ", this.Authors);
      Console.WriteLine($"Title: {this.Title}\nCategory: {this.Category}\nAuthor(s): {authorList}\nStatus: {this.Status}" );
    }

    }
}