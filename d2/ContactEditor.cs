using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace d2
{
    public partial class ContactEditor : Form
    {
        public Contact Contact { get; private set; }

        public ContactEditor()
        {
            InitializeComponent();
        }

        public ContactEditor(Contact contact) : this()
        {
            this.Contact = contact;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Contact.FirstName = txtFirstName.Text;
            this.Contact.LastName = txtLastName.Text;
            this.Contact.EmailAddress = txtEmail.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void ContactEditor_Load(object sender, EventArgs e)
        {
            if (this.Contact == null) { this.Contact = new Contact(); }

            txtFirstName.Text = this.Contact.FirstName;
            txtLastName.Text = this.Contact.LastName;
            txtEmail.Text = this.Contact.EmailAddress;
        }
    }
}
