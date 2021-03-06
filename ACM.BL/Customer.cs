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

        public static int InstancesCounter { get; private set; }
        public Customer()
        {
            InstancesCounter++;
        }
    }
}
