
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Normalization
{
	public abstract class AllianceNormalizable : INormalizable<SharedModel.Meta.Normalization.INormalizableContext>
	{
		// Constructors
		protected AllianceNormalizable() {}
	
		// Methods
		INEvent<INormalizableContext> INormalizable<INormalizableContext>.GetNextEvent(INormalizableContext cx, DateTime time) => default;
		public abstract INEventAlliance GetNextEvent(INormalizableContext cx, DateTime time);
	}
}
