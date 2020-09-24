
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Ban
{
	[MessagePackObject]
	public class ChatRoomBanData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<long, BanRecord> RecordsByUserId;
		[IgnoreMember]
		[JsonSkip]
		private readonly TimeSpan BanRecordExpireTime;
	
		// Constructors
		public ChatRoomBanData() {}
	
		// Methods
		public void Add(long userId, DateTime? bannedUntil) {}
		public bool Has(long userId) => default;
		public void Remove(long userId) {}
		private void ShrinkIfNeeded() {}
	}
}
