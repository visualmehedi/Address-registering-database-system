using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class ContactManager
    {
        /// <summary>
        /// using the List object
        /// </summary>
        private List<Contact> m_contacRegistry;  //declaration of the ref variable, object not yet created


        /// <summary>
        /// Default constructor - create the Contact objects list
        /// </summary>
        public ContactManager()
        {
            //1.  creating the list object
            m_contacRegistry = new List<Contact>();
        }


        /// <summary>
        /// add a new Contact object to the list
        /// </summary>
        public Boolean AddContact(Contact contactObj)
        {
            if (contactObj != null)
            {
                m_contacRegistry.Add(contactObj);
                return true;
            }
            return false;
        }


        /// <summary>
        /// add a new Contact object to the list
        /// </summary>
        public Boolean AddContact(String farstName, String lastName, Address adrs)
        {
            Contact contactObj = new Contact(adrs, farstName, lastName);
            if (contactObj != null)
            {
                m_contacRegistry.Add(contactObj);
                return true;
            }
            return false;
        }


        /// <summary>
        /// delete Contact object by index
        /// </summary>
        public Boolean DeleteContact(int index)
        {
            if (IsIndexValid(index))
            {
                m_contacRegistry.RemoveAt(index);
                return true;
            }
            else
                return false;
        }


        /// <summary>
        /// change Contact object by index
        /// </summary>
        public Boolean ChangeContact(Contact contact, int index)
        {
            if (IsIndexValid(index))
            {
                m_contacRegistry.Insert(index, contact);
                return true;
            }
            else
                return false;
        }


        /// <summary>
        /// get Contact object by index
        /// </summary>
        public Contact GetContact(int index)
        {
            if (IsIndexValid(index))
            {
                return m_contacRegistry[index];
            }
            else
                return null;
        }


        /// <summary>
        /// get copy of Contact object by index
        /// </summary>
        public Contact GetContactCopy(int index)
        {
            if (IsIndexValid(index))
            {
                return new Contact(m_contacRegistry[index]);
            }
            else
                return null;
        }

        public bool IsIndexValid(int index)
        {
            return ((index >= 0) && (index < m_contacRegistry.Count));
        }

        public int Count
        {
            get { return m_contacRegistry.Count; }
        }
    }
}