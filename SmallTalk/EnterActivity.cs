using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallTalk
{
    public partial class EnterActivity : Form
    {
      

        public EnterActivity()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((loginTextBox.TextLength != 0) && (passwordTextBox.TextLength != 0)){
                MainChatPage f = new MainChatPage();
                f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Необходимо ввести пароль и логин!");
            }
            
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        
        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationActivity f = new RegistrationActivity();
            f.Show();
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EnterActivity_Load(object sender, EventArgs e)
        {

        }
    }
}
