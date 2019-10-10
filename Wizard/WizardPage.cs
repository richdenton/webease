/// <summary>
///  WEBEASE
///  Copyright (C) 2006 Kaged Koncepts
///  
///  Wizard Library - WizardPage Class
///  In WebEase, each step is a new page inherited from this class.
///  WizardPage is an empty filler control for which each step draws
///  from to comminicate with the Wizard class.
/// </summary>

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Wizard
{
	// Summary description for WizardPage.
	public class WizardPage : System.Windows.Forms.UserControl
	{
		// Required designer variable.
		private System.ComponentModel.Container components = null;

		public WizardPage()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			// Clean up any resources being used.
			if( disposing && (components != null)) components.Dispose();
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}
