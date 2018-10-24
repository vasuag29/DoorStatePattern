using System;

namespace DoorStatePattern
{
    public class DoorClosedAndUnlockedState : DoorState
    {
        DoorStateContext _context; //DoorStateContext object for injecting the dependency onto the same object throughout
		
        public DoorClosedAndUnlockedState(DoorStateContext context)
        {
            _context = context;
        }
        public override void CloseDoor()
        {
            Console.WriteLine("The door is already closed and unlocked. *sigh*");
        }

        public override void LockDoor()
        {
            Console.WriteLine("The door has been locked.");
            //_context.currentState.LockDoor();
            _context.SwitchState(typeof(DoorClosedAndLockedState));
        }

        public override void OpenDoor()
        {
            Console.WriteLine("The door opened wide. That was easy.");
            //_context.currentState.OpenDoor();
            // Console.WriteLine("exec1"); Console.WriteLine(typeof(DoorOpenState));
            _context.SwitchState(typeof(DoorOpenState));
            //Console.WriteLine("exec2");
        }

        public override void UnlockDoor()
        {
            Console.WriteLine("The door is already unlocked.");
        }
    }
}
