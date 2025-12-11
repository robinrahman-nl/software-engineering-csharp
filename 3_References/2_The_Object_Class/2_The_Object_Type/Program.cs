using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Book bk = new Book();
      Object o1 = bk;
      
      Novel nl = new Novel(38);
      Object o2 = nl;
      
      int i = 9;
      Object o3 = i;
      

    }
  }
}
