using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplom.Models;
using Diplom.Repository;

namespace Diplom
{
    public partial class AuthForm : Form
    {
        public User User;
        private int TryCount = 3;


        public AuthForm()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            var name = textBox_name.Text;
            var password = Helpers.sha256_hash(textBox_password.Text);
            User = MongoRepositoryUsers.Login(name, password);
            if (User != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                if (TryCount == 0)
                {
                    Application.Exit();
                }
                MessageBox.Show("Неверные даныне для входа!");
                TryCount--;
                DialogResult = DialogResult.Cancel;
            }

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
