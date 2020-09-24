
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.AutoOpen.Groups;



namespace SharedModel.Meta.AutoOpen.Settings
{
	[MessagePackObject]
	public class AutoOpenGroup
	{
		// Fields
		[Json]
		// [Key]
		public GroupTypeId TypeId;
		[Json]
		// [Key]
		public List<SignInWindowTypeId[]> WindowsByLoginsCountToday;
		[Json]
		// [Key]
		public List<InGameWindow[]> InGameWindowsByLoginsCountToday;
	
		// Constructors
		public AutoOpenGroup() {}
	}
}
