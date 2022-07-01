using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            STU STU_1 = new STU();
            string str = $"第1位學生:{STU_1.PRINTME()}";
            STU STU_2 = new STU();
            str += $"\n第2位學生:{STU_2.PRINTME()}";
            STU STU_3 = new STU(64,57,48);
            str += $"\n第3位學生:{STU_3.PRINTME()}";
            STU STU_4 = new STU(-6,-2,9);
            str += $"\n第4位學生:{STU_4.PRINTME()}";
            STU STU_5 = new STU("B0226497_5", "段昱如_5", "567890");
            str += $"\n第5位學生:{STU_5.PRINTME()}";
            STU STU_6 = new STU("B0226497_6", "段昱如_6", "678902");
            str += $"\n第6位學生:{STU_6.PRINTME()}";
            STU STU_7 = new STU();
            STU_7.ID = "B0226497_7";
            STU_7.NAME = "段昱如_7";
            STU_7.PHONE = "789246";
            STU_7.chi = 120;
            STU_7.math = 100;
            STU_7.eng = 97;
            str += $"\n第7位學生:{STU_7.PRINTME()}";
            STU STU_8 = new STU();
            STU_8.ID = "B0226497_8";
            STU_8.NAME = "段昱如_8";
            STU_8.PHONE = "892468";
            STU_8.chi = 97;
            STU_8.math = 78;
            STU_8.eng = 86;
            str += $"\n第8位學生:{STU_8.PRINTME()}";
            lblRESULT.Text = str;
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
