#region copyright
/* * * * * * * * * * * * * * * * * * * * * * * * * */
/* Carl Zeiss IMT (IZfM Dresden)                   */
/* Softwaresystem PiWeb                            */
/* (c) Carl Zeiss 2015                             */
/* * * * * * * * * * * * * * * * * * * * * * * * * */
#endregion

namespace Common.Data
{
	/// <summary>
	/// Interface f�r Objekte, die eine Liste von Attributen zur Verf�gung stellen.
	/// </summary>
	public interface IAttributeItem
	{
		/// <summary>
		/// Gibt alle Attribute als Feld zur�ck.
		/// </summary>
		DataService.Attribute[] Attributes { get; set; }
	}
}