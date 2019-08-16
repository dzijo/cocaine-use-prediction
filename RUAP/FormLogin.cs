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
    public partial class FormLogin : Form
    {
        public static int doctorId = 0;
        DBContext dbcontext;
        public FormLogin()
        {
            InitializeComponent();
            dbcontext = new DBContext();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            try
            {
                Models.Doctor doctor = dbcontext.Doctors.Where(x => x.Username == username && x.Password == password).First();

                doctorId = doctor.Id;
                this.Hide();

                FormMain formMain = new FormMain();
                formMain.Show();
            }
            catch
            {
                MessageBox.Show("Wrong username or password.");
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonLogin.PerformClick();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister dialog = new FormRegister();
            if(dialog.ShowDialog(this) == DialogResult.OK)
            {
                var username = dialog.textBoxUsername.Text;
                var password = dialog.textBoxPassword.Text;

                dbcontext.Doctors.Add(new Models.Doctor(username, password));
                dbcontext.SaveChanges();
            }
        }
    }
}
