namespace HeadFirstOOP
{
    public class Remote
    {
        private readonly DogDoor _door;

        public Remote(DogDoor door)
        {
            _door = door;
        }

        public void PreesButton()
        {
            Console.WriteLine("Pressing the remote controll Button...");

            if (_door.isOpen())
            {
                _door.close();
            }
            else
            {

                _door.open();
            }
        }
    }
}
