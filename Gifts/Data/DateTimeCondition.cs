
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Gifts.Data
{
	[MessagePackObject]
	public class DateTimeCondition
	{
		// Fields
		[Json]
		// [Key]
		public readonly DateTime From;
		[Json]
		// [Key]
		public readonly DateTime To;
	
		// Constructors
		public DateTimeCondition() {}
		[SerializationConstructor]
		public DateTimeCondition(DateTime f, DateTime t) {}
	
		// Methods
		public override int GetHashCode() => default;
		public override bool Equals(object obj) => default;
	}
}
