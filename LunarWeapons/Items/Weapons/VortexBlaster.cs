using Terraria.ID;
using Terraria.ModLoader;

namespace LunarWeapons.Items.Weapons
{
	public class VortexBlaster : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Blow everything up like it was nothing.Shoots Rocket IVs so dont use in your buildings");
		}

		public override void SetDefaults() 
		{
			item.damage = 190;
			item.ranged = true;
			item.width = 80;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item14;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Rocket;
			item.shootSpeed = 40;
			item.noMelee = true;
			item.useTurn = true;
			item.shoot = 143;
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



