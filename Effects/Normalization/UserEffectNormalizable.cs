
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.Effects.Normalization
{
	public class UserEffectNormalizable : UserNormalizable<SharedModel.Meta.Effects.Normalization.UserEffectNormalizable>
	{
		// Constructors
		public UserEffectNormalizable() {}
	
		// Methods
		public override INEvent<INormalizableContext> GetNextEvent(INormalizableContext cx, DateTime time) => default;
	}
}
