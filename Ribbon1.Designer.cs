namespace AdvancedCalculator
{
	partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Ribbon1()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tab1 = this.Factory.CreateRibbonTab();
			this.Calculator = this.Factory.CreateRibbonGroup();
			this.toggleButton1 = this.Factory.CreateRibbonToggleButton();
			this.buttonDownload = this.Factory.CreateRibbonButton();
			this.buttonSave = this.Factory.CreateRibbonButton();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tab1.SuspendLayout();
			this.Calculator.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.Calculator);
			this.tab1.Label = "TabAddIns";
			this.tab1.Name = "tab1";
			// 
			// Calculator
			// 
			this.Calculator.Items.Add(this.toggleButton1);
			this.Calculator.Items.Add(this.buttonDownload);
			this.Calculator.Items.Add(this.buttonSave);
			this.Calculator.Label = "Calculator";
			this.Calculator.Name = "Calculator";
			// 
			// toggleButton1
			// 
			this.toggleButton1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.toggleButton1.Image = global::AdvancedCalculator.Resource1.icons8_calculator_32;
			this.toggleButton1.Label = "ON";
			this.toggleButton1.Name = "toggleButton1";
			this.toggleButton1.ShowImage = true;
			this.toggleButton1.SuperTip = "Show/hide the calculator pane";
			this.toggleButton1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.toggleButton1_Click);
			// 
			// buttonDownload
			// 
			this.buttonDownload.Enabled = false;
			this.buttonDownload.Image = global::AdvancedCalculator.Resource1.download1;
			this.buttonDownload.Label = "Download";
			this.buttonDownload.Name = "buttonDownload";
			this.buttonDownload.ShowImage = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Enabled = false;
			this.buttonSave.Image = global::AdvancedCalculator.Resource1.Save11;
			this.buttonSave.Label = "Save to...";
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.ShowImage = true;
			this.buttonSave.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
			// 
			// Ribbon1
			// 
			this.Name = "Ribbon1";
			this.RibbonType = "Microsoft.Excel.Workbook";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.Calculator.ResumeLayout(false);
			this.Calculator.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup Calculator;
		internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonDownload;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSave;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}

	partial class ThisRibbonCollection
	{
		internal Ribbon1 Ribbon1
		{
			get { return this.GetRibbon<Ribbon1>(); }
		}
	}
}
