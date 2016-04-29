using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Address
    {
        //Fields
        private String m_city;
        private String m_country;
        private String m_street;
        private String m_zipCode;


        /// <summary>
        /// Default constructor. 
        /// Strings are initiated to null by the compiler.
        /// It is better to assign then an Empty so they are no longer null 
        /// </summary>
        public Address()
        {
            m_city = String.Empty;
            m_country = String.Empty;
            m_street = String.Empty;
            m_zipCode = String.Empty;
        }


        ///copy consructor Exercise:  http://msdn.microsoft.com/en-us/library/ms173116(VS.80).aspx
        /// <summary>
        /// Copy constructor: Use this when you are copying
        /// from one object to another object of this class
        /// </summary>
        public Address(Address other)
        {
            this.m_city = other.m_city;
            this.m_country = other.m_country;
            this.m_street = other.m_street;
            this.m_zipCode = other.m_zipCode;
        }

        public Address(String street, String zipCode, String city)
        {
            this.m_street = street;
            this.m_zipCode = zipCode;
            this.m_city = city;
            this.m_country = String.Empty;
        }

        public Address(String city, String country, String street, String zipCode)
        {
            this.m_street = street;
            this.m_city = city;
            this.m_country = country;
            this.m_zipCode = zipCode;
        }

        public String Street
        {
            get { return m_street; }
            set { m_street = value; }
        }

        public String City
        {
            get { return m_city; }
            set { m_city = value; }
        }

        public String Country
        {
            get { return m_country; }
            set { m_country = value; }
        }

        public String ZipCode
        {
            get { return m_zipCode; }
            set { m_zipCode = value; }
        }

        /// <summary>
        /// Formatting text into several lines
        /// </summary>
        public String GetAddressLabel()
        {
            return m_street + " " + m_zipCode + " "  + m_city + " " + m_country;
        }


        /// <summary>
        /// Formatting text into one line
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0, -12} {1, -12} {2, -12} {3, -12}", m_street, m_zipCode, m_city, m_country);
        }
    }
}