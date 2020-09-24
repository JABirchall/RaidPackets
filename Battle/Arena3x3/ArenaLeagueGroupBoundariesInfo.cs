
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Battle.Arena3x3
{
	[MessagePackObject]
	public class ArenaLeagueGroupBoundariesInfo
	{
		// Fields
		[Json]
		// [Key]
		public int LowGroupBoundaryMin;
		[Json]
		// [Key]
		public int LowGroupBoundaryMax;
		[Json]
		// [Key]
		public int MidGroupBoundaryMin;
		[Json]
		// [Key]
		public int MidGroupBoundaryMax;
		[Json]
		// [Key]
		public int HighGroupBoundaryMin;
		[Json]
		// [Key]
		public int HighGroupBoundaryMax;
	
		// Constructors
		public ArenaLeagueGroupBoundariesInfo() {}
		public ArenaLeagueGroupBoundariesInfo(int lowGroupMin, int lowGroupMax, int midGroupMin, int midGroupMax, int highGroupMin, int highGroupMax) {}
	}
}
