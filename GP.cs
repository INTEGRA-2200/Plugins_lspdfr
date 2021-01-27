// Decompiled with JetBrains decompiler
// Type: OP_Immersive_Dispatch.ExternalPlugins.GP
// Assembly: OP_Immersive_Dispatch, Version=1.5.1.1, Culture=neutral, PublicKeyToken=null
// MVID: D24ACF1F-6E2D-4AD3-BAE8-AC52E607FDCD
// Assembly location: C:\Users\INTEGRAGDR\Desktop\OP_Immersive_Dispatch.dll

using GrammarPolice.Actions;
using GrammarPolice.API;

namespace OP_Immersive_Dispatch.ExternalPlugins
{
  internal static class GP
  {
    internal static void TrafficStop() => Functions.TrafficStop(false, false);

    internal static void Busy() => Functions.Busy(false, false);

    internal static void Available() => Functions.Available(false, false);

    internal static void Investigating() => Functions.Investigating(false, false);

    internal static void ReturnToStation() => Functions.ReturnToStation(false, false);

    internal static void Scene() => Functions.Scene(false, false);

    internal static void Code4() => Status.Code4();

    internal static void Panic() => Functions.Panic();

    internal static void Pursuit() => Functions.InPursit(false, false);
  }
}
