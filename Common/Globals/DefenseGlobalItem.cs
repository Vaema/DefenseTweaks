using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DefenseTweaks.Common.Globals;

public class DefenseGlobalItem : GlobalItem
{
    public override bool InstancePerEntity => true;

    public override void SetDefaults(Item entity)
    {
        switch (entity.type)
        {
            // Vortex armor.
            case ItemID.VortexHelmet:
                entity.defense = 18;
                break;
            case ItemID.VortexBreastplate:
                entity.defense = 30;
                break;
            case ItemID.VortexLeggings:
                entity.defense = 22;
                break;

            // Nebula armor.
            case ItemID.NebulaHelmet:
                entity.defense = 18;
                break;
            case ItemID.NebulaBreastplate:
                entity.defense = 26;
                break;
            case ItemID.NebulaLeggings:
                entity.defense = 18;
                break;

            // Stardust armor.
            case ItemID.StardustHelmet:
                entity.defense = 16;
                break;
            case ItemID.StardustBreastplate:
                entity.defense = 24;
                break;
            case ItemID.StardustLeggings:
                entity.defense = 16;
                break;
        }
    }
}