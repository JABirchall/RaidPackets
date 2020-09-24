
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.DailyUpdates.Updaters
{
	public class SeenAmazonIntegrationDailyUpdater : BaseDailyUpdater
	{
		// Constructors
		public SeenAmazonIntegrationDailyUpdater() {}
	
		// Methods
		public override bool CanUpdate(INormalizableContext cx, DateTime now) => default;
		public override void Update(INormalizableContext cx, DateTime now) {}
	}
}
