
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Inbox
{
	[MessagePackObject]
	public class UserInboxData
	{
		// Fields
		[IgnoreMember]
		[JsonSkip]
		private HashSet<int> _ids;
		[Json]
		// [Key]
		public int LastItemId;
		[Json]
		// [Key]
		public List<InboxItem> Items;
	
		// Constructors
		public UserInboxData() {}
	
		// Methods
		public void RememberState() {}
		public List<InboxItem> GetAdded() => default;
	}
}
