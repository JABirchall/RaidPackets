
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Village
{
	[MessagePackObject]
	public class GemsMineInfo
	{
		// Fields
		[Json]
		// [Key]
		public int GemsCapacity;
		[Json]
		// [Key]
		public double GemsPerHour;
	
		// Constructors
		public GemsMineInfo() {}
	}
}
