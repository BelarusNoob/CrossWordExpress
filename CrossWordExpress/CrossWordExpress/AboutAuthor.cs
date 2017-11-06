using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CrossWordExpress
{
    public partial class AboutAuthor : Form
    {
        public AboutAuthor()
        {
            InitializeComponent();
        }

        private void VKbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/mrredwarior");
        }

        private void FBbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100007467404929");
        }
    }
}
