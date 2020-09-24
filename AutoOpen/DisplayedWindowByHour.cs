
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.AutoOpen.Settings;



namespace SharedModel.Meta.AutoOpen
{
	[MessagePackObject]
	public class DisplayedWindowByHour
	{
		// Fields
		[Json]
		// [Key]
		public InGameWindowTypeId TypeId;
		[Json]
		// [Key]
		public int SeenCount;
		[Json]
		// [Key]
		public int Hour;
		[Json]
		// [Key]
		public int Day;
	
		// Constructors
		public DisplayedWindowByHour() {}
	
		// Methods
		public override string ToString() => default;
	}
}
