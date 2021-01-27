// Decompiled with JetBrains decompiler
// Type: OP_Immersive_Dispatch.ExternalPlugins.STP
// Assembly: OP_Immersive_Dispatch, Version=1.5.1.1, Culture=neutral, PublicKeyToken=null
// MVID: D24ACF1F-6E2D-4AD3-BAE8-AC52E607FDCD
// Assembly location: C:\Users\INTEGRAGDR\Desktop\OP_Immersive_Dispatch.dll

using StopThePed.API;

namespace OP_Immersive_Dispatch.ExternalPlugins
{
  internal static class STP
  {
    internal static void callPoliceTransport() => Functions.callPoliceTransport();

    internal static void callTowService() => Functions.callTowService();

    internal static void callInsuranceCompany() => Functions.callInsuranceService();

    internal static void callAnimalControl() => Functions.callAnimalControl();

    internal static void requestDispatchPedCheck() => Functions.requestDispatchPedCheck(false);

    internal static void requestDispatchVehiclePlateCheck() => Functions.requestDispatchVehiclePlateCheck(false);

    internal static void callCoronerService() => Functions.callCoroner();
  }
}
