/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
///  WebEase Application - Step5 Class (Publish Your Website)
///  In the final step of WebEase, the user is given the ability to
///  upload their website to a server via File Transfer Protocol,
///  or FTP. WebEase uses an outside library from Enterprise
///  Distributed Technologies to acheive this.
/// </summary>

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FTP;

namespace WebEase
{
	public class Step5 : Wizard.WizardPage
	{
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtDirectory;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.TextBox txtHost;
		private System.Windows.Forms.Label lblRemoteDirecotry;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUserID;
		private System.Windows.Forms.Button btnTransfer;
		private System.Windows.Forms.ListBox lbProgress;
		private System.Windows.Forms.Label lblHost;
		private System.ComponentModel.IContainer components = null;

		// Our FTP Client that we will use
		com.enterprisedt.net.ftp.FTPClient ftpClient = null;
		bool FTPstatus = false;			// Keep track of if the FTP is connected or not
		string remoteDirectory = null;	// The remoteDirectory that the FTP client is currently at

		// File Dialog - initialized here to provide continuous access to chosen directory
		private OpenFileDialog ofd = new OpenFileDialog();
		private System.Windows.Forms.Label labelDescription;
		
		// Setup the logger for new loggable events
		FTP.Logger logger = new FTP.Logger();

		public Step5()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// Register a logger
			logger.OnLoggableEvent +=new FTP.Logger.LoggableEventHandler(logger_OnLoggableEvent);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Step5));
			this.labelTitle = new System.Windows.Forms.Label();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.txtDirectory = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.txtHost = new System.Windows.Forms.TextBox();
			this.lblRemoteDirecotry = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUserID = new System.Windows.Forms.Label();
			this.btnTransfer = new System.Windows.Forms.Button();
			this.lbProgress = new System.Windows.Forms.ListBox();
			this.lblHost = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
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
			this.labelTitle.Text = "Publish Your Website";
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDisconnect.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnDisconnect.ForeColor = System.Drawing.Color.White;
			this.btnDisconnect.Location = new System.Drawing.Point(528, 296);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(144, 32);
			this.btnDisconnect.TabIndex = 5;
			this.btnDisconnect.Text = "&Disconnect";
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConnect.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnConnect.ForeColor = System.Drawing.Color.White;
			this.btnConnect.Location = new System.Drawing.Point(528, 256);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(144, 32);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "&Connect";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// txtDirectory
			// 
			this.txtDirectory.Location = new System.Drawing.Point(536, 192);
			this.txtDirectory.Name = "txtDirectory";
			this.txtDirectory.Size = new System.Drawing.Size(232, 20);
			this.txtDirectory.TabIndex = 3;
			this.txtDirectory.Text = "(Default)";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(536, 144);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(240, 20);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "";
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(536, 104);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(240, 20);
			this.txtUserID.TabIndex = 1;
			this.txtUserID.Text = "";
			// 
			// txtHost
			// 
			this.txtHost.Location = new System.Drawing.Point(536, 64);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new System.Drawing.Size(240, 20);
			this.txtHost.TabIndex = 0;
			this.txtHost.Text = "";
			// 
			// lblRemoteDirecotry
			// 
			this.lblRemoteDirecotry.BackColor = System.Drawing.Color.Transparent;
			this.lblRemoteDirecotry.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRemoteDirecotry.Location = new System.Drawing.Point(416, 184);
			this.lblRemoteDirecotry.Name = "lblRemoteDirecotry";
			this.lblRemoteDirecotry.Size = new System.Drawing.Size(120, 40);
			this.lblRemoteDirecotry.TabIndex = 47;
			this.lblRemoteDirecotry.Text = "Remote Directory:";
			// 
			// lblPassword
			// 
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(416, 144);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(120, 23);
			this.lblPassword.TabIndex = 46;
			this.lblPassword.Text = "Password:";
			// 
			// lblUserID
			// 
			this.lblUserID.BackColor = System.Drawing.Color.Transparent;
			this.lblUserID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblUserID.Location = new System.Drawing.Point(416, 104);
			this.lblUserID.Name = "lblUserID";
			this.lblUserID.Size = new System.Drawing.Size(120, 23);
			this.lblUserID.TabIndex = 45;
			this.lblUserID.Text = "User ID:";
			// 
			// btnTransfer
			// 
			this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransfer.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnTransfer.ForeColor = System.Drawing.Color.White;
			this.btnTransfer.Location = new System.Drawing.Point(528, 368);
			this.btnTransfer.Name = "btnTransfer";
			this.btnTransfer.Size = new System.Drawing.Size(144, 48);
			this.btnTransfer.TabIndex = 6;
			this.btnTransfer.Text = "&Upload";
			this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
			// 
			// lbProgress
			// 
			this.lbProgress.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(204)), ((System.Byte)(204)), ((System.Byte)(204)));
			this.lbProgress.Location = new System.Drawing.Point(16, 232);
			this.lbProgress.Name = "lbProgress";
			this.lbProgress.Size = new System.Drawing.Size(368, 147);
			this.lbProgress.TabIndex = 44;
			// 
			// lblHost
			// 
			this.lblHost.BackColor = System.Drawing.Color.Transparent;
			this.lblHost.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblHost.Location = new System.Drawing.Point(416, 64);
			this.lblHost.Name = "lblHost";
			this.lblHost.Size = new System.Drawing.Size(120, 23);
			this.lblHost.TabIndex = 42;
			this.lblHost.Text = "Host Name:";
			// 
			// labelDescription
			// 
			this.labelDescription.BackColor = System.Drawing.Color.Transparent;
			this.labelDescription.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDescription.Location = new System.Drawing.Point(16, 64);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(368, 152);
			this.labelDescription.TabIndex = 48;
			this.labelDescription.Text = "Alright, your website is finished and ready to go online. Simply enter your File " +
				"Transfer Protocol (FTP) login information in the boxes to the right and select t" +
				"he files you wish to upload. Your FTP information can be found with your web hos" +
				"t.";
			// 
			// Step5
			// 
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtDirectory);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserID);
			this.Controls.Add(this.txtHost);
			this.Controls.Add(this.lblRemoteDirecotry);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserID);
			this.Controls.Add(this.btnTransfer);
			this.Controls.Add(this.lbProgress);
			this.Controls.Add(this.lblHost);
			this.Controls.Add(this.labelTitle);
			this.Name = "Step5";
			this.Size = new System.Drawing.Size(792, 440);
			this.Load += new System.EventHandler(this.Step5_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void logger_OnLoggableEvent(object o, LogInfoEventArgs e)
		{
			lbProgress.Items.Add(e.Message);
			lbProgress.SelectedIndex = lbProgress.Items.Count - 1;
			Application.DoEvents();

		}

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			if( !FTPstatus )
			{
				bool foundhost = false;
				
				// Make a new instance of com.enterprisedt.net FTP Client using host
				try
				{
					string host = this.txtHost.Text;
					ftpClient = new com.enterprisedt.net.ftp.FTPClient(host);
					foundhost = true;
				}
				catch (Exception) { logger.Write(this,"Invalid host"); }
				if (foundhost)
				{
					// Use username and password with FTP connection
					try
					{
						string user = this.txtUserID.Text;
						string pass = this.txtPassword.Text;
						ftpClient.Login(user,pass);
						FTPstatus = true;
						logger.Write(this,"Connected");
					} 
					catch (Exception) { logger.Write(this,"Invalid username or password"); }
				}
			}
			else
				logger.Write(this,"Already connected");
		}

		// Functionality for when the Transfer button is pressed-- set directory and put file
		private void btnTransfer_Click(object sender, System.EventArgs e)
		{
			bool transferCheck = false;
			bool connectCheck = false;
			
			// Handle non-connected transfer attempts
			if(ftpClient == null)
			{
				logger.Write(this,"Not Connected. Press Connect before Transfer");
			}
			else
			{
				// Check the connection status
				if( ftpClient.IsConnected )
				{
					connectCheck = true;
				}
				else
				{
					logger.Write(this,"Not Connected. Re-Connecting...");
					btnConnect_Click(sender,e);		// Re-Connect for the user
					if( ftpClient.IsConnected )			// Check again if a connection was made
					{
						connectCheck = true;
					}
				}

				// If the connection is open, proceed with transfer
				if( connectCheck )
				{
					if( (remoteDirectory == null) && (this.txtDirectory.Text == "(Default)") )  // directory as default
					{  
						logger.Write(this,"Directory is set to default");
					}
					else if( remoteDirectory != this.txtDirectory.Text)		// change directory on the host
					{
						try
						{
							string newDirectory = this.txtDirectory.Text;
							remoteDirectory = this.txtDirectory.Text;
							ftpClient.Chdir(newDirectory);
							logger.Write(this,"Directory changed to " + this.txtDirectory.Text);
						}
						catch (Exception)
						{
							transferCheck = true;
							logger.Write(this,"Cannot reach directory");
						}
					}
					
            
					if( !transferCheck )	// send a file to the host, using the exisiting name, if directory is ok.
					{
						try
						{
							DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + "\\Projects\\" + Program.wizard.myName);
							FileInfo[] rgFiles = dir.GetFiles("*.*");
							foreach(FileInfo file in rgFiles)
							{
								string localFileName = file.Name;
								string shortName = localFileName.Substring(localFileName.LastIndexOf("\\")+1);
								ftpClient.Put(localFileName, shortName);
								logger.Write(this, file.Name + " put on server");      
							}
						}
						catch (Exception)
						{
							logger.Write(this, "Cannot read file");
						}
					}
				}
				else
				{
					logger.Write(this,"Could not Upload. Please Re-Connect Manually.");
				}
			}
		}

		// Disconnect method for WebEase FTP
		private void btnDisconnect_Click(object sender, System.EventArgs e)
		{
			// clean up and go home
			if(FTPstatus)
			{
				ftpClient.Quit();
				FTPstatus = false;
				logger.Write(this,"Disconnected");
			}
			else
			{
				logger.Write(this,"Already disconnected");
			}
		}

		private void Step5_Load(object sender, System.EventArgs e)
		{
			// Save the project before uploading
			Program.saveProject();

			// Disable the finish button
			Program.wizard.buttonFinish.Enabled = false;
		}
	}
}

