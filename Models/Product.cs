//Programmer name: C. Mathole

namespace DatabaseApplication.Models
{
	public class Product
	{
		public int Id
		{
			//
			//Name				: property int Id
			//Purpose			: Automatic public property to give access to 
			//					  corresponding compiler generated field
			//Re-Use			: none
			//Input Parameter	: int value
			//Output Type		: int
			//					- value stored in the corresponding compiler
			//					  generated field
			//
			get; set;
		} // end property
		public string Name
		{
			//
			//Name				: property string Name
			//Purpose			: Automatic public property to give access to 
			//					  corresponding compiler generated field
			//Re-Use			: none
			//Input Parameter	: string value
			//Output Type		: string
			//					- value stored in the corresponding compiler
			//					  generated field
			//
			get; set;
		} // end property
		public double Price
		{
			//
			//Name				: property double Price
			//Purpose			: Automatic public property to give access to 
			//					  corresponding compiler generated field
			//Re-Use			: none
			//Input Parameter	: double value
			//Output Type		: double
			//					- value stored in the corresponding compiler
			//					  generated field
			//
			get; set;
		} // end property
	} // end class
} // end namespace