/* Model Editor / FileRegistry

   Created : 2011-04-14
   Last Modified : 2011-04-14
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class FileRegistry
  { private static String FileTreePathKey = "FileTreePath" ;
    private static String LeftPanelWidthKey = "LeftPanelWidth" ;

    /* There is no default value for FileTreePath */

    private static int LeftPanelWidthDefault = 200 ;

    public static void SetFileTreePath (String Path)
    { RegistryManager.SetValue (FileTreePathKey, (object) Path) ;
    }

    public static bool HasFileTreePath ()
    { return RegistryManager.HasKey (FileTreePathKey) ;
    }

    public static String GetFileTreePath ()
    { if (RegistryManager.HasKey (FileTreePathKey))
      { return (String) RegistryManager.GetValue (FileTreePathKey) ;
      }
      else
      { return null ;
      }
    }

    public static void SetLeftPanelWidth (int Width)
    { RegistryManager.SetValue (LeftPanelWidthKey, (object) Width.ToString ()) ;
    }

    public static int GetLeftPanelWidth ()
    { if (RegistryManager.HasKey (LeftPanelWidthKey))
      { return Convert.ToInt32 ((String) RegistryManager.GetValue (LeftPanelWidthKey)) ;
      }
      else
      { return LeftPanelWidthDefault ;
      }
    }



  }
}

/* End */
