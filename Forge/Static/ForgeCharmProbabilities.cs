
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Forge.Static
{
	[MessagePackObject]
	public class ForgeCharmProbabilities
	{
		// Fields
		[Json]
		// [Key]
		public readonly Dictionary<ForgeCharmProbabilitiesTypeId, Dictionary<int, double>> RawProbabilities;
	
		// Constructors
		public ForgeCharmProbabilities() {}
		[SerializationConstructor]
		public ForgeCharmProbabilities(Dictionary<ForgeCharmProbabilitiesTypeId, Dictionary<int, double>> p) {}
		public ForgeCharmProbabilities(ForgeCharmProbabilitiesTypeId type, Dictionary<int, double> values) {}
	
		// Methods
		public Dictionary<int, double> GetProbabilities(ForgeCharmProbabilitiesTypeId type) => default;
		public ForgeCharmProbabilities Add(ForgeCharmProbabilitiesTypeId type, Dictionary<int, double> values) => default;
	}
}
