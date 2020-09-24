
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Zendesk
{
	[MessagePackObject]
	public class ZendeskSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public long IssueTypeFieldId;
		[Json]
		// [Key]
		public long UserDataFieldId;
	
		// Constructors
		public ZendeskSettings() {}
	}
}
