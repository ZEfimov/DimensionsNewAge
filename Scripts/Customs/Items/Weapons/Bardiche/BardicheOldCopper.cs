using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0xF4D, 0xF4E )]
	public class BardicheOldCopper : BasePoleArm
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Dismount; } }

		public override int AosStrengthReq{ get{ return 45; } }
		public override int AosSpeed{ get{ return 28; } }
		public override float MlSpeed{ get{ return 3.75f; } }

		public override int OldStrengthReq{ get{ return 40; } }
		public override int OldSpeed{ get{ return 26; } }

        public override int AosMinDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Bardiche, DamageTypeEnum.DamageType.AosMinDamage, CraftResource.OldCopper); } }
        public override int AosMaxDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Bardiche, DamageTypeEnum.DamageType.AosMaxDamage, CraftResource.OldCopper); } }

        public override int InitMinHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Bardiche, DamageTypeEnum.DamageType.InitMinHits, CraftResource.OldCopper); } }
        public override int InitMaxHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Bardiche, DamageTypeEnum.DamageType.InitMaxHits, CraftResource.OldCopper); } }
  

		[Constructable]
		public BardicheOldCopper() : base( 0xF4D )
		{
			Weight = 7.0;
            Hue = DimensionsNewAge.Scripts.HueOreConst.HueOldCopper;
            Name = "OldCopper Bardiche";
		}

        public BardicheOldCopper(Serial serial)
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