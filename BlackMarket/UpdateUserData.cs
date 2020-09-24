
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class UpdateUserData
	{
		// Fields
		[Json]
		// [Key]
		public UpdateUserType Type;
	
		// Constructors
		public UpdateUserData() {}
	}
}
