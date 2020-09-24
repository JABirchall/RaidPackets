
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceChatRoomData
	{
		// Fields
		[Json]
		// [Key]
		public string Name;
		[Json]
		// [Key]
		public List<AllianceMemberRankId> AllowedRanks;
		[Json]
		// [Key]
		public Dictionary<long, AllianceChatBannedMember> BannedMembers;
	
		// Constructors
		public AllianceChatRoomData() {}
		public AllianceChatRoomData(string name, IEnumerable<AllianceMemberRankId> ranks) {}
	}
}
