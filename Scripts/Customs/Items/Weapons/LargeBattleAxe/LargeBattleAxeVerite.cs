using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
    [FlipableAttribute(0x13FB, 0x13FA)]
    public class LargeBattleAxeVerite : BaseAxe
    {
        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.WhirlwindAttack; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.BleedAttack; } }

        public override int AosStrengthReq { get { return 80; } }
        public override int AosSpeed { get { return 29; } }
        public override float MlSpeed { get { return 3.75f; } }

        public override int OldStrengthReq { get { return 40; } }
        public override int OldSpeed { get { return 30; } }

        public override int AosMinDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.LargeBattleAxe, DamageTypeEnum.DamageType.AosMinDamage, CraftResource.Verite); } }
        public override int AosMaxDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.LargeBattleAxe, DamageTypeEnum.DamageType.AosMaxDamage, CraftResource.Verite); } }
        public override int InitMinHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.LargeBattleAxe, DamageTypeEnum.DamageType.InitMinHits, CraftResource.Verite); } }
        public override int InitMaxHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.LargeBattleAxe, DamageTypeEnum.DamageType.InitMaxHits, CraftResource.Verite); } }


        [Constructable]
        public LargeBattleAxeVerite()
            : base(0x13FB)
        {
            Weight = 6.0;
            Hue = DimensionsNewAge.Scripts.HueOreConst.HueBronze;
            Name = "Verite Battle Axe";
        }

        public LargeBattleAxeVerite(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}