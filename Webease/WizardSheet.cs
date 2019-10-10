/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
///  Wizard Library - WizardSheet Class
///  Wizard Sheet is the main user interface behind WebEase. Each
///  step is a page derived from the Wizard class and painted on
///  to the Wizard Sheet.
/// </summary>

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Wizard
{
	public class WizardSheet : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox toolbarNew;
		private System.Windows.Forms.PictureBox toolbarOpen;
		private System.Windows.Forms.PictureBox toolbarSave;
		private System.Windows.Forms.PictureBox toolbarPreview;
		private System.Windows.Forms.PictureBox toolbarExit;
		private System.Windows.Forms.PictureBox toolbarHelp;
		private System.Windows.Forms.ImageList toolbarImages;
		public System.Windows.Forms.Button buttonNext;
		public System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.ContextMenu menuHelp;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuHelpOnline;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.Panel pagePanel;
		private System.ComponentModel.IContainer components;
		public int currentPage;
		public System.Windows.Forms.Button buttonFinish;
		public String myName;

		public WizardSheet()
		{
			// Required for Windows Form Designer support
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			// Clean up any resources being used.
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(WizardSheet));
			this.buttonNext = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.toolbarNew = new System.Windows.Forms.PictureBox();
			this.toolbarOpen = new System.Windows.Forms.PictureBox();
			this.toolbarSave = new System.Windows.Forms.PictureBox();
			this.toolbarPreview = new System.Windows.Forms.PictureBox();
			this.toolbarExit = new System.Windows.Forms.PictureBox();
			this.toolbarHelp = new System.Windows.Forms.PictureBox();
			this.menuHelp = new System.Windows.Forms.ContextMenu();
			this.menuHelpOnline = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.toolbarImages = new System.Windows.Forms.ImageList(this.components);
			this.pagePanel = new System.Windows.Forms.Panel();
			this.buttonFinish = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonNext
			// 
			this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.buttonNext.Enabled = false;
			this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNext.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonNext.ForeColor = System.Drawing.Color.White;
			this.buttonNext.Location = new System.Drawing.Point(544, 504);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(112, 32);
			this.buttonNext.TabIndex = 1;
			this.buttonNext.Text = "&Next";
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.buttonBack.Enabled = false;
			this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBack.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBack.ForeColor = System.Drawing.Color.White;
			this.buttonBack.Location = new System.Drawing.Point(424, 504);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(112, 32);
			this.buttonBack.TabIndex = 0;
			this.buttonBack.Text = "&Back";
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// toolbarNew
			// 
			this.toolbarNew.Image = ((System.Drawing.Image)(resources.GetObject("toolbarNew.Image")));
			this.toolbarNew.Location = new System.Drawing.Point(0, 0);
			this.toolbarNew.Name = "toolbarNew";
			this.toolbarNew.Size = new System.Drawing.Size(125, 48);
			this.toolbarNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.toolbarNew.TabIndex = 2;
			this.toolbarNew.TabStop = false;
			this.toolbarNew.Click += new System.EventHandler(this.toolbarNew_Click);
			this.toolbarNew.MouseEnter += new System.EventHandler(this.toolbarNew_MouseEnter);
			this.toolbarNew.MouseLeave += new System.EventHandler(this.toolbarNew_MouseLeave);
			// 
			// toolbarOpen
			// 
			this.toolbarOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolbarOpen.Image")));
			this.toolbarOpen.Location = new System.Drawing.Point(128, 0);
			this.toolbarOpen.Name = "toolbarOpen";
			this.toolbarOpen.Size = new System.Drawing.Size(125, 48);
			this.toolbarOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.toolbarOpen.TabIndex = 3;
			this.toolbarOpen.TabStop = false;
			this.toolbarOpen.Click += new System.EventHandler(this.toolbarOpen_Click);
			this.toolbarOpen.MouseEnter += new System.EventHandler(this.toolbarOpen_MouseEnter);
			this.toolbarOpen.MouseLeave += new System.EventHandler(this.toolbarOpen_MouseLeave);
			// 
			// toolbarSave
			// 
			this.toolbarSave.Image = ((System.Drawing.Image)(resources.GetObject("toolbarSave.Image")));
			this.toolbarSave.Location = new System.Drawing.Point(256, 0);
			this.toolbarSave.Name = "toolbarSave";
			this.toolbarSave.Size = new System.Drawing.Size(125, 48);
			this.toolbarSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.toolbarSave.TabIndex = 4;
			this.toolbarSave.TabStop = false;
			this.toolbarSave.Click += new System.EventHandler(this.toolbarSave_Click);
			this.toolbarSave.MouseEnter += new System.EventHandler(this.toolbarSave_MouseEnter);
			this.toolbarSave.MouseLeave += new System.EventHandler(this.toolbarSave_MouseLeave);
			// 
			// toolbarPreview
			// 
			this.toolbarPreview.Image = ((System.Drawing.Image)(resources.GetObject("toolbarPreview.Image")));
			this.toolbarPreview.Location = new System.Drawing.Point(384, 0);
			this.toolbarPreview.Name = "toolbarPreview";
			this.toolbarPreview.Size = new System.Drawing.Size(125, 48);
			this.toolbarPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.toolbarPreview.TabIndex = 5;
			this.toolbarPreview.TabStop = false;
			this.toolbarPreview.Click += new System.EventHandler(this.toolbarPreview_Click);
			this.toolbarPreview.MouseEnter += new System.EventHandler(this.toolbarPreview_MouseEnter);
			this.toolbarPreview.MouseLeave += new System.EventHandler(this.toolbarPreview_MouseLeave);
			// 
			// toolbarExit
			// 
			this.toolbarExit.Image = ((System.Drawing.Image)(resources.GetObject("toolbarExit.Image")));
			this.toolbarExit.Location = new System.Drawing.Point(672, 0);
			this.toolbarExit.Name = "toolbarExit";
			this.toolbarExit.Size = new System.Drawing.Size(125, 48);
			this.toolbarExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.toolbarExit.TabIndex = 6;
			this.toolbarExit.TabStop = false;
			this.toolbarExit.Click += new System.EventHandler(this.toolbarExit_Click);
			this.toolbarExit.MouseEnter += new System.EventHandler(this.toolbarExit_MouseEnter);
			this.toolbarExit.MouseLeave += new System.EventHandler(this.toolbarExit_MouseLeave);
			// 
			// toolbarHelp
			// 
			this.toolbarHelp.ContextMenu = this.menuHelp;
			this.toolbarHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolbarHelp.Image")));
			this.toolbarHelp.Location = new System.Drawing.Point(512, 0);
			this.toolbarHelp.Name = "toolbarHelp";
			this.toolbarHelp.Size = new System.Drawing.Size(125, 48);
			this.toolbarHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.toolbarHelp.TabIndex = 7;
			this.toolbarHelp.TabStop = false;
			this.toolbarHelp.Click += new System.EventHandler(this.toolbarHelp_Click);
			this.toolbarHelp.MouseEnter += new System.EventHandler(this.toolbarHelp_MouseEnter);
			this.toolbarHelp.MouseLeave += new System.EventHandler(this.toolbarHelp_MouseLeave);
			// 
			// menuHelp
			// 
			this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuHelpOnline,
																					 this.menuItem3,
																					 this.menuHelpAbout});
			// 
			// menuHelpOnline
			// 
			this.menuHelpOnline.Index = 0;
			this.menuHelpOnline.Text = "Get Help Online";
			this.menuHelpOnline.Click += new System.EventHandler(this.menuHelpOnline_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "-";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 2;
			this.menuHelpAbout.Text = "About WebEase";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// toolbarImages
			// 
			this.toolbarImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.toolbarImages.ImageSize = new System.Drawing.Size(125, 48);
			this.toolbarImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolbarImages.ImageStream")));
			this.toolbarImages.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pagePanel
			// 
			this.pagePanel.Location = new System.Drawing.Point(0, 48);
			this.pagePanel.Name = "pagePanel";
			this.pagePanel.Size = new System.Drawing.Size(792, 440);
			this.pagePanel.TabIndex = 8;
			// 
			// buttonFinish
			// 
			this.buttonFinish.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.buttonFinish.Enabled = false;
			this.buttonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFinish.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonFinish.ForeColor = System.Drawing.Color.White;
			this.buttonFinish.Location = new System.Drawing.Point(664, 504);
			this.buttonFinish.Name = "buttonFinish";
			this.buttonFinish.Size = new System.Drawing.Size(112, 32);
			this.buttonFinish.TabIndex = 2;
			this.buttonFinish.Text = "&Finish";
			this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
			// 
			// WizardSheet
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(794, 546);
			this.Controls.Add(this.buttonFinish);
			this.Controls.Add(this.pagePanel);
			this.Controls.Add(this.toolbarHelp);
			this.Controls.Add(this.toolbarExit);
			this.Controls.Add(this.toolbarPreview);
			this.Controls.Add(this.toolbarSave);
			this.Controls.Add(this.toolbarOpen);
			this.Controls.Add(this.toolbarNew);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonNext);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "WizardSheet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WebEase - Untitled Project";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.WizardSheet_Closing);
			this.Load += new System.EventHandler(this.WizardSheet_Load);
			this.ResumeLayout(false);

		}
		#endregion

		#region Wizard Pages Initialization
		public static IList myPages = new ArrayList();
		public IList Pages
		{
			get { return myPages; }
		}

		public void SetActivePage(int pageIndex)
		{
			WizardPage page = (WizardPage)myPages[pageIndex];
			SetActivePage(page);
		}

		private void SetActivePage(WizardPage newPage)
		{
			// If this page isn't in the Controls collection, add it
			if (!pagePanel.Controls.Contains(newPage)) pagePanel.Controls.Add(newPage);

			// Show this page
			newPage.Visible = true;

			// Hide all of the other pages
			foreach (WizardPage page in myPages)
				if (page != newPage) page.Visible = false;
		}
		#endregion

		#region Toolbar "New Project" Button
		// Precondition: User moved mouse over the button
		// Postcondition: Change the original image to the mouse over counterpart
		private void toolbarNew_MouseEnter(object sender, System.EventArgs e)
		{
			toolbarNew.Image = toolbarImages.Images[1];
		}

		// Precondition: User moved mouse off of the button
		// Postcondition: Change the mouse over image back to the original
		private void toolbarNew_MouseLeave(object sender, System.EventArgs e)
		{
			toolbarNew.Image = toolbarImages.Images[0];
		}

		// Precondition: User clicked the new button
		// Postcondition: Create a new, empty project
		private void toolbarNew_Click(object sender, System.EventArgs e)
		{
			WebEase.Program.newProject();
		}
		#endregion

		#region Toolbar "Open Project" Button
		// Precondition: User moved mouse over the button
		// Postcondition: Change the original image to the mouse over counterpart
		private void toolbarOpen_MouseEnter(object sender, System.EventArgs e)
		{
			toolbarOpen.Image = toolbarImages.Images[3];
		}

		// Precondition: User moved mouse off of the button
		// Postcondition: Change the mouse over image back to the original
		private void toolbarOpen_MouseLeave(object sender, System.EventArgs e)
		{
			toolbarOpen.Image = toolbarImages.Images[2];
		}

		// Precondition: User clicked the open button
		// Postcondition: Open an existing project
		private void toolbarOpen_Click(object sender, System.EventArgs e)
		{
			WebEase.Program.openProject();
		}
		#endregion

		#region Toolbar "Save Project" Button
		// Precondition: User moved mouse over the button
		// Postcondition: Change the original image to the mouse over counterpart
		private void toolbarSave_MouseEnter(object sender, System.EventArgs e)
		{
			toolbarSave.Image = toolbarImages.Images[5];
		}

		// Precondition: User moved mouse off of the button
		// Postcondition: Change the mouse over image back to the original
		private void toolbarSave_MouseLeave(object sender, System.EventArgs e)
		{
			toolbarSave.Image = toolbarImages.Images[4];
		}

		// Precondition: User clicked the button
		// Postcondition: Save the current project
		private void toolbarSave_Click(object sender, System.EventArgs e)
		{
			WebEase.Program.saveProject();
		}
		#endregion

		#region Toolbar "Preview Website" Button
		// Precondition: User moved mouse over the button
		// Postcondition: Change the original image to the mouse over counterpart
		private void toolbarPreview_MouseEnter(object sender, System.EventArgs e)
		{
			toolbarPreview.Image = toolbarImages.Images[7];
		}

		// Precondition: User moved mouse off of the button
		// Postcondition: Change the mouse over image back to the original
		private void toolbarPreview_MouseLeave(object sender, System.EventArgs e)
		{
			toolbarPreview.Image = toolbarImages.Images[6];
		}

		// Precondition: User clicked the button
		// Postcondition: Preview the current project in a new browser window
		private void toolbarPreview_Click(object sender, System.EventArgs e)
		{
			if (myName != "") System.Diagnostics.Process.Start("IExplore", Application.StartupPath + "\\Projects\\" + myName + "\\index.html");
			else showError();
		}
		#endregion

		#region Toolbar "Help/About" Button
		// Precondition: User moved mouse over the button
		// Postcondition: Change the original image to the mouse over counterpart
		private void toolbarHelp_MouseEnter(object sender, System.EventArgs e)
		{
			toolbarHelp.Image = toolbarImages.Images[9];
		}

		// Precondition: User moved mouse off of the button
		// Postcondition: Change the mouse over image back to the original
		private void toolbarHelp_MouseLeave(object sender, System.EventArgs e)
		{
			toolbarHelp.Image = toolbarImages.Images[8];
		}

		// Precondition: User clicked the button
		// Postcondition: Display the help menu
		private void toolbarHelp_Click(object sender, System.EventArgs e)
		{
			Point pos = new Point(525, 48);
			menuHelp.Show(this, pos);
		}
		#endregion

		#region Toolbar "Exit WebEase" Button
		// Precondition: User moved mouse over the button
		// Postcondition: Change the original image to the mouse over counterpart
		private void toolbarExit_MouseEnter(object sender, System.EventArgs e)
		{
			toolbarExit.Image = toolbarImages.Images[11];
		}

		// Precondition: User moved mouse off of the button
		// Postcondition: Change the mouse over image back to the original
		private void toolbarExit_MouseLeave(object sender, System.EventArgs e)
		{
			toolbarExit.Image = toolbarImages.Images[10];
		}

		// Precondition: User clicked the button
		// Postcondition: Exit the application
		private void toolbarExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}
		#endregion

		#region Help Button Context Menu
		// Precondition: User clicked Help > Get Help Online
		// Postcondition: Open the WebEase help website
		private void menuHelpOnline_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("IExplore", "http://www.kagedkoncepts.com/webease/");
		}

		// Precondition: User clicked Help > About
		// Postcondition: Load the about box form and disable the wizard
		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			// TODO: Make it so only one instance of the about box can be opened
			Form About = new About();
			About.Show();
		}
		#endregion

		#region Wizard Buttons
		private void buttonNext_Click(object sender, System.EventArgs e)
		{
			// Reenable the back button
			if (!buttonBack.Enabled) buttonBack.Enabled = true;

			// Advance the wizard one page
			if (currentPage + 1 >= myPages.Count - 1) buttonNext.Enabled = false;
			SetActivePage(++currentPage);
		}

		private void buttonBack_Click(object sender, System.EventArgs e)
		{
			// Reenable the next button
			if (!buttonNext.Enabled) buttonNext.Enabled = true;

			// Backtrack the wizard one page
			if (currentPage - 1 <= 1) buttonBack.Enabled = false;
			SetActivePage(--currentPage);
		}

		private void buttonFinish_Click(object sender, System.EventArgs e)
		{
			// Disable other buttons
			buttonBack.Enabled = false;
			buttonNext.Enabled = false;

			// Move to final step
			WebEase.Program.wizard.Pages.Add(new WebEase.Step5());
			SetActivePage(myPages.Count - 1);
		}
		#endregion

		// Precondition: The window is loaded
		// Postcondition: Intitialize the wizard
		private void WizardSheet_Load(object sender, System.EventArgs e)
		{
			// Set wizard to the first page upon load
			SetActivePage(0);

			// Initialize the file name
			myName = "";
		}

		// Precondition: The window is asked to close
		// Postcondition: Ask the user to save if a project is open before closing
		private void WizardSheet_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (myName != "")
			{
				// Ask the user to save before exiting
				DialogResult dialogExit = MessageBox.Show("Would you like to save your project before exiting?",
					"WebEase", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

				// Check user's response
				switch (dialogExit)
				{
					case DialogResult.Yes:				// Yes - save and exit
						toolbarSave_Click(sender, e);
						Application.Exit();
						break;
					case DialogResult.No:				// No - only exit
						Application.Exit();
						break;
					default:							// Cancel - do nothing
						e.Cancel = true;
						break;
				};
			}
		}

		// Precondition: The wizard found a problem
		// Postcondition: Display an error message
		public void showError()
		{
			MessageBox.Show("Please open or start a new project.",
				"WebEase", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		}
	}
}
