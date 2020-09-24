
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Network
{
	[MessagePackObject]
	public class ResourceErrorHandlingPolicies
	{
		// Fields
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicy Window;
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicy Overlay;
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicy HeroForBattle;
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicy HeroForMetaGame;
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicy Image;
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicy SceneForBattle;
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicy SceneForMetaGame;
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicy Effect;
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicy Bundles;
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicy Sounds;
	
		// Constructors
		public ResourceErrorHandlingPolicies() {}
	}
}
