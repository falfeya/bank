using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank3
{
    internal class CustomerData
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _phoneNumber = value;
                    RecordChanges("PhoneNumber", value);
                }
            }
        }
        private string _passportSeriesNumber;
        public string PassportSeriesNumber
        {
            get
            {
                if (!string.IsNullOrEmpty(_passportSeriesNumber))
                {
                    return "******************";
                }
                else
                {
                    return _passportSeriesNumber;
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _passportSeriesNumber = value;
                    RecordChanges("PassportSeriesNumber", value);
                }
            }
        }
        public DateTime? LastModificationDate { get; set; }
        public string ModifiedData { get; set; }
        public string ModificationType { get; set; }
        public string ModifiedBy { get; set; }

        public CustomerData(string surname, string firstName, string patronymic, string phoneNumber, string passportSeriesNumber)
        {
            Surname = surname;
            FirstName = firstName;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            PassportSeriesNumber = passportSeriesNumber;
        }

        private void RecordChanges(string fieldName, string value, string modificationType = "Update")
        {
            LastModificationDate = DateTime.Now;
            ModifiedData = fieldName + ":" + value;
            ModificationType = modificationType;
        }
    }
}

