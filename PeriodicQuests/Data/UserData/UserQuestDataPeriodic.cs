
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.PeriodicQuests.Data.UserData
{
	[MessagePackObject]
	public class UserQuestDataPeriodic
	{
		// Fields
		[Json]
		// [Key]
		public List<UserPeriodicQuestGroupData> Groups;
	
		// Constructors
		public UserQuestDataPeriodic() {}
	}
}
