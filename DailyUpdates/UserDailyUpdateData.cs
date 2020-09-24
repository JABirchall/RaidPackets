
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.DailyUpdates.Entities;



namespace SharedModel.Meta.DailyUpdates
{
	[MessagePackObject]
	public class UserDailyUpdateData
	{
		// Fields
		[Json]
		// [Key]
		public List<DailyUpdate> DailyUpdates;
	
		// Constructors
		public UserDailyUpdateData() {}
	}
}
