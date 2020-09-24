
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
	public class AllianceChatBannedMember
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public DateTime BannedUntil;
	
		// Constructors
		public AllianceChatBannedMember() {}
		public AllianceChatBannedMember(long userId) {}
	}
}
