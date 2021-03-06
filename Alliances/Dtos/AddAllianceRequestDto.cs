﻿
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances.Dtos
{
	[MessagePackObject]
	public class AddAllianceRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public long AllianceId;
		[Json]
		// [Key]
		public string Message;
	
		// Constructors
		public AddAllianceRequestDto() {}
	}
}
