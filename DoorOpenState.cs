using System;

namespace DoorStatePattern
{
    public class DoorOpenState : DoorState
    {
        DoorStateContext _context; //DoorStateContext object for injecting the dependency onto the same object throughout

        public DoorOpenState(DoorStateContext context)
        {
            _context = context;
        }
        public override void CloseDoor()
        {
            Console.WriteLine("The door has been shut closed.");
            //_context.CloseDoor();
            _context.SwitchState(typeof(DoorClosedAndUnlockedState));
        }

        public override void LockDoor()
        {
            Console.WriteLine("Please close the door first. You cannot lock the door before closing it! Think about it, how can an open door be locked.. ");
        }

        public override void OpenDoor()
        {
            Console.WriteLine("The door is already open, open your eyes!");
        }

        public override void UnlockDoor()
        {
            Console.WriteLine("The door must be locked before you try to unlock it.");
        }
    }
}
