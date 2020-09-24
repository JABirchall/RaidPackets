
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalMessages
{
	[MessagePackObject]
	public class ClientAction
	{
		// Fields
		[Json]
		// [Key]
		public ClientActionType Type;
		[Json]
		// [Key]
		public string ArgStr;
		[Json]
		// [Key]
		public int? ArgInt;
		[Json]
		// [Key]
		public int? ArgInt2;
	
		// Constructors
		public ClientAction() {}
	}
}
