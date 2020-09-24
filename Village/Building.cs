
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
	public class Building
	{
		// Fields
		[Json]
		// [Key]
		public BuildingTypeId Id;
		[Json]
		// [Key]
		public int Level;
		[IgnoreMember]
		[JsonSkip]
		private BuildingType _type;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public BuildingType Type { get => default; }
	
		// Constructors
		public Building() {}
	}
}
