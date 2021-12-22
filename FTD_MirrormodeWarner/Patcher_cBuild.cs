using BrilliantSkies.Ftd.Avatar.Build;
using BrilliantSkies.Ui.Special.InfoStore;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTD_MirrormodeWarner
{
    [HarmonyPatch(typeof(cBuild), "RunUpdate")]
    class Patcher_cBuild
    {
        private static void Postfix()
        {
            int id = cBuild.GetSingleton().GetCC().UniqueId;
            if (!cBuild.GetSingleton().buildMarker.mirror.Info.On)
            {
                InfoStore.Add(id, "<color=red>[WARNING]Mirror mode disabled!!</color>");
            }
            else
            {
                InfoStore.RemoveMessage(id);
            }
        }
    }
}
