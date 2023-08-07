using Godot;

namespace Struct
{
	//base class from which all data classes can derive
	public abstract class InterfaceData : Node
	{
		//abstract property so each subclass can supply different data
		public abstract string[] Data { get; }
	}
}
