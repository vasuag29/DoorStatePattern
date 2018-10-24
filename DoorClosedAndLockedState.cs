using System;

namespace DoorStatePattern
{
    public class DoorClosedAndLockedState : DoorState
    {
        DoorStateContext _context; //DoorStateContext object for injecting the dependency onto the same object throughout
		
        public DoorClosedAndLockedState(DoorStateContext context)
        {
            _context = context;
        }
        public override void CloseDoor()
        {
            Console.WriteLine("The door is already closed and locked.");
        }

        public override void LockDoor()
        {
            Console.WriteLine("The door is already locked. Try not to break the key!");
        }

        public override void OpenDoor()
        {
            Console.WriteLine("Please unlock the door before attempting to open it. Try using the key hidden under the mat :/");
        }

        public override void UnlockDoor()
        {
            Console.WriteLine("Oh great, the key under the mat worked! The door has been unlocked.");
            _context.SwitchState(typeof(DoorClosedAndUnlockedState));
        }
    }
}
