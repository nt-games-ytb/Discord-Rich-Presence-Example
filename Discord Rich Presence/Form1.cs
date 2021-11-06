using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRpcDemo;

namespace Discord_Rich_Presence
{
    public partial class Form1 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bot ID
            handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("771693869087064064", ref handlers, true, null);

            //Text
            presence.details = "Poop Mod Injector by nt games";
            presence.state = "Discord Rich Presence Test";

            //Image
            presence.largeImageKey = "poop";
            presence.smallImageKey = "minecraft";
            presence.largeImageText = "Poop Injector";
            presence.smallImageText = "Minecraft";

            //Time
            DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long startTimestamp = (long)(DateTime.UtcNow - d).TotalSeconds;
            presence.startTimestamp = startTimestamp;

            //Update
            DiscordRpc.UpdatePresence(ref presence);
        }
    }
}
