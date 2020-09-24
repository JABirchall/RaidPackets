
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.Inbox.Normalization
{
	public class InboxNormalizable : UserNormalizable<SharedModel.Meta.Inbox.Normalization.InboxNormalizable>
	{
		// Constructors
		public InboxNormalizable() {}
	
		// Methods
		public override INEvent<INormalizableContext> GetNextEvent(INormalizableContext cx, DateTime time) => default;
	}
}
