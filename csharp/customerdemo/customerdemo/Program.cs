namespace customerdemo
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public long PhoneNo { get; set; }
        public string City { get; set; }

    }
    class Management
    {
        List<Customer> customers;
        public Management()
        {
            customers = new List<Customer>()
            {
                new Customer() {Id=1,FirstName="Lakshmi",LastName="Abitha",Email="lakshmi@gmail.com",Age=4,PhoneNo=9110727275,City="rjy"},
                new Customer() {Id=2,FirstName="arava",LastName="raju",Email="raju@gmail.com",Age=45,PhoneNo=9111827275,City="kkd"}
            };
        }
        public void AddCustomers(Customer customer)
        {
            customers.Add(customer);
        }
        public int RandomCustomerId(string firstname, string lastName)
        {
            Random random = new Random();
            int randomno = random.Next(1, 999);
            return randomno;
        }
        public Customer GetCustomer(int id)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;

        }
        public List<Customer> GetCustomers()
        {
            return customers;
        }
        public bool UpdateCustomer(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.Id == id)
                {
                    Console.WriteLine("Enter the updated details");
                    Console.WriteLine("Enter the first name");
                    c.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter the Last name");
                    c.LastName = Console.ReadLine();
                    Console.WriteLine("Enter the email");
                    c.Email = Console.ReadLine();
                    Console.WriteLine("Enter the age");
                    c.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the phone number");
                    c.PhoneNo =Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter the city");
                    c.City = Console.ReadLine();
                    return true;
                }
            }
            return false;
        }
        public bool DeleteCustomer(int id)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Id == id)
                {
                    customers.Remove(customer);
                    return true;
                }
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Management obj = new Management();
            string res = "";
            Random rn = new Random();
            int random = rn.Next(10, 99);
            do
            {
                Console.WriteLine("1.Add Customers");
                Console.WriteLine("2.Get Customers By Id");
                Console.WriteLine("3.Get All Customers");
                Console.WriteLine("4.Update Customers By Id");
                Console.WriteLine("5.Delete Customers By Id");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Customer First name");
                            string fname = Console.ReadLine();
                            Console.WriteLine("Enter Customer Last name");
                            string lname = Console.ReadLine();
                            Console.WriteLine("Enter Customer email");
                            string email = Console.ReadLine();
                            Console.WriteLine("Enter Customer age");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Customer phone number");
                            long phoneno = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter Customer city");
                            string city = Console.ReadLine();
                            int customerid = obj.RandomCustomerId(fname, lname);
                            obj.AddCustomers(new Customer() { Id = customerid, FirstName = fname, LastName = lname, Email = email, Age = age, PhoneNo = phoneno, City = city });
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Customer Id");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Customer? c = obj.GetCustomer(id);
                            if (c == null)
                            {
                                Console.WriteLine("Id is does not exists");
                            }
                            else
                            {
                                Console.WriteLine($"{c.Id} {c.FirstName} {c.LastName} {c.Email} {c.Age} {c.PhoneNo} {c.City}");
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (Customer c in obj.GetCustomers())
                            {
                                Console.WriteLine($"{c.Id} {c.FirstName} {c.LastName} {c.Email} {c.Age} {c.PhoneNo} {c.City}");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the customer id");
                            int id = Convert.ToInt32(Console.ReadLine());
                            if (obj.UpdateCustomer(id))
                            {
                                Console.WriteLine("Customer id is updated");
                            }
                            else
                            {
                                Console.WriteLine("Customer id is not existed");
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter the customer id");
                            int id = Convert.ToInt32(Console.ReadLine());
                            if (obj.DeleteCustomer(id))
                            {
                                Console.WriteLine("Customer is deleted");
                            }
                            else
                            {
                                Console.WriteLine("Customer id is not existed");
                            }
                            break;
                        }
                }
                Console.WriteLine("Do you wish to continue[y/n]");
                res = Console.ReadLine();
            } while (res.ToLower() == "y");
        }
    }
}