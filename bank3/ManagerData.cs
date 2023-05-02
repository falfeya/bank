using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bank3.@interface;

namespace bank3
{
    internal class ManagerData : IManagerData
    {        
            public void UpdateCustomerPhoneNumber(CustomerData customer, string newPhoneNumber)
            {
                customer.PhoneNumber = newPhoneNumber;
                customer.ModifiedBy = "Manager";
            }

            public void AddNewCustomerData(string surname, string firstName, string patronymic, string phoneNumber, string passportSeriesNumber)
            {
                var newCustomer = new CustomerData(surname, firstName, patronymic, phoneNumber, passportSeriesNumber);
                newCustomer.ModifiedBy = "Manager";
            }
            public void UpdateCustomerData(CustomerData customer, string surname, string firstName, string patronymic, string phoneNumber, string passportSeriesNumber)
            {
                customer.Surname = surname;
                customer.FirstName = firstName;
                customer.Patronymic = patronymic;
                customer.PhoneNumber = phoneNumber;
                customer.PassportSeriesNumber = passportSeriesNumber;
                customer.ModifiedBy = "Manager";
            }
    }
}

