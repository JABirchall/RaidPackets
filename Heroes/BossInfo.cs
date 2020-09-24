
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class BossInfo
	{
		// Constructors
		public BossInfo() {}
	
		// Methods
		private bool Equals(BossInfo other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}
}
