
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Numerics;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Artifacts
{
	[MessagePackObject]
	public class BonusValue
	{
		// Fields
		[Json]
		// [Key]
		public bool IsAbsolute;
		[Json]
		// [Key]
		public Fixed Value;
	
		// Constructors
		public BonusValue() {}
		public BonusValue(bool isAbsolute, Fixed value) {}
		public BonusValue(bool isAbsolute, double value) {}
		public BonusValue(BonusValue src) {}
	
		// Methods
		public void SetValue(double value) {}
		public void AddValue(double value) {}
		public BonusValue Clone() => default;
		public override int GetHashCode() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(BonusValue other) => default;
		public override string ToString() => default;
		public int PrintableValue() => default;
	}
}
