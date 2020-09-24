
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AutoOpen.Settings
{
	[MessagePackObject]
	public class HourlyDisplayLimit
	{
		// Fields
		[Json]
		// [Key]
		public int Hours;
		[Json]
		// [Key]
		public int Count;
	
		// Constructors
		public HourlyDisplayLimit() {}
	}
}
