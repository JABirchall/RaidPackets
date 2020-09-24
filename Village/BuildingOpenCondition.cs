
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
	public class BuildingOpenCondition
	{
		// Fields
		[Json]
		// [Key]
		public int UserLevelRequired;
		[Json]
		// [Key]
		public int RevealUserLevel;
	
		// Constructors
		public BuildingOpenCondition() {}
		public BuildingOpenCondition(int userLevelRequired, int revealUserLevel) {}
	}
}
