
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.TrainingCamp.Dtos
{
	[MessagePackObject]
	public class TrainingCampResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public Hero Hero;
		[Json]
		// [Key]
		public DateTime? TrainingStartTime;
		[Json]
		// [Key]
		public int EarnedXp;
	
		// Constructors
		public TrainingCampResponseDto() {}
	}
}
