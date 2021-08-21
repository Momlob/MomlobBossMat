using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace Config 
{
	public class MainConfig : ModConfig 
	{
		public const string ConfigName = "Crafty Boss Drops";
		public override ConfigScope Mode => ConfigScope.ServerSide;



		[Header("Altered Drops")]

		[Label("Keep Random Drops")]
		[Tooltip("Wether Bosses should keep their Drops. (Only active if corresponding Material is enabled.)")]
		[DefaultValue(false)]
		public bool OldDrops;

		[Slider]
		[Label("Multiplicator")]
		[Tooltip("Multiplies dropped Materials, making Bosses drop more Material.")]
		[Increment(1)]
		[Range(1, 10)]
		[DefaultValue(1)]
		public int Multiplier;

		internal void OnDeserializedMethod(StreamingContext context)
		{
			Multiplier = Utils.Clamp(Multiplier, 1, 10);
		}

		

		[Header("Enabled Materials")]

		[ReloadRequired]
		[Label("Boss Materials")]
		[Tooltip("Enables Materials for regular Bosses.")]
		[DefaultValue(true)]
		public bool EnableBoss;

		[ReloadRequired]
		[Label("Event Materials")]
		[Tooltip("Enables Materials for Events and respective Bosses.")]
		[DefaultValue(true)]
		public bool EnableEvent;
		/*
		[ReloadRequired]
		[Label("Miniboss Materials")]
		[Tooltip("Enables Materials for Minibosses.")]
		[DefaultValue(true)]
		public bool EnableMiniboss;
		*/


		[Header("Enabled Mods")]
		/*
		[ReloadRequired]
		[Label("Calamity Support")]
		[Tooltip("Enables Calamity Summons and Ingredients.")]
		[DefaultValue(true)]
		public bool EnableCalamity;
		*/
		[ReloadRequired]
		[Label("Thorium Support")]
		[Tooltip("Enables Ingredients for Thorium Bosses.")]
		[DefaultValue(true)]
		public bool EnableThorium;
	}
}