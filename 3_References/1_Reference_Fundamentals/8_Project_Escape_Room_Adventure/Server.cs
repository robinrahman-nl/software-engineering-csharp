namespace EscapeRoomAdventure
{

    // 11. Define a class Server that implements ISystem. 
    // Create a property called Status of type string 
    // and implement the Operate() method to print "Server is <STATUS>" 
    // where STATUS is the value of the Server‘s Status.
    public class Server: ISystem
    {
        public string Status
        {
            get; set;
        }

        public void Operate ()
        {
            Console.WriteLine($"Server is {Status}");           
        }
    }
}