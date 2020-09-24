
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Normalization;
using SharedModel.Meta.Subscriptions.Data;



namespace SharedModel.Meta.Subscriptions.Normalization
{
	public class UserSubscriptionNormalizable : UserNormalizable<SharedModel.Meta.Subscriptions.Normalization.UserSubscriptionNormalizable>
	{
		// Constructors
		public UserSubscriptionNormalizable() {}
	
		// Methods
		public override INEvent<INormalizableContext> GetNextEvent(INormalizableContext cx, DateTime time) => default;
	}
}
