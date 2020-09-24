
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AutoOpen.Settings
{
	[MessagePackObject]
	public class InGameWindow
	{
		// Fields
		[Json]
		// [Key]
		public InGameWindowTypeId TypeId;
		[Json]
		// [Key]
		public DisplayCondition[] DisplayConditions;
	
		// Constructors
		public InGameWindow() {}
	}
}
