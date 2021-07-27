using HeavenlyGate.Projectiles;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyGate.Items
{
	public class Gate : ModItem
	{
		public override string Texture => "Terraria/Item_" + ItemID.SkyFracture;

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The very gate of Babylon before your eyes.");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.useTime = 25;
			item.useAnimation = 25;
			item.shootSpeed = 16f;
			item.knockBack = 6f;
			item.width = 16;
			item.height = 16;
			item.damage = 38;
			item.UseSound = SoundID.Item9;
			item.crit = 20;
			item.shoot = 660;
			item.mana = 7;
			item.rare = 4;
			item.shoot = 660;
			item.value = 300000;
			item.noMelee = true;
			item.magic = true;
			item.autoReuse = true;
			item.reuseDelay = 14;
		}
		public override bool Shoot()
        {
			float numberProjectiles = 3 + Main.rand.Next(3); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(45);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
	}
}