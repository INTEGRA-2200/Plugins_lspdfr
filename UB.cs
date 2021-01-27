// Decompiled with JetBrains decompiler
// Type: OP_Immersive_Dispatch.ExternalPlugins.UB
// Assembly: OP_Immersive_Dispatch, Version=1.5.1.1, Culture=neutral, PublicKeyToken=null
// MVID: D24ACF1F-6E2D-4AD3-BAE8-AC52E607FDCD
// Assembly location: C:\Users\INTEGRAGDR\Desktop\OP_Immersive_Dispatch.dll

using UltimateBackup.API;

namespace OP_Immersive_Dispatch.ExternalPlugins
{
  internal static class UB
  {
    internal static void callCode2Backup() => Functions.callCode2Backup(false);

    internal static void callCode2BackupState() => Functions.callCode2Backup(false, true);

    internal static void callCode3Backup() => Functions.callCode3Backup(false);

    internal static void callCode3BackupState() => Functions.callCode3Backup(false, true);

    internal static void callFemaleBackup() => Functions.callFemaleBackup();

    internal static void callK9Backup() => Functions.callK9Backup();

    internal static void callTrafficStopBackup() => Functions.callTrafficStopBackup();

    internal static void callFelonyStopBackup() => Functions.callFelonyStopBackup();

    internal static void callPursuitBackup() => Functions.callPursuitBackup(false);

    internal static void callGroupBackup() => Functions.callGroupBackup(false);

    internal static void callPanicButtonBackup() => Functions.callPanicButtonBackup(false);

    internal static void callAmbulance() => Functions.callAmbulance();

    internal static void callFireDepartment() => Functions.callFireDepartment();
  }
}
