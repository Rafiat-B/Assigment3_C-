using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class LoginForm : Form
    {
        List<User> users = new List<User>();
        
        
        public LoginForm()
        {
            InitializeComponent();
            //UserDB.saveUser("Admin", "password");
            //UserDB.saveUser("Admin1", "password");
            //UserDB.saveUser("Admin2", "password");
            ////users = UserDB.GetUser();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userId = txtUser.Text;
            string password = txtPass.Text;

            List<User> users = UserDB.GetUser();
            User user = users.FirstOrDefault(u => u.UserId == userId && u.Password == password);

            
                if (user != null)
                {
                    // Open main form or perform other actions
                    MessageBox.Show("Login Successful");
                    StudentAssignForm studentForm = new StudentAssignForm();
                    this.Hide();
                    studentForm.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Invalid UserId or Password.");
                }
            
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
