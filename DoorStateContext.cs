/*
This 'DoorStateContext' class is actually the real door class that we will use to create a new door.
This class contains initializations of the door and also the functions that a door can call, like 'SwitchState' 
*/
namespace DoorStatePattern
{
    public class DoorStateContext : DoorState
    {
		//The possible states of a door
        public DoorState currentState;
        public DoorOpenState doorOpenState;
        public DoorClosedAndLockedState doorClosedAndLockedState;
        public DoorClosedAndUnlockedState doorClosedAndUnlockedState;

        //public DoorState GetCurrentDoorState() { return currentState; }
        //public void SetDoorState(DoorState doorState) { currentState = doorState; }

        public DoorStateContext()
        {
			//Passing this object to the constructors of all door states so that they all work on the same DoorStateContext object
            doorOpenState = new DoorOpenState(this);
            doorClosedAndLockedState = new DoorClosedAndLockedState(this);
            doorClosedAndUnlockedState = new DoorClosedAndUnlockedState(this);
            currentState = doorOpenState; //Initializing the door state as open
        }

		//Method for switching the currentState of the door according to the passes argument
        public void SwitchState(System.Type type)
        {
            if (type == typeof(DoorClosedAndUnlockedState))
            {
                currentState = doorClosedAndUnlockedState;
            }
            else if (type == typeof(DoorClosedAndLockedState))
            {
                currentState = doorClosedAndLockedState;
            }
            else if (type == typeof(DoorOpenState))
            {
                currentState = doorOpenState;
            }
            else throw new InvalidStateException("The State " + type.ToString() + " is invalid!");
        }

        public override void OpenDoor()
        {
            currentState.OpenDoor();
        }

        public override void CloseDoor()
        {
            currentState.CloseDoor();
        }

        public override void LockDoor()
        {
            currentState.LockDoor();
        }

        public override void UnlockDoor()
        {
            currentState.UnlockDoor();
        }
    }
}
