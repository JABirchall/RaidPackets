
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class TriggerOfferDto
	{
		// Fields
		[Json]
		// [Key]
		public TriggerOfferKindId TypeId;
		[Json]
		// [Key]
		public int Revision;
		[Json]
		// [Key]
		public int RuleId;
	
		// Constructors
		public TriggerOfferDto() {}
	
		// Methods
		public TriggerOfferDto Clone() => default;
	}
}
