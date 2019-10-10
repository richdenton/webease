/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
///  WebEase Application - Step3 Class (Home Page Details)
///  Step 3 contains the main content of the website. Here, the user has
///  the ability to input numerous headers and bodies of text which will
///  appear on the website's home page (index.html).
/// </summary>

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WebEase
{
	public class Step3 : Wizard.WizardPage
	{
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textHeadline1;
		private System.Windows.Forms.TextBox textBody1;
		private System.Windows.Forms.TextBox textHeadline2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBody2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelHelp1;
		private System.Windows.Forms.Label labelHelp2;
		private System.ComponentModel.IContainer components = null;

		public Step3()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Step3));
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textHeadline1 = new System.Windows.Forms.TextBox();
			this.textBody1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textHeadline2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBody2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.labelHelp1 = new System.Windows.Forms.Label();
			this.labelHelp2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.Transparent;
			this.labelTitle.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(16, 16);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(368, 32);
			this.labelTitle.TabIndex = 9;
			this.labelTitle.Text = "Home Page Details";
			// 
			// labelDescription
			// 
			this.labelDescription.BackColor = System.Drawing.Color.Transparent;
			this.labelDescription.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDescription.Location = new System.Drawing.Point(16, 64);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(368, 152);
			this.labelDescription.TabIndex = 10;
			this.labelDescription.Text = "Your home page is where visitors will first enter when visiting your website. Thi" +
				"s is where the basics of your site are explained and links to the rest of your p" +
				"ages can be found.";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(416, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 14;
			this.label1.Text = "Headline #1:";
			// 
			// textHeadline1
			// 
			this.textHeadline1.Location = new System.Drawing.Point(536, 64);
			this.textHeadline1.Name = "textHeadline1";
			this.textHeadline1.Size = new System.Drawing.Size(240, 20);
			this.textHeadline1.TabIndex = 0;
			this.textHeadline1.Text = "";
			this.textHeadline1.TextChanged += new System.EventHandler(this.textHeadline1_TextChanged);
			this.textHeadline1.Enter += new System.EventHandler(this.textHeadline_Enter);
			// 
			// textBody1
			// 
			this.textBody1.Location = new System.Drawing.Point(536, 120);
			this.textBody1.Multiline = true;
			this.textBody1.Name = "textBody1";
			this.textBody1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBody1.Size = new System.Drawing.Size(240, 72);
			this.textBody1.TabIndex = 1;
			this.textBody1.Text = "";
			this.textBody1.TextChanged += new System.EventHandler(this.textBody1_TextChanged);
			this.textBody1.Enter += new System.EventHandler(this.textBody_Enter);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(416, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 16;
			this.label2.Text = "Body #1:";
			// 
			// textHeadline2
			// 
			this.textHeadline2.Location = new System.Drawing.Point(536, 224);
			this.textHeadline2.Name = "textHeadline2";
			this.textHeadline2.Size = new System.Drawing.Size(240, 20);
			this.textHeadline2.TabIndex = 2;
			this.textHeadline2.Text = "";
			this.textHeadline2.TextChanged += new System.EventHandler(this.textHeadline2_TextChanged);
			this.textHeadline2.Enter += new System.EventHandler(this.textHeadline_Enter);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(416, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 18;
			this.label3.Text = "Headline #2:";
			// 
			// textBody2
			// 
			this.textBody2.Location = new System.Drawing.Point(536, 280);
			this.textBody2.Multiline = true;
			this.textBody2.Name = "textBody2";
			this.textBody2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBody2.Size = new System.Drawing.Size(240, 72);
			this.textBody2.TabIndex = 3;
			this.textBody2.Text = "";
			this.textBody2.TextChanged += new System.EventHandler(this.textBody2_TextChanged);
			this.textBody2.Enter += new System.EventHandler(this.textBody_Enter);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(416, 280);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 24);
			this.label4.TabIndex = 20;
			this.label4.Text = "Body #2:";
			// 
			// labelHelp1
			// 
			this.labelHelp1.BackColor = System.Drawing.Color.Transparent;
			this.labelHelp1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHelp1.Location = new System.Drawing.Point(24, 240);
			this.labelHelp1.Name = "labelHelp1";
			this.labelHelp1.Size = new System.Drawing.Size(352, 24);
			this.labelHelp1.TabIndex = 22;
			this.labelHelp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelHelp2
			// 
			this.labelHelp2.BackColor = System.Drawing.Color.Transparent;
			this.labelHelp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHelp2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHelp2.Location = new System.Drawing.Point(16, 232);
			this.labelHelp2.Name = "labelHelp2";
			this.labelHelp2.Size = new System.Drawing.Size(368, 152);
			this.labelHelp2.TabIndex = 21;
			// 
			// Step3
			// 
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.labelHelp1);
			this.Controls.Add(this.labelHelp2);
			this.Controls.Add(this.textBody2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textHeadline2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBody1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textHeadline1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelTitle);
			this.Name = "Step3";
			this.Size = new System.Drawing.Size(792, 440);
			this.Enter += new System.EventHandler(this.Step3_Enter);
			this.Leave += new System.EventHandler(this.Step3_Leave);
			this.ResumeLayout(false);

		}
		#endregion

		#region Help Section
		// Precondition: User selected a headline text box
		// Postcondition: Update the help labels
		private void textHeadline_Enter(object sender, System.EventArgs e)
		{
			labelHelp1.Text = "Headline";
			labelHelp2.Text = "\n\n";
			labelHelp2.Text += "Your home page is where a lot of content for your website will be placed. Headlines seperate the bodies of text to accomplish this. You may use anything as your headline and body combinations: news, updates, about yourself, etc. This property is required.";
		}

		// Precondition: User selected a body text box
		// Postcondition: Update the help labels
		private void textBody_Enter(object sender, System.EventArgs e)
		{
			labelHelp1.Text = "Body";
			labelHelp2.Text = "\n\n";
			labelHelp2.Text += "Your home page is where a lot of content for your website will be placed. The bodies of your website will be seperated by headlines. You may use anything as your headline and body combinations: news, updates, about yourself, etc. This property is required.";
		}

		// Precondition: User left the step area
		// Postcondition: Clear the help labels
		private void Step3_Leave(object sender, System.EventArgs e)
		{
			labelHelp1.Text = "";
			labelHelp2.Text = "";
		}
		#endregion

		#region Update Wizard Parameters
		private void textHeadline1_TextChanged(object sender, System.EventArgs e)
		{
			// Update the headline
			Program.stringHeadline1 = textHeadline1.Text;
		}

		private void textBody1_TextChanged(object sender, System.EventArgs e)
		{
			// Update the body
			Program.stringBody1 = textBody1.Text;
		}

		private void textHeadline2_TextChanged(object sender, System.EventArgs e)
		{
			// Update the headline
			Program.stringHeadline2 = textHeadline2.Text;
		}

		private void textBody2_TextChanged(object sender, System.EventArgs e)
		{
			// Update the body
			Program.stringBody2 = textBody2.Text;
		}
		#endregion

		
		// Precondition: Step 3 is entered
		// Postcondition: Set initialze values
		private void Step3_Enter(object sender, System.EventArgs e)
		{
			textHeadline1.Text = Program.stringHeadline1;
			textBody1.Text = Program.stringBody1;
			textHeadline2.Text = Program.stringHeadline2;
			textBody2.Text = Program.stringBody2;
		}
	}
}