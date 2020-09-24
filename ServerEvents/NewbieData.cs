
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.ServerEvents
{
	[MessagePackObject]
	public class NewbieData : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public double LifeTimeInHours;
	
		// Constructors
		public NewbieData() {}
	
		// Methods
		public int CalcHash() => default;
	}
}
