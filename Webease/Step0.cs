/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
///  WebEase Application - Step0 Class (Welcome Page)
///  Step 0 is the screen the user first sees when entering WebEase. It allows
///  the user to open an existing project or create a new one as well as locks
///  the wizard controls until one of those options is chosen.
/// </summary>

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WebEase;

namespace WebEase
{
	public class Step0 : Wizard.WizardPage
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkNew;
		private System.Windows.Forms.LinkLabel linkOpen;
		private System.ComponentModel.IContainer components = null;

		public Step0()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			// Clean up any resources being used.
			if (disposing  && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.linkNew = new System.Windows.Forms.LinkLabel();
			this.linkOpen = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(760, 72);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please create a (new project) or (open) an existing one.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkNew
			// 
			this.linkNew.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkNew.Location = new System.Drawing.Point(304, 176);
			this.linkNew.Name = "linkNew";
			this.linkNew.Size = new System.Drawing.Size(104, 88);
			this.linkNew.TabIndex = 1;
			this.linkNew.TabStop = true;
			this.linkNew.Text = "new project";
			this.linkNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNew_LinkClicked);
			// 
			// linkOpen
			// 
			this.linkOpen.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkOpen.Location = new System.Drawing.Point(432, 176);
			this.linkOpen.Name = "linkOpen";
			this.linkOpen.Size = new System.Drawing.Size(48, 88);
			this.linkOpen.TabIndex = 2;
			this.linkOpen.TabStop = true;
			this.linkOpen.Text = "open";
			this.linkOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOpen_LinkClicked);
			// 
			// Step0
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.linkOpen);
			this.Controls.Add(this.linkNew);
			this.Controls.Add(this.label1);
			this.Name = "Step0";
			this.Size = new System.Drawing.Size(792, 440);
			this.ResumeLayout(false);

		}
		#endregion

		// Precondition: User clicked the new link
		// Postcondition: Run the WizardSheet new button function
		private void linkNew_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Program.newProject();
		}

		// Precondition: User clicked the open link
		// Postcondition: Run the WizardSheet open button function
		private void linkOpen_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Program.openProject();
		}
	}
}

