/* Model Editor / Insert_Registry

   Created : 2011-04-12
   Last Modified : 2011-04-12
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Insert_Registry
  { private static int XDefault = 100 ;
    private static String XKey = "Insert X" ;

    private static int YDefault = 100 ;
    private static String YKey = "Insert Y" ;

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

  }
}

/* End */
