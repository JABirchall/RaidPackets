
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Artifacts
{
	[MessagePackObject]
	public class SetOfArtifacts
	{
		// Fields
		[Json]
		// [Key]
		public List<Artifact> Artifacts;
	
		// Constructors
		public SetOfArtifacts() {}
		public SetOfArtifacts(List<Artifact> artifacts) {}
		public SetOfArtifacts([System.ParamArray] Artifact[] artifacts) {}
	}
}
