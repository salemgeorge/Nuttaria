using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace weDonthaveaNameyet.Items
{
	public class sdfdsgdfg : ModItem
	{
		bool isElemental = true;
		Elements.Element element = Elements.Element.Fire;

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("sdfdsgdfg"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults()
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
			foreach(TooltipLine line in tooltips)
			{
				if (line.Name == "Damage" && line.Mod == "Terraria")
				{
					string[] split = line.Text.Split(' ');
					line.Text = split[0] + " " + element.elementName.ToLower() + " " + split[split.Length - 1];
					//line.Text = "Test";
					break;
				}
            }
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}