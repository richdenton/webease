/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
///  WebEase Application - Program Class
///  The program class is where a majority of the WebEase work is
///  accomplished. This is where the main function is located as
///  well as where project files are created, opened and saved.
///  The program class is also where the WebEase and Wizard meet.
/// </summary>

using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using Wizard;

namespace WebEase
{
	public class Program
	{
		// Public parameters to be accessed by each step
		public static WizardSheet wizard = new WizardSheet();
		public static String stringName = "";
		public static String stringTitle = "";
		public static String stringDescription = "";
		public static String stringKeywords = "";
		public static String stringTemplate = "default";
		public static String stringHeadline1 = "";
		public static String stringBody1 = "";
		public static String stringHeadline2 = "";
		public static String stringBody2 = "";
		public static IList arrayExtraTitle = new ArrayList();
		public static IList arrayExtraHead = new ArrayList();
		public static IList arrayExtraBody = new ArrayList();

		// The overall main function to load the pages of the wizard
		static void Main()
		{
			wizard.Pages.Add(new Step0());
			wizard.Pages.Add(new Step1());
			wizard.Pages.Add(new Step2());
			wizard.Pages.Add(new Step3());
			wizard.Pages.Add(new Step4());
			Application.Run(wizard);
		}

		#region New Project
		// Precondition: Wizard requests to create a new project
		// Postcondition: Create a new folder and set the project name
		public static void newProject()
		{
			// Open the new dialog window and get the project name
			newProject formNew = new newProject();
			DialogResult dr = formNew.ShowDialog(wizard);
			if(dr == DialogResult.OK)
			{ 
				// Get the project name
				wizard.myName = formNew.projectName.Text;
				WizardSheet.ActiveForm.Text = "WebEase - " + wizard.myName + ".wbs";

				// Create the project's directory 
				DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + "\\Projects");
				try { dir.CreateSubdirectory(wizard.myName); }
				catch(IOException q) { Console.WriteLine(q.Message); }

				// Create index.html
				FileStream fs = new FileStream(dir + "\\" + wizard.myName + "\\index.html", FileMode.Create);
				StreamWriter objWriter = new StreamWriter(fs, System.Text.Encoding.UTF8, 1000);
				objWriter.Write("<html>\r\n");
				objWriter.Write("<head><title>WebEase</title></head>\r\n");
				objWriter.Write("<body>\r\n");
				objWriter.Write("	<center>Please use <i>WebEase</i> to add content to your website.</center>");
				objWriter.Write("</body>\r\n");
				objWriter.Write("</html>\r\n");
				objWriter.Close();
				fs.Close();

				// Move to first step of the wizard
				wizard.SetActivePage(1);
				wizard.currentPage = 1;
				wizard.buttonNext.Enabled = true;
				wizard.buttonFinish.Enabled = true;
			}
		}
		#endregion

		#region Open Project
		// Precondition: Wizard requests to open a project
		// Postcondition: Ask the user what project to open
		public static void openProject()
		{
			// Ask user to save and clear the project
			if (wizard.myName != "")
			{
				// Ask the user to save before exiting
				DialogResult dialogExit = MessageBox.Show("Would you like to save your project before starting a new one?",
					"WebEase", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

				// Check user's response
				switch (dialogExit)
				{
					case DialogResult.Yes:				// Yes - save and continue
						saveProject();
						break;
					case DialogResult.No:				// No - continue with function
						break;
					default:							// Cancel - exit function
						return;
				};
			}

			// Initialize open dialog
			OpenFileDialog fileIn = new OpenFileDialog();
			fileIn.Title = "Open WebEase Project";
			fileIn.Filter = "WebEase Projects (*.wbs)|*.wbs|All Files (*.*)|*.*";
			fileIn.InitialDirectory = @Application.StartupPath + "\\Projects";

			// Open file input stream
			if (fileIn.ShowDialog() == DialogResult.OK)
			{
				// Read in project data
				wizard.myName = fileIn.FileName.Substring(fileIn.FileName.LastIndexOf("\\") + 1, fileIn.FileName.Length - fileIn.FileName.LastIndexOf("\\") - 5);
				WizardSheet.ActiveForm.Text = "WebEase - " + wizard.myName + ".wbs";
				StreamReader objReader = new StreamReader(fileIn.FileName);
				stringName = objReader.ReadLine();
				stringTitle = objReader.ReadLine();
				stringDescription = objReader.ReadLine();
				stringKeywords = objReader.ReadLine();
				stringTemplate = objReader.ReadLine();
				stringHeadline1 = objReader.ReadLine();
				stringBody1 = objReader.ReadLine();
				stringHeadline2 = objReader.ReadLine();
				stringBody2 = objReader.ReadLine();
				// TODO: Open extra pages here!
				objReader.Close();
				
				// Move to first step of the wizard
				wizard.SetActivePage(1);
				wizard.currentPage = 1;
				wizard.buttonNext.Enabled = true;
				wizard.buttonFinish.Enabled = true;
			}
			// Else cancel was hit or excape - no action taken 
		}
		#endregion

		#region Save Project
		// Precondition: Wizard requests to save the project
		// Postcondition: Write all WebEase files to the correct folder
		public static void saveProject()
		{
			if (wizard.myName != "")
			{	
				// Make a reference to the project directory
				DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + "\\Projects\\");

				// Create index.html
				FileStream fs = new FileStream(dir + "\\" + wizard.myName + "\\index.html", FileMode.Create);
				StreamWriter objWriter = new StreamWriter(fs, System.Text.Encoding.UTF8, 1000);
				objWriter.Write("<html>\r\n");
				objWriter.Write("<head>\r\n");
				objWriter.Write("	<title>" + stringTitle + "</title>\r\n");
				objWriter.Write("	<link rel=\"stylesheet\" type=\"text/css\" href=\"" + stringTemplate.ToLower() + ".css\" />\r\n");
				objWriter.Write("	<meta name=\"description\" content=\"" + stringDescription + "\">\r\n");
				objWriter.Write("	<meta name=\"keywords\" content=\"" + stringKeywords + "\">\r\n");
				objWriter.Write("</head>\r\n");
				objWriter.Write("<body>\r\n");
				objWriter.Write("	<div class=\"title\">" + stringTitle + "</div>\r\n");
				objWriter.Write("	<div class=\"links\">...\r\n");

				// Create links to other pages
				for (int i = 0; i < arrayExtraTitle.Count; i++)
					objWriter.Write("		<a href=\"page" + i + ".html\">" + arrayExtraTitle[i] + "</a> ... \r\n");

				objWriter.Write("	</div>\r\n");
				objWriter.Write("	<div class=\"headline\">" + stringHeadline1 + "</div>\r\n");
				objWriter.Write("	<div class=\"content\">\r\n");
				objWriter.Write("		" + stringBody1 + "\r\n");
				objWriter.Write("	</div>\r\n");
				objWriter.Write("	<div class=\"headline\">" + stringHeadline2 + "</div>\r\n");
				objWriter.Write("	<div class=\"content\">\r\n");
				objWriter.Write("		" + stringBody2 + "\r\n");
				objWriter.Write("	</div>\r\n");
				objWriter.Write("	<div class=\"footer\"> This website was created by " + stringName + ".</div>\r\n");
				objWriter.Write("</body>\r\n");
				objWriter.Write("</html>\r\n");
				objWriter.Close();
				fs.Close();

				// Create other pages
				for (int i = 0; i < arrayExtraTitle.Count; i++)
				{
					fs = new FileStream(dir + "\\" + wizard.myName + "\\page" + i + ".html", FileMode.Create);
					objWriter = new StreamWriter(fs, System.Text.Encoding.UTF8, 1000);
					objWriter.Write("<html>\r\n");
					objWriter.Write("<head>\r\n");
					objWriter.Write("	<title>" + stringTitle + ": " + arrayExtraTitle[i] + "</title>\r\n");
					objWriter.Write("	<link rel=\"stylesheet\" type=\"text/css\" href=\"" + stringTemplate.ToLower() + ".css\" />\r\n");
					objWriter.Write("</head>\r\n");
					objWriter.Write("<body>\r\n");
					objWriter.Write("	<div class=\"title\">" + stringTitle + ": " + arrayExtraTitle[i] + "</div>\r\n");
					objWriter.Write("	<div class=\"links\">\r\n");
					objWriter.Write("		... <a href=\"index.html\">Home</a> ... \r\n");
					
					// Create links to other pages
					for (int i2 = 0; i2 < arrayExtraTitle.Count; i2++)
						if (i != i2) objWriter.Write("		<a href=\"page" + i2 + ".html\">" + arrayExtraTitle[i2] + "</a> ... \r\n");

					objWriter.Write("	</div>\r\n");
					objWriter.Write("	<div class=\"headline\">" + arrayExtraHead[i] + "</div>\r\n");
					objWriter.Write("	<div class=\"content\">\r\n");
					objWriter.Write("		" + arrayExtraBody[i] + "\r\n");
					objWriter.Write("	</div>\r\n");
					objWriter.Write("	<div class=\"footer\"> This website was created by " + stringName + ".</div>\r\n");
					objWriter.Write("</body>\r\n");
					objWriter.Write("</html>\r\n");
					objWriter.Close();
					fs.Close();
				}

				// Create project.wbs
				fs = new FileStream(dir + "\\" + wizard.myName + "\\" + wizard.myName + ".wbs", FileMode.Create);
				objWriter = new StreamWriter(fs, System.Text.Encoding.UTF8, 1000);
				objWriter.Write(stringName + "\r\n");
				objWriter.Write(stringTitle + "\r\n");
				objWriter.Write(stringDescription + "\r\n");
				objWriter.Write(stringKeywords + "\r\n");
				objWriter.Write(stringTemplate + "\r\n");
				objWriter.Write(stringHeadline1 + "\r\n");
				objWriter.Write(stringBody1 + "\r\n");
				objWriter.Write(stringHeadline2 + "\r\n");
				objWriter.Write(stringBody2 + "\r\n");
				// TODO: Save extra pages here!
				objWriter.Close();
				fs.Close();

				// Copy the template
				File.Copy(Application.StartupPath + "\\Templates\\" + stringTemplate.ToLower() + ".css",
					Application.StartupPath + "\\Projects\\" + wizard.myName + "\\" + stringTemplate.ToLower() + ".css", true);

				// Notify the user
				MessageBox.Show("Project \"" + wizard.myName + "\" successfully saved!",
					"WebEase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else wizard.showError();
		}
		#endregion
	}
}