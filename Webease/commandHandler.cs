using System;

namespace Webease
{
	// Class to route all the commands in WebEase
	public class commandHandler
	{ 
		cssFile css;
		links linkSet;
		
		// Constructor called for new projects
		public commandHandler()
		{
			// TODO: Add constructor logic here
			css = new cssFile();
			linkSet = new links();
		}

		// Constructor called when opening existing projects
		public commandHandler( string cssStream, string linksStream )
		{
			css = new cssFile(cssStream);
			linkSet = new links(linksStream);
		}

		// Get and Set methods for CSS settings
		public void setPageBGColor( string input ) 
		{
			css.pageBGColor = input;
		}
		public void setBodyTextColor( string input ) 
		{
			css.bodyTextColor = input;
		}
		public void setBodyTextFont( string input ) 
		{
			css.bodyTextFont = input;
		}
		public void setBodyTextFontSize( string input ) 
		{
			css.bodyTextFontSize = input;
		}
		public void setBodyLinksTextColor( string input ) 
		{
			css.bodyLinksTextColor = input;
		}
		public void setBodyLinksTextDecoration( string input ) 
		{
			css.bodyLinksTextDecoration = input;
		}
		public void setTitleTextColor( string input ) 
		{
			css.titleTextColor = input;
		}
		public void setTitleTextFont( string input ) 
		{
			css.titleTextFont = input;
		}
		public void setTitleTextSize( string input ) 
		{
			css.titleTextSize = input;
		}
		public void setLogoGraphic( string input ) 
		{
			css.logoGraphic = input;
		}
		public void setLinkbarBGColor( string input ) 
		{
			css.linkbarBGColor = input;
		}
		public void setLinkbarTextColor( string input ) 
		{
			css.linkbarTextColor = input;
		}
		public void setLinkbarFont( string input ) 
		{
			css.linkbarFont = input;
		}
		public void setLinkbarFontSize( string input ) 
		{
			css.linkbarFontSize = input;
		}
		public string getPageBGColor() 
		{
			return css.pageBGColor;
		}
		public string getBodyTextColor() 
		{
			return css.bodyTextColor;
		}
		public string getBodyTextFont() 
		{
			return css.bodyTextFont;
		}
		public string getBodyTextFontSize() 
		{
			return css.bodyTextFontSize;
		}
		public string getBodyLinksTextColor() 
		{
			return css.bodyLinksTextColor;
		}
		public string getBodyLinksTextDecoration() 
		{
			return css.bodyLinksTextDecoration;
		}
		public string getTitleTextColor() 
		{
			return css.titleTextColor;
		}
		public string getTitleTextFont() 
		{
			return css.titleTextFont;
		}
		public string getTitleTextSize() 
		{
			return css.titleTextSize;
		}
		public string getLogoGraphic() 
		{
			return css.logoGraphic;
		}
		public string getLinkbarBGColor() 
		{
			return css.linkbarBGColor;
		}
		public string getLinkbarTextColor() 
		{
			return css.linkbarTextColor;
		}
		public string getLinkbarFont() 
		{
			return css.linkbarFont;
		}
		public string getLinkbarFontSize() 
		{
			return css.linkbarFontSize;
		}

		// Method to add pages to the list of links
		public void addLink( string fileName, string pageTitle )
		{
			linkSet.addPage( fileName, pageTitle);
		}
	}
}
