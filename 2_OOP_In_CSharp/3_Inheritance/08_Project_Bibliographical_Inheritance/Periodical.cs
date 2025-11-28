using System;

namespace BiblioInheritance
{
 class Periodical : Resource
    {
        public string Period
        {
            get; private set;
        }

    // 11. Next, define a constructor that takes three arguments, one for each property. 
    // Pass the values for the Title and Category to the base constructor, 
    // then in the body of the Periodical constructor, set the value for the new Period property.
      public Periodical (string title, string category, string period) : base(title, category)
        {
            this.Period = period;
        }

    public override void UpdateStatus()
    {
      if ( Status == "Available")
            {
                Status = "In-use";
            } else
            {
                Status = "Available";
            }

    }

    }
}
            