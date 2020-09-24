
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.TrainingCamp
{
	[MessagePackObject]
	public class TrainingCampSlotInfo
	{
		// Fields
		[Json]
		// [Key]
		public int Index;
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public int HeroId;
		[Json]
		// [Key]
		public DateTime? TrainingStartTime;
	
		// Constructors
		public TrainingCampSlotInfo() {}
	
		// Methods
		public TrainingCampSlotInfo Clone() => default;
	}
}
