using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Config;


namespace MomlobBossMat
{
	public class MomlobBossMat : Mod
	{
        public MomlobBossMat()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void AddRecipeGroups()
        {
			// Mod Calls
			Mod calamity = ModLoader.GetMod("CalamityMod");
			Mod thorium = ModLoader.GetMod("ThoriumMod");



			//   Recipe Group : Wood
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Wood", new int[] {
				ItemID.Wood,
				ItemID.BorealWood,
				ItemID.RichMahogany,
				ItemID.PalmWood,
				ItemID.Ebonwood,
				ItemID.Shadewood,
				ItemID.Pearlwood,
				ItemID.DynastyWood,
				ItemID.SpookyWood
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:Woods", group);
			if (calamity != null)
			{
				RecipeGroup.recipeGroups[RecipeGroup.recipeGroupIDs["MomlobBossMat:Woods"]].ValidItems.Add(calamity.ItemType("Acidwood"));
				RecipeGroup.recipeGroups[RecipeGroup.recipeGroupIDs["MomlobBossMat:Woods"]].ValidItems.Add(calamity.ItemType("AstralMonolith"));
			}
			if (thorium != null)
			{
				RecipeGroup.recipeGroups[RecipeGroup.recipeGroupIDs["MomlobBossMat:Woods"]].ValidItems.Add(thorium.ItemType("YewWood"));
			}

			//   Recipe Group : Honey
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Honey", new int[] {
				ItemID.HoneyBlock,
				ItemID.CrispyHoneyBlock
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:HoneyBlocks", group);

			//   Recipe Group : Ocean
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Ocean Forage", new int[] {
				ItemID.Coral,
				ItemID.Seashell,
				ItemID.Starfish
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:Corals", group);



			//   Recipe Group : Copper / Tin Bar
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Copper Bar", new int[] {
				ItemID.CopperBar,
				ItemID.TinBar
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:CopperBars", group);

			//   Recipe Group : Iron / Lead Bar
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Iron Bar", new int[] {
				ItemID.IronBar,
				ItemID.LeadBar
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:IronBars", group);

			//   Recipe Group : Silver / Tungsten Bar
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Silver Bar", new int[] {
				ItemID.SilverBar,
				ItemID.TungstenBar
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:SilverBars", group);

			//   Recipe Group : Gold / Platinum Bar
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold Bar", new int[] {
				ItemID.GoldBar,
				ItemID.PlatinumBar
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:GoldBars", group);

			//   Recipe Group : Demonite / Crimtane Bar
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Dark Bar", new int[] {
				ItemID.DemoniteBar,
				ItemID.CrimtaneBar
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:EvilBars", group);

			//   Recipe Group : Cobalt / Palladium Bar
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt Bar", new int[] {
				ItemID.CobaltBar,
				ItemID.PalladiumBar
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:CobaltBars", group);

			//   Recipe Group : Mythril / Orichalcum Bar
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Mythril Bar", new int[] {
				ItemID.MythrilBar,
				ItemID.OrichalcumBar
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:MythrilBars", group);

			//   Recipe Group : Adamantite / Titanium Bar
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite Bar", new int[] {
				ItemID.AdamantiteBar,
				ItemID.TitaniumBar
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:AdamantiteBars", group);

			//   Recipe Group : Valadium / Lodestone Ingot
			if (thorium != null)
			{
				group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Beholder Bar", new int[] {
					thorium.ItemType("ValadiumIngot"),
					thorium.ItemType("LodeStoneIngot")
				});
				RecipeGroup.RegisterGroup("MomlobBossMat:BeholderBars", group);
			}

			//   Recipe Group : Gems
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gems", new int[] {
				ItemID.Amethyst,
				ItemID.Topaz,
				ItemID.Sapphire,
				ItemID.Emerald,
				ItemID.Ruby,
				ItemID.Diamond,
				ItemID.Amber
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:Gems", group);
			if (thorium != null)
			{
				RecipeGroup.recipeGroups[RecipeGroup.recipeGroupIDs["MomlobBossMat:Gems"]].ValidItems.Add(thorium.ItemType("Pearl"));
				RecipeGroup.recipeGroups[RecipeGroup.recipeGroupIDs["MomlobBossMat:Gems"]].ValidItems.Add(thorium.ItemType("Opal"));
				RecipeGroup.recipeGroups[RecipeGroup.recipeGroupIDs["MomlobBossMat:Gems"]].ValidItems.Add(thorium.ItemType("Onyx"));
			}



			//   Recipe Group : Lens
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Lens", new int[] {
				ItemID.Lens,
				ItemID.BlackLens
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:Lens", group);
			if (calamity != null)
			{
				RecipeGroup.recipeGroups[RecipeGroup.recipeGroupIDs["MomlobBossMat:Lens"]].ValidItems.Add(calamity.ItemType("BlightedLens"));
			}

			//   Recipe Group : Powder
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Dark Powder", new int[] {
				ItemID.VilePowder,
				ItemID.ViciousPowder
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:EvilPowders", group);

			//   Recipe Group : Evil Materials
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Dark Material", new int[] {
				ItemID.RottenChunk,
				ItemID.Vertebrae
			});
			RecipeGroup.RegisterGroup("MomlobBossMat:EvilMaterials", group);
		}
	}
}
