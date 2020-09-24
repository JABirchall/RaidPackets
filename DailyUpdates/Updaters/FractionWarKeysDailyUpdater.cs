
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.DailyUpdates.Updaters
{
	public class FractionWarKeysDailyUpdater : BaseDailyUpdater
	{
		// Fields
		private readonly IEnumerable<ResourceTypeId> _resourceTypeIds;
	
		// Constructors
		public FractionWarKeysDailyUpdater() {}
	
		// Methods
		public override bool CanUpdate(INormalizableContext cx, DateTime now) => default;
		public override void Update(INormalizableContext cx, DateTime now) {}
	}
}
