
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalMessages
{
	[MessagePackObject]
	public class DiscussionAction
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public string DiscussionLink;
		[Json]
		// [Key]
		public int MinUserLevel;
	
		// Constructors
		public DiscussionAction() {}
	}
}
