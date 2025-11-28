using System;

namespace BiblioInheritance
{
  class Video : Resource
  {
    public string Director
    {
      get; private set;
    }

    public int RunTime
    {
      get; private set;
    }

    public string MediaType
    {
      get; private set;
    }

    public Video(string title, string category, string director, string mediaType, int runTime) : base(title, category)
    {
      this.Director = director;
      this.RunTime = runTime;
      this.MediaType = mediaType;
    }

    // 17. 
    // Now, we want to expand the GetInfo() method for Video so that it prints additional data, like the Director and RunTime
    // In Resource.cs, change the base GetInfo() method to a virtual method so that it can be overridden.  
    // In Video.cs, redefine the UpdateStatus() method so that it includes video-specific properties.     
    public override void GetInfo()
    {
      Console.WriteLine("#################################################################");
      Console.WriteLine($"Title: {this.Title}\nCategory: {this.Category}\nStatus: {this.Status}\nDirector: {this.Director}\nRuntime: {this.RunTime}\nMediatype: {this.MediaType}");
    }



  }

}
