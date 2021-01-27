// Decompiled with JetBrains decompiler
// Type: OP_Immersive_Dispatch.ExternalPlugins.BEMS
// Assembly: OP_Immersive_Dispatch, Version=1.5.1.1, Culture=neutral, PublicKeyToken=null
// MVID: D24ACF1F-6E2D-4AD3-BAE8-AC52E607FDCD
// Assembly location: C:\Users\INTEGRAGDR\Desktop\OP_Immersive_Dispatch.dll

using BetterEMS.API;
using Rage;

namespace OP_Immersive_Dispatch.ExternalPlugins
{
  internal static class BEMS
  {
    internal static void RespondToLocation() => EMSFunctions.RespondToLocation(((Entity) Game.get_LocalPlayer().get_Character()).get_Position(), new bool?(true));
  }
}
