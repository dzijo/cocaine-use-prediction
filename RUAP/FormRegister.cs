using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUAP
{
    public partial class FormRegister : Form
    {
        string PIN = "0442";
        DBContext dBContext;
        public FormRegister()
        {
            InitializeComponent();
            dBContext = new DBContext();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                var username = textBoxUsername.Text;
                if (textBoxPIN.Text == PIN)
                {
                    if (dBContext.Doctors.Where(x => x.Username == username).Count() == 0)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Username already exists!");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong PIN!");
                }
            }
            else
            {
                MessageBox.Show("Enter username and password.");
            }
        }
    }
}
