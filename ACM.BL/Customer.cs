using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Customer type of the ACM
    /// </summary>
    public class Customer
    {
        // Private fields
        private string _firstName;
        private string _lastName;
        // Public properties
        public int CustomerId { get; private set; }
        public string FirstName 
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;

        }
        public string FullName
        {
            get 
            {
                // The FullName style: "LastName, FirstName"

                // Set the full name to LastName initially
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }
                    // Set the full name to FirstName
                    fullName += FirstName;
                }

                if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName))
                {
                    FirstName = "User";
                    LastName = "New";
                    return LastName + ", " + FirstName;
                }
                return fullName;
            }

        }
        public string EmailAddress { get; set; }

        public static int InstancesCounter { get; private set; }
        public Customer()
        {
            InstancesCounter++;
        }

        // Public methods
        
        /// <summary>
        /// Validates the inputs Custoemr properties
        /// </summary>
        /// <returns>true or false</returns>
        public bool Validate()
        {
            bool isValid = false;
            if (string.IsNullOrEmpty(LastName)) isValid = true;
            if (string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(EmailAddress)) isValid = true;
            return isValid;
        }
        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns>true or falase</returns>
        public bool Save()
        {
            // Saves the customer changes
            return true;
        }
        /// <summary>
        /// Retrieves a customer with specific Id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns>Customer instance</returns>
        public Customer Retrieve(int customerId)
        {
            // return the defined customer
            return new Customer();
        }
        /// <summary>
        /// List of Customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            // retrieves all of the customers
            return new List<Customer>();
        }
    }
}
