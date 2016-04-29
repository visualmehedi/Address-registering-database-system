using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Contact
    {
        //Fields
        private Address m_address;
        private String m_firstName;
        private String m_lastName;

        public Contact()
        {
            this.m_address = null;
            this.m_firstName = String.Empty;
            this.m_lastName = String.Empty;
        }

        public Contact(Contact other)
        {
            this.m_address = other.AddressData;
            this.m_firstName = other.FirstName;
            this.m_lastName = other.LastName;
        }

        public Contact(Address address, String firstName, String lastName)
        {
            this.m_address = address;
            this.m_firstName = firstName;
            this.m_lastName = lastName;
        }

        public Address AddressData
        {
            get { return m_address; }
            set { this.m_address = value; }
        }

        public String FirstName
        {
            get { return m_firstName; }
            set { this.m_firstName = value; }
        }

        public String LastName
        {
            get { return m_lastName; }
            set { this.m_lastName = value; }
        }

        public String FullName
        {
            get { return m_firstName + " " + m_lastName; }
        }

        public override String ToString()
        {
            return String.Format(" {0, -24} {1,-24}", this.FullName, m_address.ToString());
        }
    }
}