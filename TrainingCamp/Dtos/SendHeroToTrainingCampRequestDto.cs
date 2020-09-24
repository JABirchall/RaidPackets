
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.TrainingCamp.Dtos
{
	[MessagePackObject]
	public class SendHeroToTrainingCampRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int HeroId;
		[Json]
		// [Key]
		public int SlotIndex;
	
		// Constructors
		public SendHeroToTrainingCampRequestDto() {}
	}
}
