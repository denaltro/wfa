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
    public partial class UserForm : Form
    {
        private User User;

        public UserForm(User user = null)
        {
            User = user;
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Id = User?.Id ?? Guid.NewGuid(),
                Name = textBox1.Text,
                Password = (User != null && User?.Password == textBox2.Text) ? User.Password : Helpers.sha256_hash(textBox2.Text),
                IsAdmin = checkBox1.Checked,
                IsDeleted = false
            };
            MongoRepositoryUsers.Upsert(user);
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (User == null) return;
            textBox1.Text = User.Name;
            textBox2.Text = User.Password;
            checkBox1.Checked = User.IsAdmin;
        }
    }
}
