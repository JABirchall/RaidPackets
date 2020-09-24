
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
	public class FuseHeroInfo
	{
		// Fields
		[Json]
		// [Key]
		public DateTime? AvailableFrom;
		[Json]
		// [Key]
		public DateTime? AvailableTo;
		[Json]
		// [Key]
		public int Count;
	
		// Constructors
		public FuseHeroInfo() {}
		public FuseHeroInfo(DateTime? availableFrom, DateTime? availableTo, int count = 1) {}
	}
}
