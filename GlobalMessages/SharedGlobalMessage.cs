
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
	public class SharedGlobalMessage
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public GlobalMessageType Type;
		[Json]
		// [Key]
		public string Header;
		[Json]
		// [Key]
		public string PreviewText;
		[Json]
		// [Key]
		public string Text;
		[Json]
		// [Key]
		public string PathToImage;
		[Json]
		// [Key]
		public string PathToPreviewImage;
		[Json]
		// [Key]
		public bool BigImage;
		[Json]
		// [Key]
		public ClientAction ActionOnRead;
		[Json]
		// [Key]
		public DiscussionAction Discussion;
		[Json]
		// [Key]
		public ShowOnLoginMode ShowMode;
		[Json]
		// [Key]
		public DateTime? CreationDate;
	
		// Constructors
		public SharedGlobalMessage() {}
	}
}
