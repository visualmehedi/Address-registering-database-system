using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class ConReg : Form
    {

        /// <summary>
        /// MainForm is using ("has a") relation 
        /// It "has an" object of type ContactManager
        /// </summary>
        private ContactManager m_contactMngr = null;  //ref variable declared


        /// <summary>
        /// Default constructor - a good place for initializations
        /// </summary>
        public ConReg()
        {
            InitializeComponent();

            InitializeGUI();

            m_contactMngr = new ContactManager();
        }


        /// <summary>
        /// Prepare the form before display
        /// Initiate input controls with default values
        /// Remove design time texts from output controls (label1, textbox1, etc.)
        /// </summary>
        private void InitializeGUI()
        {
            // Fill the estate combobox with values from enum
            _country.Items.AddRange(Enum.GetNames(typeof(Countries)));
            //Make this readonly
            _country.DropDownStyle = ComboBoxStyle.DropDownList;
            _country.SelectedIndex = (int)Countries.Bangladesh; //Choose one type as default

            _fName.Text = String.Empty;
            _lName.Text = String.Empty;
            _street.Text = String.Empty;
            _city.Text = String.Empty;
            _zipCode.Text = String.Empty;
        }


        /// <summary>
        /// Get adddress items from the Address groupbox (textboxes)
        /// and save the values in a local instance of address.
        /// This method is called by ReadInput.
        /// </summary>
        private Address ReadAddress()
        {
            Address adrs = new Address();
            adrs.City = _city.Text;
            adrs.Country = _country.Text;
            adrs.Street = _street.Text;
            adrs.ZipCode = _zipCode.Text;

            return adrs;
        }


        /// <summary>
        /// fetch data from the GUI (textboxes, combobox, etc)
        /// save data in the instance variable contact
        /// </summary>
        private Contact ReadInput()
        {
            //Create a local estate instance for filling in input
            Contact contact = new Contact();

            //Call a method that returns a complete address object 
            Address adr = ReadAddress();

            //Set the address in the object contact 
            contact.AddressData = adr;

            contact.FirstName = _fName.Text;
            contact.LastName = _lName.Text;

            return contact;
        }

        private void ConReg_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// adding in the listBox
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_fName.Text == "")
            {
                MessageBox.Show("Please give a valid First Name!", "Please . . .");
                return;
            }
            if (_fName.Text == " ")
            {
                MessageBox.Show("Please give a valid First Name!", "Please . . .");
                return;
            }


            if (_lName.Text == "")
            {
                MessageBox.Show("Please give a valid Last Name!", "Please . . .");
                return;
            }
            if (_lName.Text == " ")
            {
                MessageBox.Show("Please give a valid Last Name!", "Please . . .");
                return;
            }


            if (_street.Text == "")
            {
                MessageBox.Show("Please give a valid Street Number!", "Please . . .");
                return;
            }
            if (_street.Text == " ")
            {
                MessageBox.Show("Please give a valid Street Number!", "Please . . .");
                return;
            }


            if (_city.Text == "")
            {
                MessageBox.Show("Please give a valid City Name!", "Please . . .");
                return;
            }
            if (_city.Text == " ")
            {
                MessageBox.Show("Please give a valid City Name!", "Please . . .");
                return;
            }


            if (_zipCode.Text == "")
            {
                MessageBox.Show("Please give valid Zip Code!", "Please . . .");
                return;
            }
            if (_zipCode.Text == " ")
            {
                MessageBox.Show("Please give valid Zip Code!", "Please . . .");
                return;
            }

            m_contactMngr.AddContact(ReadInput());
            UpdateGUi();
        }


        /// <summary>
        /// Reset result list and fill  with new values
        /// </summary>
        private void UpdateGUi()
        {
            listBoxConReg.Items.Clear();
            _NumofRegCon.Text = m_contactMngr.Count.ToString();
            for (int index = 0; index < m_contactMngr.Count; index++)
            {
                listBoxConReg.Items.Add(m_contactMngr.GetContact(index).ToString());

            }
        }


        /// <summary>
        /// deleting from the listBox
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            m_contactMngr.DeleteContact(listBoxConReg.SelectedIndex);
            UpdateGUi();
        }

        /// <summary>
        /// changing an existing record on the listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            var tempcontact = m_contactMngr.GetContact(listBoxConReg.SelectedIndex);
            if (tempcontact != null)
            {
                tempcontact.FirstName = _fName.Text;
                tempcontact.LastName = _lName.Text;
                tempcontact.AddressData.Street = _street.Text;
                tempcontact.AddressData.City = _city.Text;
                tempcontact.AddressData.ZipCode = _zipCode.Text;
                tempcontact.AddressData.Country = _country.Text;
            }

            if (_fName.Text == "")
            {
                MessageBox.Show("Please give a valid First Name!", "Please . . .");
                return;
            }
            if (_fName.Text == " ")
            {
                MessageBox.Show("Please give a valid First Name!", "Please . . .");
                return;
            }


            if (_lName.Text == "")
            {
                MessageBox.Show("Please give a valid Last Name!", "Please . . .");
                return;
            }
            if (_lName.Text == " ")
            {
                MessageBox.Show("Please give a valid Last Name!", "Please . . .");
                return;
            }


            if (_street.Text == "")
            {
                MessageBox.Show("Please give a valid Street Number!", "Please . . .");
                return;
            }
            if (_street.Text == " ")
            {
                MessageBox.Show("Please give a valid Street Number!", "Please . . .");
                return;
            }


            if (_city.Text == "")
            {
                MessageBox.Show("Please give a valid City Name!", "Please . . .");
                return;
            }
            if (_city.Text == " ")
            {
                MessageBox.Show("Please give a valid City Name!", "Please . . .");
                return;
            }


            if (_zipCode.Text == "")
            {
                MessageBox.Show("Please give valid Zip Code!", "Please . . .");
                return;
            }
            if (_zipCode.Text == " ")
            {
                MessageBox.Show("Please give valid Zip Code!", "Please . . .");
                return;
            }

            UpdateGUi();
        }
    }
}