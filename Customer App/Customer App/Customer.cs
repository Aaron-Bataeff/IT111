namespace CustomerManagementSystem
{
    public class Customer
    {
        private static int _nextId = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Customer()
        {
            Id = _nextId++;
        }
    }
}
