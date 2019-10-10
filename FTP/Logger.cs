using System;

namespace FTP
{
	/// <summary>
	/// Event arg to hold and retrieve the message
	/// </summary>
	public class LogInfoEventArgs : EventArgs
	{
		private string message;		// private member variable

		// property
		public string Message { get { return message; } }

		// constructor
		public LogInfoEventArgs(string message)
		{
			this.message = message;
		}
	}

	/// <summary>
	/// Logger object raises OnLoggableEvent when Write method is called
	/// </summary>
	public class Logger
	{
		// declare the event
		public delegate void LoggableEventHandler(object o, LogInfoEventArgs e);
		public event LoggableEventHandler OnLoggableEvent = null;

		/// <summary>
		/// Takes a string, creates an instance of LogInfoEventArgs and 
		/// raises the event
		/// </summary>
		/// <param name="o">the object raising the event</param>
		/// <param name="msg">the message to be logged</param>
		public void Write(object o, string msg)
		{
			if ( OnLoggableEvent != null )
			{
				LogInfoEventArgs e = new LogInfoEventArgs(msg);
				OnLoggableEvent(o,e);
			}
		}
	}
}
