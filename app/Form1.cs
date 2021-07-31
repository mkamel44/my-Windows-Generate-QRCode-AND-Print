using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.Barcode;

namespace Barcode_Scanner_Generator_C_Sharp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		BarcodeEncoder Generator;
		BarcodeDecoder Scanner;
		SaveFileDialog SD;
		OpenFileDialog OD;
		Bitmap bitmap;
		
		private void button2_Click(object sender, EventArgs e)
		{
        
			Generator = new BarcodeEncoder();
			Generator.IncludeLabel = true;
			Generator.CustomLabel = textBox1.Text;
			
			if (textBox1.Text != "") {
				pictureBox1.Image = new Bitmap(Generator.Encode(BarcodeFormat.QRCode, textBox1.Text));
				label2.Text = textBox1.Text;
				label3.Text = textBox2.Text;
			}
            
			
		}
		
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(Pens.Red,
				e.ClipRectangle.Left,
				e.ClipRectangle.Top,
				e.ClipRectangle.Width - 2,
				e.ClipRectangle.Height - 2);
			base.OnPaint(e);
		}


		private void button3_Click(object sender, EventArgs e)
		{
			SD = new SaveFileDialog();
			SD.Filter = "PNG File|*.png";
			if (SD.ShowDialog() == DialogResult.OK) {
				
				using (Bitmap bitmap = new Bitmap(panel1.ClientSize.Width, 
					                       panel1.ClientSize.Height)) {
					panel1.DrawToBitmap(bitmap, panel1.ClientRectangle);
					bitmap.Save(SD.FileName, System.Drawing.Imaging.ImageFormat.Png);
				}
				
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
	
			Graphics grp = panel1.CreateGraphics();	

			bitmap = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height, grp);
			
			panel1.DrawToBitmap(bitmap, panel1.ClientRectangle);

			Point panelLocation = PointToScreen(panel1.Location);
			
			grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, panel1.ClientSize);

			printPreviewDialog1.Document = printDocument1;
			
			printPreviewDialog1.PrintPreviewControl.Zoom = 1;
			
			printPreviewDialog1.ShowDialog();
		}
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
	
			e.Graphics.DrawImage(bitmap, 15, 15);
		}
		
	}
}
