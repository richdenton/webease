/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
///  WebEase Application - Step1 Class (Basic Settings)
///  Step 1 is the actual first step of the WebEase wizard. Here is where
///  general project settings (such as title and description) are set by
///  the user.
/// </summary>

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WebEase
{
	public class Step1 : Wizard.WizardPage
	{
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelDescription;
		public System.Windows.Forms.TextBox textTitle;
		public System.Windows.Forms.TextBox textDescription;
		private System.Windows.Forms.Label labelHelp2;
		private System.Windows.Forms.Label labelHelp1;
		public System.Windows.Forms.TextBox textKeywords;
		public System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public Step1()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Step1));
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textTitle = new System.Windows.Forms.TextBox();
			this.textDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.labelHelp2 = new System.Windows.Forms.Label();
			this.labelHelp1 = new System.Windows.Forms.Label();
			this.textKeywords = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.Transparent;
			this.labelTitle.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(16, 16);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(368, 32);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Basic Settings";
			// 
			// labelDescription
			// 
			this.labelDescription.BackColor = System.Drawing.Color.Transparent;
			this.labelDescription.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDescription.Location = new System.Drawing.Point(16, 64);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(368, 152);
			this.labelDescription.TabIndex = 1;
			this.labelDescription.Text = "Welcome to WebEase! To begin creating a website, the wizard needs to know some ba" +
				"sics about your idea. Not all of the fields on this step are required for your p" +
				"roject to be displayed correctly, but they are recommended.";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(416, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Project Title:";
			// 
			// textTitle
			// 
			this.textTitle.Location = new System.Drawing.Point(536, 120);
			this.textTitle.Name = "textTitle";
			this.textTitle.Size = new System.Drawing.Size(240, 20);
			this.textTitle.TabIndex = 1;
			this.textTitle.Text = "";
			this.textTitle.TextChanged += new System.EventHandler(this.textTitle_TextChanged);
			this.textTitle.Enter += new System.EventHandler(this.textTitle_Enter);
			// 
			// textDescription
			// 
			this.textDescription.Location = new System.Drawing.Point(536, 176);
			this.textDescription.Multiline = true;
			this.textDescription.Name = "textDescription";
			this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textDescription.Size = new System.Drawing.Size(240, 72);
			this.textDescription.TabIndex = 2;
			this.textDescription.Text = "";
			this.textDescription.TextChanged += new System.EventHandler(this.textDescription_TextChanged);
			this.textDescription.Enter += new System.EventHandler(this.textDescription_Enter);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(416, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Description:";
			// 
			// labelHelp2
			// 
			this.labelHelp2.BackColor = System.Drawing.Color.Transparent;
			this.labelHelp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHelp2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHelp2.Location = new System.Drawing.Point(16, 232);
			this.labelHelp2.Name = "labelHelp2";
			this.labelHelp2.Size = new System.Drawing.Size(368, 152);
			this.labelHelp2.TabIndex = 8;
			// 
			// labelHelp1
			// 
			this.labelHelp1.BackColor = System.Drawing.Color.Transparent;
			this.labelHelp1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHelp1.Location = new System.Drawing.Point(24, 240);
			this.labelHelp1.Name = "labelHelp1";
			this.labelHelp1.Size = new System.Drawing.Size(352, 24);
			this.labelHelp1.TabIndex = 9;
			this.labelHelp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textKeywords
			// 
			this.textKeywords.Location = new System.Drawing.Point(536, 280);
			this.textKeywords.Multiline = true;
			this.textKeywords.Name = "textKeywords";
			this.textKeywords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textKeywords.Size = new System.Drawing.Size(240, 72);
			this.textKeywords.TabIndex = 3;
			this.textKeywords.Text = "";
			this.textKeywords.TextChanged += new System.EventHandler(this.textKeywords_TextChanged);
			this.textKeywords.Enter += new System.EventHandler(this.textKeywords_Enter);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(416, 280);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "Keywords:";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(536, 64);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(240, 20);
			this.textName.TabIndex = 0;
			this.textName.Text = "";
			this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
			this.textName.Enter += new System.EventHandler(this.textName_Enter);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(416, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 12;
			this.label1.Text = "Your Name:";
			// 
			// Step1
			// 
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textKeywords);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelHelp1);
			this.Controls.Add(this.labelHelp2);
			this.Controls.Add(this.textDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelTitle);
			this.Name = "Step1";
			this.Size = new System.Drawing.Size(792, 440);
			this.Enter += new System.EventHandler(this.Step1_Enter);
			this.Leave += new System.EventHandler(this.Step1_Leave);
			this.ResumeLayout(false);

		}
		#endregion

		#region Help Section
		// Precondition: User selected the keywords text box
		// Postcondition: Update the help labels
		private void textName_Enter(object sender, System.EventArgs e)
		{
			labelHelp1.Text = "Your Name";
			labelHelp2.Text = "\n\n";
			labelHelp2.Text += "As the creator of this website, your name will be placed on the bottom of every page in your website. This property is required.";
		}

		// Precondition: User selected the project title text box
		// Postcondition: Update the help labels
		private void textTitle_Enter(object sender, System.EventArgs e)
		{
			labelHelp1.Text = "Project Title";
			labelHelp2.Text = "\n\n";
			labelHelp2.Text += "The title of your project is very important as it is displayed at the top of the browser window when viewed online and helps to differentiate your website from others. This property is required.";
		}

		// Precondition: User selected the description text box
		// Postcondition: Update the help labels
		private void textDescription_Enter(object sender, System.EventArgs e)
		{
			labelHelp1.Text = "Description";
			labelHelp2.Text = "\n\n";
			labelHelp2.Text += "The description is a short phrase or comment about your site. Visitors to your website do not see this information as it is hidden on your home page. Search engines use these details to find your website on the internet. This property is optional.";
		}

		// Precondition: User selected the keywords text box
		// Postcondition: Update the help labels
		private void textKeywords_Enter(object sender, System.EventArgs e)
		{
			labelHelp1.Text = "Keywords";
			labelHelp2.Text = "\n\n";
			labelHelp2.Text += "List common keywords that represent yout website here seperated by commas. For example, if your website were about beekeeping, your keywords might include \"beehive, honey, queen.\" These keywords are only visible to search engines to help visitors find your website online. This property is optional.";
		}

		// Precondition: User left the step area
		// Postcondition: Clear the help labels
		private void Step1_Leave(object sender, System.EventArgs e)
		{
			labelHelp1.Text = "";
			labelHelp2.Text = "";
		}
		#endregion

		#region Update Wizard Parameters
		private void textName_TextChanged(object sender, System.EventArgs e)
		{
			// Update the user name
			Program.stringName = textName.Text;
		}

		private void textTitle_TextChanged(object sender, System.EventArgs e)
		{
			// Update the project title
			Program.stringTitle = textTitle.Text;
		}

		private void textDescription_TextChanged(object sender, System.EventArgs e)
		{
			// Update the description
			Program.stringDescription = textDescription.Text;
		}

		private void textKeywords_TextChanged(object sender, System.EventArgs e)
		{
			// Update the keywords
			Program.stringKeywords = textKeywords.Text;
		}
		#endregion

		// Precondition: Step 1 is entered
		// Postcondition: Set initialze values
		private void Step1_Enter(object sender, System.EventArgs e)
		{
			textName.Text = Program.stringName;
			textTitle.Text = Program.stringTitle;
			textDescription.Text = Program.stringDescription;
			textKeywords.Text = Program.stringKeywords;
		}
	}
}

