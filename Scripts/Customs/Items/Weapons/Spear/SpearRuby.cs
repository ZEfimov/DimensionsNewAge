using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0xF62, 0xF63 )]
	public class SpearRuby : BaseSpear
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		public override int AosStrengthReq{ get{ return 50; } }
		public override int AosSpeed{ get{ return 42; } }
		public override float MlSpeed{ get{ return 2.75f; } }

		public override int OldStrengthReq{ get{ return 30; } }
		public override int OldSpeed{ get{ return 46; } }

        public override int AosMinDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Spear, DamageTypeEnum.DamageType.AosMinDamage, CraftResource.Ruby); } }
        public override int AosMaxDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Spear, DamageTypeEnum.DamageType.AosMaxDamage, CraftResource.Ruby); } }
        public override int InitMinHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Spear, DamageTypeEnum.DamageType.InitMinHits, CraftResource.Ruby); } }
        public override int InitMaxHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.Spear, DamageTypeEnum.DamageType.InitMaxHits, CraftResource.Ruby); } }

        public override SkillName DefSkill { get { return SkillName.Fencing; } }
        public override WeaponType DefType { get { return WeaponType.Piercing; } }
        public override WeaponAnimation DefAnimation { get { return WeaponAnimation.Pierce1H; } }

		[Constructable]
		public SpearRuby() : base( 0xF62 )
		{
			Weight = 7.0;
            Hue = DimensionsNewAge.Scripts.HueOreConst.HueRuby;
            Name = "Ruby Short Spear";
		}

        public SpearRuby(Serial serial)
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