
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Languages;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceMembershipData
	{
		// Fields
		[Json]
		// [Key]
		public List<AllianceMember> Members;
		[Json]
		// [Key]
		public int MembersLimit;
		[Json]
		// [Key]
		public int RequiredMemberLevel;
		[Json]
		// [Key]
		public Language LanguageId;
		[Json]
		// [Key]
		public bool IsOpen;
		[Json]
		// [Key]
		public List<AllianceRequest> RequestsReceived;
		[Json]
		// [Key]
		public List<AllianceInvitation> InvitationsSent;
		[Json]
		// [Key]
		public Dictionary<long, DateTime> RemovedMembers;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int TotalPower { get => default; }
	
		// Constructors
		public AllianceMembershipData() {}
	
		// Methods
		public AllianceMember GetLeader() => default;
		public bool IsMember(long userId) => default;
		public int GetTotalStars(DateTime date) => default;
		public List<long> GetActiveMembersIds() => default;
		public IEnumerable<AllianceMember> EnumerateActiveMembers(DateTime currentDate) => default;
	}
}
