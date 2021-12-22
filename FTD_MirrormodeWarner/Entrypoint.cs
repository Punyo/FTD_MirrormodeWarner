using BrilliantSkies.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTD_MirrormodeWarner
{
    public class Entrypoint : GamePlugin_PostLoad
    {
        public Entrypoint()
        {
        }

        public string name => "FTD_Mirrormodewarner";

        public Version version { get; }

        public bool AfterAllPluginsLoaded()
        {
            return true;
        }

        public void OnLoad()
        {
            Harmony h = new Harmony("com.punyo.mirrormodewarner");
            h.PatchAll();
        }

        public void OnSave()
        {
        }
    }
}
