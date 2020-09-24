
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Effects;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.Effects.Normalization
{
	public class NEventUserEffectHasExpired : NEventUser
	{
		// Fields
		private readonly List<long> _expiredItemIds;
	
		// Constructors
		public NEventUserEffectHasExpired() {} // Dummy constructor
		public NEventUserEffectHasExpired(List<long> expiredItemIds, DateTime time) {}
	
		// Methods
		protected override void PostProcess(INormalizableContext cx, DateTime time) {}
	}
}
