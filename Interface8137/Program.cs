Person person = new Person()
{
    Id = 1,
    FirstName = "Çağıl",
    LastName = "Alsaç"
};

person.FirstName = "Leo";

Console.WriteLine(person.Id + "-" + person.FirstName + " " + person.LastName);

IPerson insan = new Person(); // polymorphism
insan = new Student();

IPerson customer1 = new Customer()
{
    Id = 2,
    FirstName = "Ali",
    LastName = "Veli",
    CardNo = "1234"
};

Customer customer2 = new Customer();
customer2.Id = 3;
customer2.FirstName = "Can";
customer2.LastName = "Sun";
customer2.CardNo = "1234";

IPerson customer3 = new Customer();
customer3.Id = 17;
customer3.FirstName = "Michael";
customer3.LastName = "Scofield";

((Customer)customer3).CardNo = "999";  // casting


(customer3 as Customer).CardNo = "888"; // casting














interface IPerson // soyut abstract
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Person : IPerson // somut concrete
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CardNo { get; set; }
}
