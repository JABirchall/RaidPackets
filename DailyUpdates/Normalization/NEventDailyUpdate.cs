
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.DailyUpdates.Entities;
using SharedModel.Meta.DailyUpdates.Updaters;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.DailyUpdates.Normalization
{
	public class NEventDailyUpdate : NEventUser
	{
		// Fields
		private readonly DailyUpdate _update;
		private readonly BaseDailyUpdater _updater;
	
		// Constructors
		public NEventDailyUpdate() {} // Dummy constructor
		public NEventDailyUpdate(DailyUpdate update, BaseDailyUpdater updater, DateTime time) {}
	
		// Methods
		protected override void PostProcess(INormalizableContext cx, DateTime fromTime) {}
	}
}
