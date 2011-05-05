/* Model Editor / GeneralRegistry

   Created : 2011-04-07
   Last Modified : 2011-04-27
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class GeneralRegistry
  { private static String UseColorKey = "UseColor" ;
    private static String SaveFilesKey = "SaveFiles" ;
    private static String WaitForExitKey = "WaitOnSolver" ;
    private static String UseTemplateFileKey = "UseTemplateFile" ;
    private static String TemplateFileKey = "TemplateFile" ;
    private static String RestoreFileTreeKey = "RestoreFileTree" ;
    private static String InsertWideFormatKey = "InsertWideFormat" ;

    private static bool UseColorDefault = true ;
    private static bool SaveFilesDefault = true ;
    private static bool WaitForExitDefault = false ;
    private static bool UseTemplateFileDefault = false ;
    private static String TemplateFileDefault = "None" ;
    private static bool RestoreFileTreeDefault = true ;
    private static bool InsertWideFormatDefault = false ;


    public static void SetUseColor (bool State)
    { RegistryManager.SetValue (UseColorKey, (object) State.ToString ()) ;
    }

    public static bool GetUseColor ()
    { if (RegistryManager.HasKey (UseColorKey))
      { String Image = (String) RegistryManager.GetValue (UseColorKey) ;
        return Convert.ToBoolean (Image) ;
      }
      else
      { return UseColorDefault ;
      }
    }

    public static void SetSaveFiles (bool State)
    { RegistryManager.SetValue (SaveFilesKey, (object) State.ToString ()) ;
    }

    public static bool GetSaveFiles ()
    { if (RegistryManager.HasKey (SaveFilesKey))
      { String Image = (String) RegistryManager.GetValue (SaveFilesKey) ;
        return Convert.ToBoolean (Image) ;
      }
      else
      { return SaveFilesDefault ;
      }
    }

    public static void SetWaitForExit (bool State)
    { RegistryManager.SetValue (WaitForExitKey, (object) State.ToString ()) ;
    }

    public static bool GetWaitForExit ()
    { if (RegistryManager.HasKey (WaitForExitKey))
      { String Image = (String) RegistryManager.GetValue (WaitForExitKey) ;
        return Convert.ToBoolean (Image) ;
      }
      else
      { return WaitForExitDefault ;
      }
    }

    public static void SetUseTemplateFile (bool State)
    { RegistryManager.SetValue (UseTemplateFileKey, (object) State.ToString ()) ;
    }

    public static bool GetUseTemplateFile ()
    { if (RegistryManager.HasKey (UseTemplateFileKey))
      { String Image = (String) RegistryManager.GetValue (UseTemplateFileKey) ;
        return Convert.ToBoolean (Image) ;
      }
      else
      { return UseTemplateFileDefault ;
      }
    }

    public static void SetTemplateFile (String Filename)
    { RegistryManager.SetValue (TemplateFileKey, (object) Filename) ;
    }

    public static String GetTemplateFile ()
    { if (RegistryManager.HasKey (TemplateFileKey))
      { return (String) RegistryManager.GetValue (TemplateFileKey) ;
      }
      else
      { return TemplateFileDefault ;
      }
    }

    public static void SetRestoreFileTree (bool State)
    { RegistryManager.SetValue (RestoreFileTreeKey, (object) State.ToString ()) ;
    }

    public static bool GetRestoreFileTree ()
    { if (RegistryManager.HasKey (RestoreFileTreeKey))
      { String Image = (String) RegistryManager.GetValue (RestoreFileTreeKey) ;
        return Convert.ToBoolean (Image) ;
      }
      else
      { return RestoreFileTreeDefault ;
      }
    }

    public static void SetInsertWideFormat (bool State)
    { RegistryManager.SetValue (InsertWideFormatKey, (object) State.ToString ()) ;
    }

    public static bool GetInsertWideFormat ()
    { if (RegistryManager.HasKey (InsertWideFormatKey))
      { String Image = (String) RegistryManager.GetValue (InsertWideFormatKey) ;
        return Convert.ToBoolean (Image) ;
      }
      else
      { return InsertWideFormatDefault ;
      }
    }


  }
}

/* End */
