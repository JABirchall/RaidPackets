
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Battle.AutoBattle
{
	[MessagePackObject]
	public class LogAutoBattleFinishDto
	{
		// Fields
		[Json]
		// [Key]
		public LogRecordAutoBattleType LogType;
		[Json]
		// [Key]
		public AutoBattleStatistics Statistics;
	
		// Constructors
		public LogAutoBattleFinishDto() {}
		public LogAutoBattleFinishDto(LogRecordAutoBattleType logType) {}
	}
}
