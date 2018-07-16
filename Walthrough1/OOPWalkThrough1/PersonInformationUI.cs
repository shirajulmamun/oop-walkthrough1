using System;
using System.Windows.Forms;
using OOPWalkThrough1.Models;

namespace OOPWalkThrough1
{
    public partial class PersonInformationUI : Form
    {
        public PersonInformationUI()
        {
            InitializeComponent();
        }

        Person person=new Person();

        private void showButton_Click(object sender, EventArgs e)
        {
            person.firstName = firstNameTextBox.Text;
            person.middleName = middleNameTextBox.Text;
            person.lastName = lastNameTextBox.Text;

            fullNameTextBox.Text = person.GetFullName();

        }

       
    }
}
