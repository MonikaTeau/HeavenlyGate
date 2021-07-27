using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyGate.Projectiles
{
	public class gatesword : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("A treasure from the Gate of Babylon");
			Main.projFrames[projectile.type] = 14;
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.aiStyle = 27;
			projectile.timeLeft = 600;
			projectile.magic = true;
			projectile.ignoreWater = true;
		}
	}
}