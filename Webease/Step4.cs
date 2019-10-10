/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
///  WebEase Application - Step4 Class (Add Pages)
///  Step 4 is used to add any amount of web pages with different
///  content to the website. Each sub-step of Step 4 is just a new
///  Step 4 control derived from the Wizard class.
/// </summary>

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WebEase
{
	public class Step4 : Wizard.WizardPage
	{
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Label labelPage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textExtraHead;
		private System.Windows.Forms.TextBox textExtraBody;
		private System.Windows.Forms.TextBox textExtraTitle;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components = null;

		public Step4()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			// Clean up any resources being used.
			if (disposing && (components != null)) components.Dispose();
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Step4));
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.btnNew = new System.Windows.Forms.Button();
			this.labelPage = new System.Windows.Forms.Label();
			this.textExtraBody = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textExtraHead = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textExtraTitle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.Transparent;
			this.labelTitle.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(16, 16);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(368, 32);
			this.labelTitle.TabIndex = 10;
			this.labelTitle.Text = "Add Pages";
			// 
			// labelDescription
			// 
			this.labelDescription.BackColor = System.Drawing.Color.Transparent;
			this.labelDescription.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDescription.Location = new System.Drawing.Point(16, 64);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(368, 152);
			this.labelDescription.TabIndex = 12;
			this.labelDescription.Text = "Here you can add as many extra pages as you would like to your website. Each page" +
				" can be completely different, but should match the same style as your home page." +
				" Don\'t worry about linking everything together. WebEase will take care of it.";
			// 
			// btnNew
			// 
			this.btnNew.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnNew.ForeColor = System.Drawing.Color.White;
			this.btnNew.Location = new System.Drawing.Point(528, 320);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(144, 48);
			this.btnNew.TabIndex = 3;
			this.btnNew.Text = "&New Page";
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// labelPage
			// 
			this.labelPage.BackColor = System.Drawing.Color.Transparent;
			this.labelPage.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPage.Location = new System.Drawing.Point(408, 400);
			this.labelPage.Name = "labelPage";
			this.labelPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.labelPage.Size = new System.Drawing.Size(368, 24);
			this.labelPage.TabIndex = 13;
			this.labelPage.Text = "Page ";
			// 
			// textExtraBody
			// 
			this.textExtraBody.Location = new System.Drawing.Point(536, 176);
			this.textExtraBody.Multiline = true;
			this.textExtraBody.Name = "textExtraBody";
			this.textExtraBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textExtraBody.Size = new System.Drawing.Size(240, 128);
			this.textExtraBody.TabIndex = 2;
			this.textExtraBody.Text = "";
			this.textExtraBody.TextChanged += new System.EventHandler(this.textExtraBody_TextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(416, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 20;
			this.label2.Text = "Body:";
			// 
			// textExtraHead
			// 
			this.textExtraHead.Location = new System.Drawing.Point(536, 120);
			this.textExtraHead.Name = "textExtraHead";
			this.textExtraHead.Size = new System.Drawing.Size(240, 20);
			this.textExtraHead.TabIndex = 1;
			this.textExtraHead.Text = "";
			this.textExtraHead.TextChanged += new System.EventHandler(this.textExtraHead_TextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(416, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 19;
			this.label1.Text = "Headline:";
			// 
			// textExtraTitle
			// 
			this.textExtraTitle.Location = new System.Drawing.Point(536, 64);
			this.textExtraTitle.Name = "textExtraTitle";
			this.textExtraTitle.Size = new System.Drawing.Size(240, 20);
			this.textExtraTitle.TabIndex = 0;
			this.textExtraTitle.Text = "";
			this.textExtraTitle.TextChanged += new System.EventHandler(this.textExtraTitle_TextChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(416, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 22;
			this.label3.Text = "Title:";
			// 
			// Step4
			// 
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.textExtraTitle);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textExtraBody);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textExtraHead);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelPage);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelTitle);
			this.Name = "Step4";
			this.Size = new System.Drawing.Size(792, 440);
			this.Load += new System.EventHandler(this.Step4_Load);
			this.ResumeLayout(false);

		}
		#endregion

		// Precondition: Step 4 is loaded
		// Postcondition: Update the page counter
		private void Step4_Load(object sender, System.EventArgs e)
		{
			labelPage.Text += Wizard.WizardSheet.myPages.Count - 4;
			Program.arrayExtraTitle.Add("");
			Program.arrayExtraHead.Add("");
			Program.arrayExtraBody.Add("");
		}

		// Precondition: User clicked the new page button
		// Postcondition: Create a new instance of Step4
		private void btnNew_Click(object sender, System.EventArgs e)
		{
			Program.wizard.Pages.Add(new Step4());
			Program.wizard.currentPage++;
			Program.wizard.SetActivePage(Wizard.WizardSheet.myPages.Count - 1);
		}

		#region Update Wizard Parameters
		private void textExtraTitle_TextChanged(object sender, System.EventArgs e)
		{
			// Add new title to the array
			Program.arrayExtraTitle[Wizard.WizardSheet.myPages.Count - 5] = textExtraTitle.Text;
		}

		private void textExtraHead_TextChanged(object sender, System.EventArgs e)
		{
			// Add new header to the array
			Program.arrayExtraHead[Wizard.WizardSheet.myPages.Count - 5] = textExtraHead.Text;
		}

		private void textExtraBody_TextChanged(object sender, System.EventArgs e)
		{
			// Add new body to the array
			Program.arrayExtraBody[Wizard.WizardSheet.myPages.Count - 5] = textExtraBody.Text;
		}
		#endregion

	}
}
