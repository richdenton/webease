/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
///  Wizard Library - About Class
///  This class displays the about box window for WebEase.
/// </summary>

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Wizard
{
	public class About : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.PictureBox pictureLogo;
		private System.Windows.Forms.LinkLabel linkWebsite;
		private System.Windows.Forms.TextBox textAbout;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.TextBox textTeam;
		private System.Windows.Forms.PictureBox pictureIcon;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		public About()
		{
			// Required for Windows Form Designer support
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			// Clean up any resources being used.
			if (disposing && (components != null)) components.Dispose();
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(About));
			this.buttonClose = new System.Windows.Forms.Button();
			this.pictureLogo = new System.Windows.Forms.PictureBox();
			this.linkWebsite = new System.Windows.Forms.LinkLabel();
			this.textAbout = new System.Windows.Forms.TextBox();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.textTeam = new System.Windows.Forms.TextBox();
			this.pictureIcon = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(8, 312);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(72, 32);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "&Close";
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// pictureLogo
			// 
			this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
			this.pictureLogo.Location = new System.Drawing.Point(8, 8);
			this.pictureLogo.Name = "pictureLogo";
			this.pictureLogo.Size = new System.Drawing.Size(75, 300);
			this.pictureLogo.TabIndex = 2;
			this.pictureLogo.TabStop = false;
			// 
			// linkWebsite
			// 
			this.linkWebsite.Location = new System.Drawing.Point(88, 312);
			this.linkWebsite.Name = "linkWebsite";
			this.linkWebsite.Size = new System.Drawing.Size(312, 32);
			this.linkWebsite.TabIndex = 3;
			this.linkWebsite.TabStop = true;
			this.linkWebsite.Text = "Visit us online at http://www.kagedkoncepts.com!";
			this.linkWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebsite_LinkClicked);
			// 
			// textAbout
			// 
			this.textAbout.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textAbout.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textAbout.Location = new System.Drawing.Point(96, 8);
			this.textAbout.Multiline = true;
			this.textAbout.Name = "textAbout";
			this.textAbout.ReadOnly = true;
			this.textAbout.Size = new System.Drawing.Size(304, 32);
			this.textAbout.TabIndex = 4;
			this.textAbout.Text = "WebEase (Retail) 1.0\r\nCreated by Kaged Koncepts";
			// 
			// labelCopyright
			// 
			this.labelCopyright.Location = new System.Drawing.Point(96, 288);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(304, 16);
			this.labelCopyright.TabIndex = 5;
			this.labelCopyright.Text = "Copyright ©2006 Kaged Koncepts. All right reserved.";
			this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textTeam
			// 
			this.textTeam.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textTeam.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textTeam.Location = new System.Drawing.Point(96, 64);
			this.textTeam.Multiline = true;
			this.textTeam.Name = "textTeam";
			this.textTeam.ReadOnly = true;
			this.textTeam.Size = new System.Drawing.Size(304, 128);
			this.textTeam.TabIndex = 6;
			this.textTeam.Text = @"Development Team

Nathan Allen................................................Project Manager

Richard Denton.......................................................Interface

Adam Gaige........................................................Networking

Mike Kowalczuk.........................................File Management";
			this.textTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureIcon
			// 
			this.pictureIcon.BackColor = System.Drawing.Color.Transparent;
			this.pictureIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureIcon.Image")));
			this.pictureIcon.Location = new System.Drawing.Point(216, 208);
			this.pictureIcon.Name = "pictureIcon";
			this.pictureIcon.Size = new System.Drawing.Size(64, 64);
			this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureIcon.TabIndex = 7;
			this.pictureIcon.TabStop = false;
			// 
			// About
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(410, 354);
			this.Controls.Add(this.pictureIcon);
			this.Controls.Add(this.textTeam);
			this.Controls.Add(this.textAbout);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.linkWebsite);
			this.Controls.Add(this.pictureLogo);
			this.Controls.Add(this.buttonClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About WebEase";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion

		// Precondition: User clicked the "Close" button
		// Postcondition: Close the form
		private void buttonClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		// Precondition: User clicked the link label
		// Postcondition: Open Kaged Koncepts website
		private void linkWebsite_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Close();
			System.Diagnostics.Process.Start("IExplore", "http://www.kagedkoncepts.com" );
			linkWebsite.LinkVisited = true;
		}
	}
}
