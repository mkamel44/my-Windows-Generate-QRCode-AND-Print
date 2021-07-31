namespace Barcode_Scanner_Generator_C_Sharp
{
    partial class Form1
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
        	this.printDocument1 = new System.Drawing.Printing.PrintDocument();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.panel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.pictureBox1.Location = new System.Drawing.Point(14, 13);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(140, 127);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        	this.pictureBox1.TabIndex = 0;
        	this.pictureBox1.TabStop = false;
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(34, 174);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(344, 20);
        	this.textBox1.TabIndex = 1;
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(167, 226);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(75, 23);
        	this.button2.TabIndex = 3;
        	this.button2.Text = "Generate";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(248, 226);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(75, 23);
        	this.button3.TabIndex = 4;
        	this.button3.Text = "Save";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Click += new System.EventHandler(this.button3_Click);
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
        	this.panel1.Controls.Add(this.label3);
        	this.panel1.Controls.Add(this.label4);
        	this.panel1.Controls.Add(this.label2);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Controls.Add(this.pictureBox1);
        	this.panel1.Location = new System.Drawing.Point(34, 12);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(344, 156);
        	this.panel1.TabIndex = 6;
        	this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
        	// 
        	// label3
        	// 
        	this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(160, 100);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(170, 31);
        	this.label3.TabIndex = 4;
        	// 
        	// label4
        	// 
        	this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(160, 73);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(170, 23);
        	this.label4.TabIndex = 3;
        	this.label4.Text = "Adjective :";
        	// 
        	// label2
        	// 
        	this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(160, 40);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(170, 30);
        	this.label2.TabIndex = 2;
        	// 
        	// label1
        	// 
        	this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(160, 13);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(170, 23);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Name :";
        	// 
        	// textBox2
        	// 
        	this.textBox2.Location = new System.Drawing.Point(34, 200);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.Size = new System.Drawing.Size(344, 20);
        	this.textBox2.TabIndex = 2;
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(86, 226);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(75, 23);
        	this.button1.TabIndex = 7;
        	this.button1.Text = "print";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// printPreviewDialog1
        	// 
        	this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
        	this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
        	this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
        	this.printPreviewDialog1.Enabled = true;
        	this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
        	this.printPreviewDialog1.Name = "printPreviewDialog1";
        	this.printPreviewDialog1.Visible = false;
        	// 
        	// printDocument1
        	// 
        	this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(418, 255);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.textBox2);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.textBox1);
        	this.Name = "Form1";
        	this.Text = "Barcode Generator Scanner";
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.panel1.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

