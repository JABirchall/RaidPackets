
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Ban
{
	[MessagePackObject]
	public class UserBanData
	{
		// Fields
		[Json]
		// [Key]
		public int BanCount;
	
		// Constructors
		public UserBanData() {}
	}
}
