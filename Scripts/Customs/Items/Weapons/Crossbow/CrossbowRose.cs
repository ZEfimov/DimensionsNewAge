using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0xF50, 0xF4F )]
	public class CrossbowRose : BaseRanged
	{
		public override int EffectID{ get{ return 0x1BFE; } }
		public override Type AmmoType{ get{ return typeof( Bolt ); } }
		public override Item Ammo{ get{ return new Bolt(); } }

		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ConcussionBlow; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }

		public override int AosStrengthReq{ get{ return 35; } }
		public override int AosSpeed{ get{ return 24; } }
		public override float MlSpeed{ get{ return 4.50f; } }

		public override int OldStrengthReq{ get{ return 30; } }
		public override int OldSpeed{ get{ return 18; } }

        public override int AosMinDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Crossbow, DamageTypeEnum.DamageType.AosMinDamage, CraftResource.Rose); } }
        public override int AosMaxDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Crossbow, DamageTypeEnum.DamageType.AosMaxDamage, CraftResource.Rose); } }
        public override int InitMinHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Crossbow, DamageTypeEnum.DamageType.InitMinHits, CraftResource.Rose); } }
        public override int InitMaxHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Crossbow, DamageTypeEnum.DamageType.InitMaxHits, CraftResource.Rose); } }
  

		public override int DefMaxRange{ get{ return 8; } }


		[Constructable]
		public CrossbowRose() : base( 0xF50 )
		{
			Weight = 7.0;
			Layer = Layer.TwoHanded;
            Hue = DimensionsNewAge.Scripts.HueOreConst.HueRose;
            Name = "Rose Crossbow";
		}

        public CrossbowRose(Serial serial)
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