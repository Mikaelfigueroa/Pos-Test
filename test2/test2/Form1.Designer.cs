namespace test2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            tabble1 = new Button();
            tabble2 = new Button();
            tabble3 = new Button();
            tabble4 = new Button();
            printDialog2 = new PrintDialog();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // tabble1
            // 
            tabble1.Location = new Point(46, 44);
            tabble1.Name = "tabble1";
            tabble1.Size = new Size(188, 118);
            tabble1.TabIndex = 1;
            tabble1.Text = "tabble 1";
            tabble1.UseVisualStyleBackColor = true;
            tabble1.Click += button2_Click;
            // 
            // tabble2
            // 
            tabble2.Location = new Point(260, 44);
            tabble2.Name = "tabble2";
            tabble2.Size = new Size(188, 118);
            tabble2.TabIndex = 2;
            tabble2.Text = "tabble 2";
            tabble2.UseVisualStyleBackColor = true;
            tabble2.Click += button3_Click;
            // 
            // tabble3
            // 
            tabble3.Location = new Point(46, 184);
            tabble3.Name = "tabble3";
            tabble3.Size = new Size(188, 118);
            tabble3.TabIndex = 3;
            tabble3.Text = "tabble 3";
            tabble3.UseVisualStyleBackColor = true;
            tabble3.Click += button4_Click;
            // 
            // tabble4
            // 
            tabble4.Location = new Point(260, 184);
            tabble4.Name = "tabble4";
            tabble4.Size = new Size(188, 118);
            tabble4.TabIndex = 4;
            tabble4.Text = "tabble 4";
            tabble4.UseVisualStyleBackColor = true;
            tabble4.Click += tabble4_Click;
            // 
            // printDialog2
            // 
            printDialog2.UseEXDialog = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 371);
            Controls.Add(tabble4);
            Controls.Add(tabble3);
            Controls.Add(tabble2);
            Controls.Add(tabble1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button tabble1;
        private Button tabble2;
        private Button tabble3;
        private Button tabble4;
        private PrintDialog printDialog2;
    }
}
