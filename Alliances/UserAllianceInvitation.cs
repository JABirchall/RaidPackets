
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
	public class UserAllianceInvitation
	{
		// Fields
		[Json]
		// [Key]
		public long AllianceId;
		[Json]
		// [Key]
		public long InviterUserId;
		[Json]
		// [Key]
		public DateTime Date;
	
		// Constructors
		public UserAllianceInvitation() {}
	}
}
