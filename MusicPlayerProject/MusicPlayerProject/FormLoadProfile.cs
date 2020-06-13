using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerProject
{
    public partial class FormLoadProfile : Form
    {
        public FormLoadProfile(string inUsername)
        {
            InitializeComponent();
            textBoxUsername.Text = inUsername;
        }

        private void buttonLoadProfile_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string GetPassword()
        {
            return textBoxPassword.Text;
        }
    }
}
