
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.AutoOpen.Conditions;



namespace SharedModel.Meta.AutoOpen.Groups
{
	[MessagePackObject]
	public class Condition
	{
		// Fields
		[Json]
		// [Key]
		public LevelCondition Level;
		[Json]
		// [Key]
		public LifeTimeValueCondition LifeTimeValue;
		[Json]
		// [Key]
		public DaysSinceRegistrationCondition RegistrationDays;
		[Json]
		// [Key]
		public DaysSinceLastSessionCondition LastSessionDays;
		[Json]
		// [Key]
		public InClanCondition InClanCondition;
	
		// Constructors
		public Condition() {}
	}
}
