
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AbTests
{
	[MessagePackObject]
	public class AbTest
	{
		// Fields
		[IgnoreMember]
		[JsonSkip]
		private AbTestType _type;
		[Json]
		// [Key]
		public AbTestTypeId Id;
		[Json]
		// [Key]
		public AbTestGroupId GroupId;
		[Json]
		// [Key]
		public DateTime StartedTime;
		[Json]
		// [Key]
		public AbTestBehaviour Behaviour;
		[Json]
		// [Key]
		public bool ClaimedBonus;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public AbTestType Type { get => default; }
	
		// Constructors
		public AbTest() {}
		public AbTest(AbTestTypeId id, AbTestGroupId groupId, DateTime startedTime) {}
	}
}
