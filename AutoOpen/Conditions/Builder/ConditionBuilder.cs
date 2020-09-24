
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.AutoOpen.Groups;



namespace SharedModel.Meta.AutoOpen.Conditions.Builder
{
	public class ConditionBuilder
	{
		// Fields
		private readonly AutoOpenGroupType _type;
	
		// Constructors
		public ConditionBuilder() {} // Dummy constructor
		public ConditionBuilder(AutoOpenGroupType type) {}
	
		// Methods
		public ConditionBuilder With(Action<Condition> build) => default;
	}
}
