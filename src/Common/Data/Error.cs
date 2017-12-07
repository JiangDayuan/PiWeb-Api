﻿#region copyright
/* * * * * * * * * * * * * * * * * * * * * * * * * */
/* Carl Zeiss IMT (IZfM Dresden)                   */
/* Softwaresystem PiWeb                            */
/* (c) Carl Zeiss 2015                             */
/* * * * * * * * * * * * * * * * * * * * * * * * * */
#endregion

namespace Common.Data
{
	#region using

	using System;

	#endregion

	/// <summary> 
	/// Class holds an error which can occur on calling a webservice method. 
	/// </summary>
	public class Error
	{
		#region constructor

		/// <summary> 
		/// Constructor 
		/// </summary>
		public Error()
		{
			Message = "";
		}

		/// <summary> 
		/// Constructor 
		/// </summary>
		public Error( string message )
		{
			Message = message;
		}

		/// <summary> 
		/// Constructor 
		/// </summary>
        public Error( Exception ex )
		{
			Message = ex.Message;

			if( ex.InnerException != null )
				InnerError = new Error( ex.InnerException );
		}

		#endregion

		#region properties

		/// <summary> 
		/// Returns the error description message.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// The nested <see cref="Error"/> instance that triggered the current error.
		/// </summary>
		public Error InnerError { get; set; }

		#endregion

		#region methods

		/// <summary>
		/// Overridden <see cref="System.Object.ToString"/> method.
		/// </summary>
		public override string ToString()
		{
			return Message;
		}

		#endregion
	}
}