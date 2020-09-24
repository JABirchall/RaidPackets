
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.DailyUpdates.Entities;
using SharedModel.Meta.DailyUpdates.Updaters;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.DailyUpdates.Normalization
{
	public class UserDailyUpdatesNormalizable : UserNormalizable<SharedModel.Meta.DailyUpdates.Normalization.UserDailyUpdatesNormalizable>
	{
		// Fields
		public readonly Dictionary<DailyUpdateTypeId, BaseDailyUpdater> UpdatersById;
	
		// Constructors
		public UserDailyUpdatesNormalizable() {}
	
		// Methods
		public override INEvent<INormalizableContext> GetNextEvent(INormalizableContext cx, DateTime time) => default;
	}
}
