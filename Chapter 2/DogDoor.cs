namespace HeadFirstOOP
{
    public class DogDoor
    {
        private bool _open;

        public DogDoor()
        {
            _open = false;
        }

        public void open()
        {
            Console.WriteLine("Door is Opening...");
            _open = true;
        }

        public void close()
        {
            Console.WriteLine("Door is Closing...");
            _open = false;
        }

        public bool isOpen()
        {
            return _open;
        }
    }
}
