using System;

namespace Webease
{
	// Class to handle the link management
	public class links
	{
		string files, titles, restOfScript;
		int stringPos = 0, paramEndPos = 0;

		// Constructor for when creating a blank javascript links file
		public links( string template)
		{
			files = "index.html,";
			titles = "Home,";
			restOfScript = template.Substring(template.IndexOf("// String to display the links",0));
		}

		// Constructor for when editing an existing javascript links file
		public links( string fileInput )
		{
			// Locate and set the list of file names
			stringPos = fileInput.IndexOf("var fileArray = [",stringPos) + 17;
			paramEndPos = fileInput.IndexOf("];",stringPos);
			files = fileContents.Substring(stringPos,paramEndPos-stringPos);
			stringPos = paramEndPos + 1;

			// Locate and set the list of page names
			stringPos = fileInput.IndexOf("var titleArray = [",stringPos) + 18;
			paramEndPos = fileInput.IndexOf("];",stringPos);
			titles = fileContents.Substring(stringPos,paramEndPos-stringPos);
			stringPos = paramEndPos + 1;

			restOfScript = template.Substring(template.IndexOf("// String to display the links",0));
		}

		public void addPage( string fileName, string pageTitle )
		{
			files += fileName + ",";
			titles += pageTitle + ",";
		}

		public void removePage( string fileName, string PageTitle )
		{
			// Locate fileName
			stringPos = files.IndexOf(fileName);
			paramEndPos = files.IndexOf(",",stringPos);

			// Remove fileName
			files = files.Remove(stringPos,paramEndPos - stringPos);

			// Locate fileName
			stringPos = titles.IndexOf(pageTitle);
			paramEndPos = titles.IndexOf(",",stringPos);

			// Remove fileName
			titles = titles.Remove(stringPos,paramEndPos - stringPos);
		}

		// Create the string for the javascript file
		public string fileOutput()
		{
			string output = "";

			// Initial stuff
			output = "// File to write links to pages in site\n// First array holds filenames, second holds title to be displayed\n\n";
			
			// Insert filenames
			output += "var fileArray = [";
			output += files + "];\n";

			// Insert page titles
			output += "var titleArray = [";
			output += titles + "];\n";

			// Insert the rest of the script
			output += restOfScript;
		}
	}
}
