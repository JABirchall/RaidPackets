
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Artifacts.Bonuses
{
	[MessagePackObject]
	public class SecArtifactBonusValue
	{
		// Fields
		[Json]
		// [Key]
		public double FromValue;
		[Json]
		// [Key]
		public double ToValue;
	
		// Constructors
		public SecArtifactBonusValue() {}
		public SecArtifactBonusValue(double fromValue, double toValue) {}
	}
}
