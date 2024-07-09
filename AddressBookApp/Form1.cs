using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AddressBookApp
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>(); // List to store contacts

        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contact contact = new Contact(name, email, phone);
            contacts.Add(contact);

            // Save the contacts to a file or database
            SaveContactsToFile();

            MessageBox.Show("Contact saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void SaveContactsToFile()
        {
            // Implement code to save the contacts list to a file or database
            // For example:
            System.IO.File.WriteAllLines("contacts.txt", contacts.Select(c => c.ToString()));
        }



        public class Contact
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }

            public Contact(string name, string email, string phone)
            {
                Name = name;
                Email = email;
                Phone = phone;
            }

            public override string ToString()
            {
                return $"{Name},{Email},{Phone}";
            }
        }
    }
        public class Contact
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }

            public Contact(string name, string email, string phone)
            {
                Name = name;
                Email = email;
                Phone = phone;
            }

            public override string ToString()
            {
                return $"{Name},{Email},{Phone}";
            }
        }

}
