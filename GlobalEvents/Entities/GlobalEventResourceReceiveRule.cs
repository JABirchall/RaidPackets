
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventResourceReceiveRule
	{
		// Fields
		[Json]
		// [Key]
		public ResourceTypeId TypeId;
	
		// Constructors
		public GlobalEventResourceReceiveRule() {}
	
		// Methods
		public bool Satisfies(Account.Resources resources) => default;
		public GlobalEventResourceReceiveRule Clone() => default;
	}
}
