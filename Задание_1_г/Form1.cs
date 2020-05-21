using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Ism.Clear();
            StringBuilder strb = new StringBuilder(Isn.Text);
            char buf;
            if (strb.Length == 0)
                return;
            for (int i = 0; i + 2 <= strb.Length; i += 2)
            {
                buf = strb[i];
                strb[i] = strb[i + 1];
                strb[i + 1] = buf;
            }
            Ism.Text = strb.ToString();
        }
    }
}
