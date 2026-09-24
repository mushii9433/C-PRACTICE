using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_assegment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            //creative variable 
            string dayof_week, Name_of_month, Numaric_day, Year, Full_data;

            //intial varlue to variabal
            dayof_week = txtdayweek.Text;
            Name_of_month = txtnamemonth.Text;
            Numaric_day = txtnumericmouth.Text;
            Year = txtyear.Text;

            //storg2 process - concatination  of full date 

            Full_data = dayof_week + " " + Name_of_month + " " + Numaric_day + " " + Year;

            //storage 3

            lbloutput.Text = Full_data;

        }

        private void txtmonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclrear_Click(object sender, EventArgs e)
        {

            //clearing taxtbox and lable

            txtdayweek.Clear();
            txtnamemonth.Clear();
            txtnumericmouth.Clear();
            txtyear.Clear();
            //lable clear
            lbloutput.Text = " ";
        }
    }
}
