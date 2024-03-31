using Prototype_Factory.Contact;

namespace Prototype_Factory
{
    public class EmployeeFactory
    {
        private EmployeeContact mainOfficeEmployeeContact = new EmployeeContact()
        {
            Address = new Contact.Address {City = "Barnaul", Street="Lenina 130" } 
        };

        private EmployeeContact fillialOfficeEmployeeContact = new EmployeeContact()
        {
            Address = new Contact.Address { City = "Barnaul", Street = "Lenina 105" }
        };

        public EmployeeContact newEmployeeContact(string name,int suite, EmployeeContact contactType)
        {
            var employee = contactType.DeepCopy();
            employee.Name = name;
            employee.Address.Suite = suite;

            return employee;
        }

        public EmployeeContact NewMainOfficeEmployeeContact(string name, int suite)
        {
            return newEmployeeContact(name, suite, mainOfficeEmployeeContact);
        }

        public EmployeeContact NewFillialOfficeEmployeeContact(string name, int suite)
        {
            return newEmployeeContact(name, suite, fillialOfficeEmployeeContact);
        }
    }
}
