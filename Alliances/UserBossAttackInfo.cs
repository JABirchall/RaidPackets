
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class UserBossAttackInfo
	{
		// Fields
		[Json]
		// [Key]
		public long Id;
		[Json]
		// [Key]
		public DateTime StartTime;
		[Json]
		// [Key]
		public int InitialHp;
	
		// Constructors
		public UserBossAttackInfo() {}
		public UserBossAttackInfo(long id, DateTime startTime, int initialHp) {}
	}
}
