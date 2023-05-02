using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank3
{
    internal class @interface
    {
        public interface IConsultantData
        {
            void UpdateCustomerPhoneNumber(CustomerData customer, string newPhoneNumber);
        }

        public class ConsultantData : IConsultantData
        {
            public void UpdateCustomerPhoneNumber(CustomerData customer, string newPhoneNumber)
            {
                customer.PhoneNumber = newPhoneNumber;
                customer.ModifiedBy = "Consultant";
            }
        }

        public interface IManagerData : IConsultantData
        {
            void AddNewCustomerData(string surname, string firstName, string patronymic, string phoneNumber, string passportSeriesNumber);
            void UpdateCustomerData(CustomerData customer, string surname, string firstName, string patronymic, string phoneNumber, string passportSeriesNumber);
        }
    }
}
