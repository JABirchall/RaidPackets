
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.AutoOpen.Groups;



namespace SharedModel.Meta.AutoOpen
{
	[MessagePackObject]
	public class StaticAutoOpenGroupsData
	{
		// Fields
		[Json]
		// [Key]
		public List<AutoOpenGroupType> GroupTypes;
		[Json]
		// [Key]
		public Dictionary<int, int> OpenOffersDisplayLimits;
		[Json]
		// [Key]
		public Dictionary<int, int> GiveOffersDisplayLimits;
	
		// Constructors
		public StaticAutoOpenGroupsData() {}
	}
}
