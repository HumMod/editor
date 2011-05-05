/* Model Editor / Search_Registry

   Created : 2011-04-12
   Last Modified : 2011-04-12
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Search_Registry
  { private static int XDefault = 100 ;
    private static String XKey = "Search X" ;

    private static int YDefault = 100 ;
    private static String YKey = "Search Y" ;

    private static bool WholeWordDefault = true ;
    private static String WholeWordKey = "Whole Word" ;

    private static bool MatchCaseDefault = true ;
    private static String MatchCaseKey = "Match Case" ;


    public static void SetLocation (Point Location)
    { RegistryManager.SetValue (XKey, (object) Location.X.ToString ()) ;
      RegistryManager.SetValue (YKey, (object) Location.Y.ToString ()) ;
    }

    public static Point GetLocation ()
    { if (RegistryManager.HasKey (XKey))
      { String XImage = (String) RegistryManager.GetValue (XKey) ;
        int X = Convert.ToInt32 (XImage) ;

        String YImage = (String) RegistryManager.GetValue (YKey) ;
        int Y = Convert.ToInt32 (YImage) ;

        return new Point (X,Y) ;
      }
      else
      { return new Point (XDefault, YDefault) ;
      }
    }

    public static void SetWholeWord (bool State)
    { RegistryManager.SetValue (WholeWordKey, (object) State.ToString ()) ;
    }

    public static bool GetWholeWord ()
    { if (RegistryManager.HasKey (WholeWordKey))
      { String Image = (String) RegistryManager.GetValue (WholeWordKey) ;
        return Convert.ToBoolean (Image) ;
      }
      else
      { return WholeWordDefault ;
      }
    }

    public static void SetMatchCase (bool State)
    { RegistryManager.SetValue (MatchCaseKey, (object) State.ToString ()) ;
    }

    public static bool GetMatchCase ()
    { if (RegistryManager.HasKey (MatchCaseKey))
      { String Image = (String) RegistryManager.GetValue (MatchCaseKey) ;
        return Convert.ToBoolean (Image) ;
      }
      else
      { return MatchCaseDefault ;
      }
    }


  }
}

/* End */
