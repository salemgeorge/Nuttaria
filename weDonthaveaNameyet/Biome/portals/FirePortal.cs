using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SubworldLibrary;
using weDonthaveaNameyet.Biome.Subworlds;

namespace weDonthaveaNameyet.Biome.portals;

public class FirePortal : ModNPC
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("fireportal"); // The display name of the NPC.
        Main.npcFrameCount[NPC.type] = Main.npcFrameCount[NPCID.DD2LanePortal]; // Use the statue sprite as a placeholder.
    }

    public override void SetDefaults()
    {
        NPC.width = 18; // The width of the NPC's hitbox.
        NPC.height = 40; // The height of the NPC's hitbox.
        NPC.aiStyle = -1; // Custom AI, so we set this to -1.
        NPC.damage = 0; // The NPC doesn't deal any damage.
        NPC.defense = 25; // The NPC's defense.
        NPC.lifeMax = 250; // The NPC's maximum health.
        NPC.knockBackResist = 0f; // The NPC doesn't get knocked back.
        NPC.dontTakeDamage = true; // The NPC doesn't take any damage.
        NPC.townNPC = true; // This is a town NPC.
        NPC.friendly = true; // The NPC is friendly.
    }

    public override List<string> SetNPCNameList()
    {
        return new List<string>()
        {
            "???"
        };
    }

    public override void SetChatButtons(ref string button, ref string button2)
    {
        button = "???";
    }

    public override void OnChatButtonClicked(bool firstButton, ref bool shop)
    {
        SubworldSystem.Enter<FireSubworld>();
    }

    public override bool CanChat() => true;

    public bool NeedsSaving() => true;

    public override void ModifyTypeName(ref string typeName) => typeName = "fireportal";
    
}