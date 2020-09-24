
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.Inbox.Normalization
{
	public class NEventInboxItemHasExpired : NEventUser
	{
		// Fields
		private readonly List<int> _expiredItemIds;
	
		// Constructors
		public NEventInboxItemHasExpired() {} // Dummy constructor
		public NEventInboxItemHasExpired(List<int> expiredItemIds, DateTime time) {}
	
		// Methods
		protected override void PostProcess(INormalizableContext cx, DateTime time) {}
	}
}
