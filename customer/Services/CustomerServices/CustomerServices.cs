namespace customer.Services.CustomerServices
{
    public class CustomerServices : ICustomerServices
    {
        private static List<Customer> Customers = new List<Customer>
            {
                new Customer

                {
                    ID = 1,
                    Firstname = "Elifnur",
                    Lastname = "Arslan",
                    EmailAddress = "elif@hotmail.com",
                    MobilPhoneNumber = "123456",
                    Password = "elif123"
                },
                new Customer
                {
                    ID = 2,
                    Firstname = "Esra",
                    Lastname = "Ağcıoğlu",
                    EmailAddress = "esra@hotmail.com",
                    MobilPhoneNumber = "111111",
                    Password = "esra123"
                }

            };
        public List<Customer> AddSingleCustomer(Customer SingleCustomers)
        {
            Customers.Add(SingleCustomers);
            return Customers;
        }

        public List<Customer>? DeleteSingleCustomer(int id)
        {
            var SingleCustomer = Customers.Find(x => x.ID == id);
            if (SingleCustomer is null)
                return null;
                Customers.Remove(SingleCustomer);
            return Customers;

        }

        public List<Customer> GetAllCustomers()
        {
            return Customers;
        }

        public Customer? GetSingleCustomers(int id)
        {
            var SingleCustomer = Customers.Find(x => x.ID == id);
            if (SingleCustomer is null)
                return null;
            return SingleCustomer;
        }

        public List<Customer>? UpdateSingleCustomer(int id, Customer request)
        {

            var SingleCustomer = Customers.Find(x => x.ID == id);
            if (SingleCustomer is null)
                return null;

            SingleCustomer.Firstname = request.Firstname;
            SingleCustomer.Lastname = request.Lastname;
            SingleCustomer.EmailAddress = request.EmailAddress;
            SingleCustomer.MobilPhoneNumber = request.MobilPhoneNumber;
            SingleCustomer.Password = request.Password;

            return Customers;
        }
    }
}
