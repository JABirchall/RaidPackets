
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.BattlePasses;



namespace SharedModel.Meta.DevPopup
{
	[MessagePackObject]
	public class ChangeBattlePassRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public BattlePassTypeId TypeId;
	
		// Constructors
		public ChangeBattlePassRequestDto() {}
	}
}
