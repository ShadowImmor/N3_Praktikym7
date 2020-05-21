using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            N.Maximum = int.MaxValue;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (N.Value != (int)N.Value)
                N.Value = (int)N.Value;
            Slov.Clear();
            StringBuilder strb = new StringBuilder(Ish.Text);
            if (strb.Length == 0)
                return;
            for (int i = 0; i < strb.Length;)
                if (char.IsPunctuation(strb[i])) strb.Remove(i, 1);
                else i++;
            string str = strb.ToString();
            str = str.Trim();
            string[] s = str.Split(' ');
            for (int i = 0; i < s.Count(); i++)
                if (s[i].Count() <= (int)N.Value)
                    Slov.Text += s[i] + " ";
        }
    }
}
