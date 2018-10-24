using System;

namespace DoorStatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
			//Creating a new door
            DoorStateContext door = new DoorStateContext();

            int choice;
            
            try //Just in case an exception arises, although it shouldn't
            {
                while (true)
                {
                    
                    Console.WriteLine("1. Open | 2. Close | 3. Lock | 4. Unlock");
                    choice = Convert.ToInt16(Console.ReadLine());
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
					//A simple switch case loop for runnning the program
                    switch (choice)
                    {
                        case 1:
                            door.OpenDoor();
                            break;
                        case 2:
                            door.CloseDoor();
                            break;
                        case 3:
                            door.LockDoor();
                            break;
                        case 4:
                            door.UnlockDoor();
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
                //door.CloseDoor();
                //door.LockDoor();
                //door.OpenDoor();
                //door.UnlockDoor();
                //door.OpenDoor();
            }

            catch(InvalidStateException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();               
            }
            
        }
    }
}
