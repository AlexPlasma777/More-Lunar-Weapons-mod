using Terraria.ID;
using Terraria.ModLoader;

namespace LunarWeapons.Items.Weapons
{
	public class SolarFury : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SolarFury"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Strike with the fury of the sun!");
		}

		public override void SetDefaults() 
		{
			item.damage = 250;
			item.melee = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 295;
			item.shootSpeed = 40;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3458, 18);
			recipe.AddIngredient(3467, 10);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}



