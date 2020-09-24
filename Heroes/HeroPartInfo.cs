
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class HeroPartInfo
	{
		// Fields
		[Json]
		// [Key]
		public int HeroTypeId;
		[Json]
		// [Key]
		public int PartsNeeded;
	
		// Constructors
		public HeroPartInfo() {}
	}
}
