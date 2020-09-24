
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Masteries
{
	[MessagePackObject]
	public class HeroMasteryData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<MasteryPointType, int> CurrentAmount;
		[Json]
		// [Key]
		public Dictionary<MasteryPointType, int> TotalAmount;
		[Json]
		// [Key]
		public List<int> Masteries;
		[Json]
		// [Key]
		public int ResetCount;
	
		// Constructors
		public HeroMasteryData() {}
	
		// Methods
		public HeroMasteryData Clone() => default;
		public string ToStringExt() => default;
	}
}
