namespace test2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMesa = new Label();
            btnSteak = new Button();
            btnChicken = new Button();
            btnSalmon = new Button();
            btnVegetables = new Button();
            btnPotatoes = new Button();
            btnSalad = new Button();
            btnRiceBeans = new Button();
            btnFrenchFries = new Button();
            lblOrder = new Label();
            lstvOrder = new ListView();
            item = new ColumnHeader();
            price = new ColumnHeader();
            lblTotal = new Label();
            button1 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            lblTesting = new Label();
            SuspendLayout();
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Location = new Point(113, 46);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(0, 15);
            lblMesa.TabIndex = 0;
            lblMesa.Click += label1_Click;
            // 
            // btnSteak
            // 
            btnSteak.Location = new Point(198, 112);
            btnSteak.Name = "btnSteak";
            btnSteak.Size = new Size(145, 70);
            btnSteak.TabIndex = 1;
            btnSteak.Text = "Steak";
            btnSteak.UseVisualStyleBackColor = true;
            btnSteak.Click += btnSteak_Click;
            // 
            // btnChicken
            // 
            btnChicken.Location = new Point(198, 188);
            btnChicken.Name = "btnChicken";
            btnChicken.Size = new Size(145, 70);
            btnChicken.TabIndex = 2;
            btnChicken.Text = "Chicken";
            btnChicken.UseVisualStyleBackColor = true;
            btnChicken.Click += btnChicken_Click;
            // 
            // btnSalmon
            // 
            btnSalmon.Location = new Point(198, 261);
            btnSalmon.Name = "btnSalmon";
            btnSalmon.Size = new Size(145, 70);
            btnSalmon.TabIndex = 3;
            btnSalmon.Text = "Salmon";
            btnSalmon.UseVisualStyleBackColor = true;
            btnSalmon.Click += btnSalmon_Click;
            // 
            // btnVegetables
            // 
            btnVegetables.Location = new Point(22, 112);
            btnVegetables.Name = "btnVegetables";
            btnVegetables.Size = new Size(170, 70);
            btnVegetables.TabIndex = 4;
            btnVegetables.Text = "Mixed Vegetables";
            btnVegetables.UseVisualStyleBackColor = true;
            btnVegetables.Click += btnVegetables_Click;
            // 
            // btnPotatoes
            // 
            btnPotatoes.Location = new Point(22, 188);
            btnPotatoes.Name = "btnPotatoes";
            btnPotatoes.Size = new Size(170, 70);
            btnPotatoes.TabIndex = 5;
            btnPotatoes.Text = "Mashed Potatoes";
            btnPotatoes.UseVisualStyleBackColor = true;
            btnPotatoes.Click += btnPotatoes_Click;
            // 
            // btnSalad
            // 
            btnSalad.Location = new Point(22, 261);
            btnSalad.Name = "btnSalad";
            btnSalad.Size = new Size(170, 70);
            btnSalad.TabIndex = 6;
            btnSalad.Text = "Salad";
            btnSalad.UseVisualStyleBackColor = true;
            btnSalad.Click += btnSalad_Click;
            // 
            // btnRiceBeans
            // 
            btnRiceBeans.Location = new Point(22, 337);
            btnRiceBeans.Name = "btnRiceBeans";
            btnRiceBeans.Size = new Size(170, 70);
            btnRiceBeans.TabIndex = 7;
            btnRiceBeans.Text = "Rice and Beans";
            btnRiceBeans.UseVisualStyleBackColor = true;
            btnRiceBeans.Click += btnRiceBeans_Click;
            // 
            // btnFrenchFries
            // 
            btnFrenchFries.Location = new Point(22, 413);
            btnFrenchFries.Name = "btnFrenchFries";
            btnFrenchFries.Size = new Size(170, 70);
            btnFrenchFries.TabIndex = 8;
            btnFrenchFries.Text = "French Fries";
            btnFrenchFries.UseVisualStyleBackColor = true;
            btnFrenchFries.Click += btnFrenchFries_Click;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Segoe UI", 24F);
            lblOrder.Location = new Point(396, 55);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(97, 45);
            lblOrder.TabIndex = 9;
            lblOrder.Text = "order";
            lblOrder.Click += label1_Click_1;
            // 
            // lstvOrder
            // 
            lstvOrder.Columns.AddRange(new ColumnHeader[] { item, price });
            lstvOrder.Location = new Point(349, 112);
            lstvOrder.Name = "lstvOrder";
            lstvOrder.Size = new Size(205, 371);
            lstvOrder.TabIndex = 10;
            lstvOrder.UseCompatibleStateImageBehavior = false;
            lstvOrder.View = View.Details;
            // 
            // item
            // 
            item.Text = "item";
            item.Width = 100;
            // 
            // price
            // 
            price.Text = "price";
            price.Width = 100;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(360, 491);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 12;
            lblTotal.Click += lblTotal_Click;
            // 
            // button1
            // 
            button1.Location = new Point(198, 337);
            button1.Name = "button1";
            button1.Size = new Size(145, 146);
            button1.TabIndex = 13;
            button1.Text = "print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // lblTesting
            // 
            lblTesting.AutoSize = true;
            lblTesting.Location = new Point(431, 31);
            lblTesting.Name = "lblTesting";
            lblTesting.Size = new Size(0, 15);
            lblTesting.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 526);
            Controls.Add(lblTesting);
            Controls.Add(button1);
            Controls.Add(lblTotal);
            Controls.Add(lstvOrder);
            Controls.Add(lblOrder);
            Controls.Add(btnFrenchFries);
            Controls.Add(btnRiceBeans);
            Controls.Add(btnSalad);
            Controls.Add(btnPotatoes);
            Controls.Add(btnVegetables);
            Controls.Add(btnSalmon);
            Controls.Add(btnChicken);
            Controls.Add(btnSteak);
            Controls.Add(lblMesa);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMesa;
        private Button btnSteak;
        private Button btnChicken;
        private Button btnSalmon;
        private Button btnVegetables;
        private Button btnPotatoes;
        private Button btnSalad;
        private Button btnRiceBeans;
        private Button btnFrenchFries;
        private Label lblOrder;
        private ListView listView1;
        private ColumnHeader item;
        private ColumnHeader price;
        private ListView lstvOrder;
        private Label lblTotal;
        private Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label lblTesting;
    }
}