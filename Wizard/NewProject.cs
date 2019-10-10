/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
///  Wizard Library - NewProject Class
///  This class displays a window to title a new project.
/// </summary>

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Wizard
{
	// Summary description for NewDialog.
	public class newProject : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		public System.Windows.Forms.TextBox projectName;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		public newProject()
		{
			// Required for Windows Form Designer support
			InitializeComponent();
		}

		// Clean up any resources being used.
		protected override void Dispose( bool disposing )
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(newProject));
			this.label1 = new System.Windows.Forms.Label();
			this.projectName = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please enter a name for your project.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// projectName
			// 
			this.projectName.AcceptsTab = true;
			this.projectName.Location = new System.Drawing.Point(32, 48);
			this.projectName.Name = "projectName";
			this.projectName.Size = new System.Drawing.Size(312, 20);
			this.projectName.TabIndex = 1;
			this.projectName.Text = "";
			this.projectName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Project_name_KeyUp);
			// 
			// buttonOK
			// 
			this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonOK.ForeColor = System.Drawing.Color.White;
			this.buttonOK.Location = new System.Drawing.Point(32, 88);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(112, 32);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonCancel.ForeColor = System.Drawing.Color.White;
			this.buttonCancel.Location = new System.Drawing.Point(232, 88);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(112, 32);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// newProject
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(51)), ((System.Byte)(102)), ((System.Byte)(153)));
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(376, 130);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.projectName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "newProject";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WebEase";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.newProject_Closing);
			this.Load += new System.EventHandler(this.newProject_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Cancel_Click(object sender, System.EventArgs e)
		{
			// Close this dialog
			Close();
		}

		private void newProject_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Check if cancel is clicked - show exit dialog if so
			if (DialogResult == DialogResult.Cancel) return;

			// Checks if text is empty - presents error if so
			if(projectName.Text == "")
			{
				MessageBox.Show("You must enter a name.", "WebEase Error",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
				e.Cancel = true;
			}
		}

		private void Project_name_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			// When enter key is pressed, computer thinks OK is clicked
			if (e.KeyCode == Keys.Enter) buttonOK.PerformClick();
		}

		private void newProject_Load(object sender, System.EventArgs e)
		{
		
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
