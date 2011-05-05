/* Model Editor / RegistryManager

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center

   When Model Editor is first run on a computer,
   there is no account in the registry. So we create
   at the very start of the main window. Otherwise,
   there will always be stuff is the registry.        */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;
using Microsoft.Win32 ; // for the registry

namespace ModelEditor
{ public class RegistryManager
  { public static void CreateAccount ()
    { RegistryKey RK ;

      RK = Registry.CurrentUser.OpenSubKey (AppMain.AppName, true) ;

      if (RK == null)
      { RK = Registry.CurrentUser.CreateSubKey (AppMain.AppName) ;
      }

      RK.Close () ;
    }

    public static void DeleteAccount ()
    { Registry.CurrentUser.DeleteSubKey (AppMain.AppName) ;
    }

    public static bool HasKey (String Name)
    { RegistryKey RK ;

      RK = Registry.CurrentUser.OpenSubKey (AppMain.AppName, true) ;
      object Value = RK.GetValue (Name) ;
      RK.Close () ;

      if (Value == null)
      { return false ;
      }
      else
      { return true ;
      }
    }

    public static void SetValue (String Name, object Value)
    { RegistryKey RK ;

      RK = Registry.CurrentUser.OpenSubKey (AppMain.AppName, true) ;
      RK.SetValue (Name, Value) ;
      RK.Close () ;
    }

    public static object GetValue (String Name)
    { RegistryKey RK ;

      RK = Registry.CurrentUser.OpenSubKey (AppMain.AppName, true) ;
      object Value = RK.GetValue (Name) ;
      RK.Close () ;

      return Value ;
    }

    public static void DeleteValue (String Name)
    { RegistryKey RK ;

      RK = Registry.CurrentUser.OpenSubKey (AppMain.AppName, true) ;
      RK.DeleteValue (Name, false) ;
      RK.Close () ;
    }

    public static String [] GetNames ()
    { RegistryKey RK ;

      RK = Registry.CurrentUser.OpenSubKey (AppMain.AppName) ;
      String [] Names = RK.GetValueNames () ;
      RK.Close () ;

      return Names ;
    }

    public static ArrayList GetEntries ()
    { ArrayList List = new ArrayList (100) ;

      String [] Names = GetNames () ;

      foreach (String Name in Names)
      { List.Add (Name + " = " + GetValue (Name).ToString ()) ;
      }

      return List ;
    }
  }
}

/* End */
