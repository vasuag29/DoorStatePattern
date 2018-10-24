//The parent abstarct class for the types of door states
//The door states can be of 3 types: Door open, Door closed and unlocked, Door closed and locked
namespace DoorStatePattern
{
    public abstract class DoorState
    {
        public abstract void OpenDoor();
        public abstract void CloseDoor();
        public abstract void LockDoor();
        public abstract void UnlockDoor();
    }
}
