
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Normalization
{
	public abstract class UserNormalizable : INormalizable<SharedModel.Meta.Normalization.INormalizableContext>
	{
		// Constructors
		protected UserNormalizable() {}
	
		// Methods
		INEvent<INormalizableContext> INormalizable<INormalizableContext>.GetNextEvent(INormalizableContext cx, DateTime time) => default;
		public abstract INEventUser GetNextEvent(INormalizableContext cx, DateTime time);
	}
}
