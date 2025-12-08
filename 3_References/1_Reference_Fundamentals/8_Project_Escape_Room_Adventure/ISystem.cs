interface ISystem
{   
    // Inside, create an interface called ISystem with a method named Operate() that returns nothing 
    // and a string property named Status.
    string Status
    {
        get; set;
    }
    void Operate ();
}