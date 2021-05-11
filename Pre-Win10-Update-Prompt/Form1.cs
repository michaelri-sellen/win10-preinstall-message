using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pre_Win10_Update_Prompt
{
    public partial class MainPrompt : Form
    {
        public MainPrompt()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
