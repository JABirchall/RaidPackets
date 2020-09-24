
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.TrainingCamp
{
	[MessagePackObject]
	public class UserTrainingCampData
	{
		// Fields
		[Json]
		// [Key]
		public List<TrainingCampSlotInfo> Slots;
	
		// Constructors
		public UserTrainingCampData() {}
	}
}
