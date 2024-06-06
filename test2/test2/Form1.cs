using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace test2

{
    public partial class Form1 : Form
    {
        //private System.ComponentModel.Container components;
        private System.Windows.Forms.Button printButton;
        private Font printFont;
        private StreamReader streamToPrint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //{


            printDocument1.Print();
            //}
        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 tabble = new Form2(1);
            tabble.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 tabble = new Form2(2);
            tabble.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 tabble = new Form2(3);
            tabble.Show();
        }

        private void tabble4_Click(object sender, EventArgs e)
        {
            Form2 tabble = new Form2(4);
            tabble.Show();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
    }
}
