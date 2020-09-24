
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AutoOpen.Groups
{
	[MessagePackObject]
	public class AutoOpenGroupType
	{
		// Fields
		[Json]
		// [Key]
		public GroupTypeId Id;
		[Json]
		// [Key]
		public List<Condition> Conditions;
	
		// Constructors
		public AutoOpenGroupType() {}
	}
}
