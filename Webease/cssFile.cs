using System;

namespace Webease
{
	public class cssFile 
	{
		public string pageBGColor,
			bodyTextColor,
			bodyTextFont,
			bodyTextFontSize,
			bodyLinksTextColor,
			bodyLinksTextDecoration,
			titleTextColor,
			titleTextFont,
			titleTextSize,
			logoGraphic,
			linkbarBGColor,
			linkbarTextColor,
			linkbarFont,
			linkbarFontSize;
		private int stringPos = 0, paramEndPos = 0;

		// create a new CSS file
		public cssFile() 
		{
			pageBGColor = "white";
			bodyTextColor = "black";
			bodyTextFont = "Times New Roman";
			bodyTextFontSize = "12pt";
			bodyLinksTextColor = "blue";
			bodyLinksTextDecoration = "underline";
			titleTextColor = "black";
			titleTextFont = "Times New Roman";
			titleTextSize = "18pt";
			logoGraphic = "";
			linkbarBGColor = "blue";
			linkbarTextColor = "white";
			linkbarFont = "Times New Roman";
			linkbarFontSize = "14pt";
		}

		// read in an existing Webease CSS file
		public cssFile( string fileContents ) 
		{
			// Locate and set body background color
			setParam("body {background-color:", ";", ref pageBGColor);

			// Locate and set body font color
			setParam("font-color:", ";", ref bodyTextColor);
			
			// Locate and set body font
			setParam("font-family:", ";", ref bodyTextFont);

			// Locate and set body font size
			setParam("font-size:", ";", ref bodyTextFontSize);

			// Locate and link font color
			setParam("a {font-color:", ";", ref bodyLinksTextColor);

			// Locate and set link text decoration
			setParam("text-decoration:", ";", ref bodyLinksTextDecoration);

			// Locate and set title font color
			setParam("font-color:", ";", ref titleTextColor);

			// Locate and set title font
			setParam("font-family:", ";", ref titleTextFont);

			// Locate and set title font size
			setParam("font-size:", ";", ref titleTextSize);

			// Locate and set logo
			setParam(".logo {background-image:url(", ");", ref logoGraphic);

			// Locate and set linkbar background color
			setParam(".linkbar {background-color:", ";", ref linkbarBGColor);

			// Locate and set linkbar font color
			setParam("font-color:", ";", ref linkbarTextColor);

			// Locate and set linkbar font color
			setParam("font-family:", ";", ref linkbarFont);

			// Locate and set linkbar font size
			setParam("font-size:", ";", ref linkbarFontSize);
 		}

		// Locate and set CSS parameters from file input string
		public void setParam( string searchItem, string endSearchItem, ref string param )
		{
			stringPos = fileContents.IndexOf(searchItem,stringPos) + searchItem.Length;
			paramEndPos = fileContents.IndexOf(endSearchItem,stringPos);
			param = fileContents.Substring(stringPos,paramEndPos-stringPos);
			stringPos = paramEndPos + 1;
		}

		// read out Webease CSS file for saving
		public string fileOutput() 
		{
			string output = "";

			// Insert header comments
			output = "/* For use with Kaged Koncepts (R) Webease (C) -generated sites */\n/* Editing this file manually may make it incompatible with Webease */";
		
			// Insert body style
			output += "body {background-color:" + pageBGColor +";";
			output += "font-color:" + bodyTextColor + ";";
			output += "font-family:" + bodyTextFont + ";";
			output += "font-size:" + bodyTextFontSize +"}\n";

			// Insert links style
			output += "a {font-color:" + bodyLinksTextColor + ";";
			output += "text-decoration:" + bodyLinksTextDecoration + "}\n";
		
			// Insert page title style
			output += ".title {font-color:" + titleTextColor + ";";
			output += "font-family:" + titleTextFont + ";";
			output += "font-size:" + titleTextSize + "}\n";

			// Insert logo
			output += ".logo {background-image:url(" + logoGraphic + ");";
			output += "background-position:center;background-repeat:no-repeat}\n";

			// Insert linkbar style
			output += ".linkbar {background-color:" + linkbarBGColor + ";";
			output += "font-color:" + linkbarTextColor + ";";
			output += "font-family:" + linkbarFont + ";";
			output += "font-size:" + linkbarFontSize + ";";
			output += "text-align:center}";

			return output;
		}
	}
}