/* Model Editor / RunRegistry

   Created : 2011-04-04
   Last Modified : 2011-04-17
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class RunRegistry
  { public static String ModelDefault = "HumMod.DES" ;
    public static String ModelKey = "Model Root File" ;

    public static String ControllerDefault = "Model Controller.EXE" ;
    public static String ControllerKey = "Model Controller" ;

    public static String SolverDefault = "Model Solver.EXE" ;
    public static String SolverKey = "Model Solver" ;

    public static String CombinedDefault = "HumMod.EXE" ;
    public static String CombinedKey = "Combined Controller Solver" ;

    public static String IsModularDefault = "true" ;
    public static String IsModularKey = "IsModular" ;

    public static void SetModel (String NameArg)
    { RegistryManager.SetValue (ModelKey, (object) NameArg) ;
    }

    public static String GetModel ()
    { if (RegistryManager.HasKey (ModelKey))
      { return (String) RegistryManager.GetValue (ModelKey) ;
      }
      else
      { return ModelDefault ;
      }
    }

    public static String GetDefaultModel ()
    { return ModelDefault ;
    }

    public static void SetController (String NameArg)
    { RegistryManager.SetValue (ControllerKey, (object) NameArg) ;
    }

    public static String GetController ()
    { if (RegistryManager.HasKey (ControllerKey))
      { return (String) RegistryManager.GetValue (ControllerKey) ;
      }
      else
      { return ControllerDefault ;
      }
    }

    public static String GetDefaultController ()
    { return ControllerDefault ;
    }

    public static void SetSolver (String NameArg)
    { RegistryManager.SetValue (SolverKey, (object) NameArg) ;
    }

    public static String GetSolver ()
    { if (RegistryManager.HasKey (SolverKey))
      { return (String) RegistryManager.GetValue (SolverKey) ;
      }
      else
      { return SolverDefault ;
      }
    }

    public static String GetDefaultSolver ()
    { return SolverDefault ;
    }

    public static void SetCombined (String NameArg)
    { RegistryManager.SetValue (CombinedKey, (object) NameArg) ;
    }

    public static String GetCombined ()
    { if (RegistryManager.HasKey (CombinedKey))
      { return (String) RegistryManager.GetValue (CombinedKey) ;
      }
      else
      { return CombinedDefault ;
      }
    }

    public static String GetDefaultCombined ()
    { return CombinedDefault ;
    }

    public static void SetIsModular (bool State)
    { RegistryManager.SetValue (IsModularKey, (object) State.ToString ()) ;
    }

    public static bool GetIsModular ()
    { if (RegistryManager.HasKey (IsModularKey))
      { String Image = (String) RegistryManager.GetValue (IsModularKey) ;
        return Convert.ToBoolean (Image) ;
      }
      else
      { return Convert.ToBoolean (IsModularDefault) ;
      }
    }

    public static bool GetDefaultIsModular ()
    { return Convert.ToBoolean (IsModularDefault) ;
    }

  }
}

/* End */
