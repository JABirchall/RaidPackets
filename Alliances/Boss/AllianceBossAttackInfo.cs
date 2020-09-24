
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Setup;



namespace SharedModel.Meta.Alliances.Boss
{
	[MessagePackObject]
	public class AllianceBossAttackInfo
	{
		// Fields
		[Json]
		// [Key]
		public TeamSetup TeamSetup;
		[Json]
		// [Key]
		public int GivenDamage;
	
		// Constructors
		public AllianceBossAttackInfo() {}
		public AllianceBossAttackInfo(TeamSetup teamSetup, int givenDamage) {}
	}
}
