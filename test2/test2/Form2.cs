using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form2 : Form
    {
        private int receiveddata;
        cart mycart = new cart();

        public Form2(int number)
        {
            receiveddata = number;
            InitializeComponent();
        }

        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Product(string name, double price)
            {
                Name = name;
                Price = price;
            }
        }

        public class cart
        {
            public double cartTotal = 0;
            public List<Product> products = new List<Product>();


            public Product additem(string name, double price)
            {
                Product product = new Product(name, price);
                products.Add(product);
                cartTotal += product.Price;
                return product;
            }

            //function to calculate total based on items
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            lblMesa.Text = "Mesa " + receiveddata.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            Product product = mycart.additem("salad", 2.50);
            ListViewItem listViewItem = new ListViewItem(product.Name);
            listViewItem.SubItems.Add(product.Price.ToString());
            lstvOrder.Items.Add(listViewItem);
            lblTotal.Text = mycart.cartTotal.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVegetables_Click(object sender, EventArgs e)
        {
            Product product = mycart.additem("mixed vegetables", 3.33);
            ListViewItem listViewItem = new ListViewItem(product.Name);
            listViewItem.SubItems.Add(product.Price.ToString());
            lstvOrder.Items.Add(listViewItem);
            lblTotal.Text = mycart.cartTotal.ToString();
        }

        private void lstvOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define font and brush
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Define margins
            int leftMargin = 50;
            int topMargin = 50;
            int lineHeight = 20;

            double total = mycart.cartTotal;

            // Print header
            e.Graphics.DrawString("Receipt", new Font("Arial", 16, FontStyle.Bold), brush, leftMargin, topMargin);
            topMargin += lineHeight;

            // Print date
            e.Graphics.DrawString(DateTime.Now.ToString(), font, brush, leftMargin, topMargin);
            topMargin += lineHeight * 2;

            // Print items and prices

            foreach (Product product in mycart.products)
            {
                e.Graphics.DrawString(product.Name, font, brush, leftMargin, topMargin);
                e.Graphics.DrawString(product.Price.ToString("C"), font, brush, leftMargin + 200, topMargin);
                topMargin += lineHeight;
            }
            //for (int i = 0; i < items.Length; i++)
            //{
            //    e.Graphics.DrawString(items[i], font, brush, leftMargin, topMargin);
            //    e.Graphics.DrawString(prices[i].ToString("C"), font, brush, leftMargin + 200, topMargin);
            //    total += prices[i];
            //    topMargin += lineHeight;
            //}

            // Print total
            e.Graphics.DrawString("Total:", new Font("Arial", 12, FontStyle.Bold), brush, leftMargin, topMargin);
            e.Graphics.DrawString(total.ToString("C"), new Font("Arial", 12, FontStyle.Bold), brush, leftMargin + 200, topMargin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTesting.Text = mycart.cartTotal.ToString();
            printDocument1.Print();
        }

        private void btnSteak_Click(object sender, EventArgs e)
        {
            Product product = mycart.additem("steak", 14.99);
            ListViewItem listViewItem = new ListViewItem(product.Name);
            listViewItem.SubItems.Add(product.Price.ToString());
            lstvOrder.Items.Add(listViewItem);
            lblTotal.Text = mycart.cartTotal.ToString();
        }

        private void btnPotatoes_Click(object sender, EventArgs e)
        {
            Product product = mycart.additem("mashed potatoes", 3.33);
            ListViewItem listViewItem = new ListViewItem(product.Name);
            listViewItem.SubItems.Add(product.Price.ToString());
            lstvOrder.Items.Add(listViewItem);
            lblTotal.Text = mycart.cartTotal.ToString();
        }

        private void btnRiceBeans_Click(object sender, EventArgs e)
        {
            Product product = mycart.additem("rice and beans", 2.80);
            ListViewItem listViewItem = new ListViewItem(product.Name);
            listViewItem.SubItems.Add(product.Price.ToString());
            lstvOrder.Items.Add(listViewItem);
            lblTotal.Text = mycart.cartTotal.ToString();
        }

        private void btnFrenchFries_Click(object sender, EventArgs e)
        {
            Product product = mycart.additem("french fries", 3.10);
            ListViewItem listViewItem = new ListViewItem(product.Name);
            listViewItem.SubItems.Add(product.Price.ToString());
            lstvOrder.Items.Add(listViewItem);
            lblTotal.Text = mycart.cartTotal.ToString();
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            Product product = mycart.additem("chicken", 12.0);
            ListViewItem listViewItem = new ListViewItem(product.Name);
            listViewItem.SubItems.Add(product.Price.ToString());
            lstvOrder.Items.Add(listViewItem);
            lblTotal.Text = mycart.cartTotal.ToString();
        }

        private void btnSalmon_Click(object sender, EventArgs e)
        {
            Product product = mycart.additem("salmon", 11.10);
            ListViewItem listViewItem = new ListViewItem(product.Name);
            listViewItem.SubItems.Add(product.Price.ToString());
            lstvOrder.Items.Add(listViewItem);
            lblTotal.Text = mycart.cartTotal.ToString();
        }
    }
}
