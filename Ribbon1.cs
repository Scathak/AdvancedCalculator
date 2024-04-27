using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedCalculator
{
	public partial class Ribbon1
	{
		private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
		{
		}

		private void toggleButton1_Click(object sender, RibbonControlEventArgs e) {
			
			var workBook = Globals.ThisAddIn.Application.ActiveWorkbook;
			var workbookName = "";
			if (workBook != null){
				workbookName = workBook.Name;
			}
			if (workbookName != "MSFT.xls") return;
			
			if (toggleButton1.Checked) {
				toggleButton1.Label = "OFF";
				Globals.ThisAddIn.taskPaneObject.Visible = true;
				buttonDownload.Enabled = true;
				buttonSave.Enabled = true;
			} else { 
				toggleButton1.Label = "ON";
				Globals.ThisAddIn.taskPaneObject.Visible = false;
				buttonDownload.Enabled = false;
				buttonSave.Enabled = false;
			}
		}

		private void button2_Click(object sender, RibbonControlEventArgs e)
		{
			saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
			saveFileDialog1.Title = "Save an Image File";
			saveFileDialog1.ShowDialog();

			// If the file name is not an empty string open it for saving.
			if (saveFileDialog1.FileName != "")
			{
				// Saves the Image via a FileStream created by the OpenFile method.
				System.IO.FileStream fs =
					(System.IO.FileStream)saveFileDialog1.OpenFile();
				// Saves the Image in the appropriate ImageFormat based upon the
				// File type selected in the dialog box.
				// NOTE that the FilterIndex property is one-based.
				switch (saveFileDialog1.FilterIndex)
				{
					case 1:
						this.buttonSave.Image.Save(fs,
						  System.Drawing.Imaging.ImageFormat.Jpeg);
						break;

					case 2:
						this.buttonSave.Image.Save(fs,
						  System.Drawing.Imaging.ImageFormat.Bmp);
						break;

					case 3:
						this.buttonSave.Image.Save(fs,
						  System.Drawing.Imaging.ImageFormat.Gif);
						break;
				}

				fs.Close();
			}
		}
	}
}
