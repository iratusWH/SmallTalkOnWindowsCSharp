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
    public partial class MainChatPage : Form
    {
        public MainChatPage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EnterActivity f = new EnterActivity();
            f.Show();
            this.Close();
        }
    }
}
