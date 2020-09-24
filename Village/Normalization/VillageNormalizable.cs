
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.Village.Normalization
{
	public class VillageNormalizable : UserNormalizable<SharedModel.Meta.Village.Normalization.VillageNormalizable>
	{
		// Constructors
		public VillageNormalizable() {}
	
		// Methods
		public override INEvent<INormalizableContext> GetNextEvent(INormalizableContext cx, DateTime time) => default;
	}
}
