using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x143E, 0x143F )]
	public class HalberdBronze : BasePoleArm
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.WhirlwindAttack; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ConcussionBlow; } }

		public override int AosStrengthReq{ get{ return 95; } }
		public override int AosSpeed{ get{ return 25; } }
		public override float MlSpeed{ get{ return 4.25f; } }

		public override int OldStrengthReq{ get{ return 45; } }
		public override int OldSpeed{ get{ return 25; } }

        public override int AosMinDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Crossbow, DamageTypeEnum.DamageType.AosMinDamage, CraftResource.Bronze); } }
        public override int AosMaxDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Crossbow, DamageTypeEnum.DamageType.AosMaxDamage, CraftResource.Bronze); } }
        public override int InitMinHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Crossbow, DamageTypeEnum.DamageType.InitMinHits, CraftResource.Bronze); } }
        public override int InitMaxHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Crossbow, DamageTypeEnum.DamageType.InitMaxHits, CraftResource.Bronze); } }
  

		[Constructable]
		public HalberdBronze() : base( 0x143E )
		{
			Weight = 16.0;
            Hue = DimensionsNewAge.Scripts.HueOreConst.HueBronze;
            Name = "Bronze Halberd";
		}

        public HalberdBronze(Serial serial)
            : base(serial)
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}