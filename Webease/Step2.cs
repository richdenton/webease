/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
/// WebEase Application - Step2 Class (Template Selection)
/// Step 2 is where the user is allowed to choose a template for their
/// project. Templates are located in the "WebEase\Templates" directory
/// and require a [name].css file as well as a [name]-preview.jpg file,
/// which is a 360x304 pixel preview image of the template in use.
/// </summary>

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WebEase
{
	public class Step2 : Wizard.WizardPage
	{
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboTemplate;
		private System.Windows.Forms.PictureBox pictureTemplate;
		private System.Windows.Forms.Label labelHelp1;
		private System.Windows.Forms.Label labelHelp2;
		private System.ComponentModel.IContainer components = null;

		public Step2()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Step2));
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.comboTemplate = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureTemplate = new System.Windows.Forms.PictureBox();
			this.labelHelp1 = new System.Windows.Forms.Label();
			this.labelHelp2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelDescription
			// 
			this.labelDescription.BackColor = System.Drawing.Color.Transparent;
			this.labelDescription.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDescription.Location = new System.Drawing.Point(16, 64);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(368, 152);
			this.labelDescription.TabIndex = 4;
			this.labelDescription.Text = @"Templates change the look and feel of your website. Choose the design you like the best, but make sure it fits the style your website is trying to convey. Also be sure to check out the WebEase home page to download new templates created by users just like you.";
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.Transparent;
			this.labelTitle.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(16, 16);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(368, 32);
			this.labelTitle.TabIndex = 6;
			this.labelTitle.Text = "Template Selection";
			// 
			// comboTemplate
			// 
			this.comboTemplate.Items.AddRange(new object[] {
															   "Default"});
			this.comboTemplate.Location = new System.Drawing.Point(536, 64);
			this.comboTemplate.Name = "comboTemplate";
			this.comboTemplate.Size = new System.Drawing.Size(240, 21);
			this.comboTemplate.TabIndex = 0;
			this.comboTemplate.SelectedIndexChanged += new System.EventHandler(this.comboTemplate_SelectedIndexChanged);
			this.comboTemplate.SelectionChangeCommitted += new System.EventHandler(this.comboTemplate_SelectionChangeCommitted);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(416, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 13;
			this.label1.Text = "Template:";
			// 
			// pictureTemplate
			// 
			this.pictureTemplate.BackColor = System.Drawing.Color.Transparent;
			this.pictureTemplate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureTemplate.Location = new System.Drawing.Point(416, 120);
			this.pictureTemplate.Name = "pictureTemplate";
			this.pictureTemplate.Size = new System.Drawing.Size(360, 304);
			this.pictureTemplate.TabIndex = 14;
			this.pictureTemplate.TabStop = false;
			// 
			// labelHelp1
			// 
			this.labelHelp1.BackColor = System.Drawing.Color.Transparent;
			this.labelHelp1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHelp1.Location = new System.Drawing.Point(24, 240);
			this.labelHelp1.Name = "labelHelp1";
			this.labelHelp1.Size = new System.Drawing.Size(352, 24);
			this.labelHelp1.TabIndex = 16;
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
			this.labelHelp2.TabIndex = 15;
			// 
			// Step2
			// 
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.labelHelp1);
			this.Controls.Add(this.labelHelp2);
			this.Controls.Add(this.pictureTemplate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboTemplate);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.labelDescription);
			this.Name = "Step2";
			this.Size = new System.Drawing.Size(792, 440);
			this.Load += new System.EventHandler(this.Step2_Load);
			this.ResumeLayout(false);

		}
		#endregion


		// Precondition: User selected a template from the list
		// Postconditon: Update the help details
		private void comboTemplate_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			switch (comboTemplate.SelectedIndex)
			{
				case 0:
					labelHelp1.Text = "Default Theme";
					labelHelp2.Text = "\n\n";
					labelHelp2.Text += "Created by WebEase on April 17, 2006\n\n";
					labelHelp2.Text += "This is the default theme for WebEase. If you are looking for a simple, no-frills website, then this is for you.";
					break;
			};
		}

		// Precondition: Template selection is changed
		// Postcondition: Update the preview
		private void comboTemplate_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Program.stringTemplate = comboTemplate.Text;
			pictureTemplate.Image = Image.FromFile(Application.StartupPath + "\\templates\\" + comboTemplate.Text.ToLower() + "-preview.jpg");
		}

		// Precondition: Step 2 is loaded
		// Postcondition: Set default templated as selected
		private void Step2_Load(object sender, System.EventArgs e)
		{
			comboTemplate.SelectedText = Program.stringTemplate;
			comboTemplate_SelectionChangeCommitted(sender, e);
		}
	}
}