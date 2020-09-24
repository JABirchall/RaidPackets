
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.DailyUpdates.Entities;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.DailyUpdates.Updaters
{
	public abstract class BaseDailyUpdater
	{
		// Fields
		public DailyUpdateTypeId TypeId;
	
		// Constructors
		protected BaseDailyUpdater() {}
	
		// Methods
		public abstract bool CanUpdate(INormalizableContext cx, DateTime now);
		public abstract void Update(INormalizableContext cx, DateTime now);
	}
}
