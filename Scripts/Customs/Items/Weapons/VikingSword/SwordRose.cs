﻿using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
    [FlipableAttribute(0x13B9, 0x13Ba)]
    public class SwordRose : BaseSword
    {
        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ParalyzingBlow; } }

        public override int AosStrengthReq { get { return 40; } }
        public override int AosSpeed { get { return 28; } }
        public override float MlSpeed { get { return 3.75f; } }

        public override int OldStrengthReq { get { return 40; } }
        public override int OldSpeed { get { return 30; } }

        public override int DefHitSound { get { return 0x237; } }
        public override int DefMissSound { get { return 0x23A; } }


        public override int AosMinDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.VikingSword, DamageTypeEnum.DamageType.AosMinDamage, CraftResource.Rose); } }
        public override int AosMaxDamage { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.VikingSword, DamageTypeEnum.DamageType.AosMaxDamage, CraftResource.Rose); } }
        public override int InitMinHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.VikingSword, DamageTypeEnum.DamageType.InitMinHits, CraftResource.Rose); } }
        public override int InitMaxHits { get { return ItemQualityHelper.GetWeaponDamageByItemQuality(DamageTypeEnum.DamageWeaponType.VikingSword, DamageTypeEnum.DamageType.InitMaxHits, CraftResource.Rose); } }


        [Constructable]
        public SwordRose()
            : base(0x13B9)
        {
            Weight = 6.0;
            Hue = DimensionsNewAge.Scripts.HueOreConst.HueRose;
            Name = "Rose Viking Sword";
        }

        public SwordRose(Serial serial)
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