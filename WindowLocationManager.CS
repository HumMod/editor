/* Model Editor / WindowLocationManager

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center

   We can transport window size and location in
   a rectangle (Rect) using

       Width
       Height
       X
       Y                                         */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class WindowLocationManager
  { public static String WindowLocation = "WindowLocation" ;
    public static String HasWindowLocationData = "HasWindowLocationData" ;

    public static int DefaultWidth = 600 ;
    public static int DefaultHeight = 500 ;
    public static int DefaultX = 40 ;
    public static int DefaultY = 20 ;

    public static Rectangle GetLocation ()
    { Rectangle Rect = new Rectangle () ;

      if (RegistryManager.HasKey (HasWindowLocationData))
      { Rect.Width = (int) RegistryManager.GetValue (WindowLocation + "Width") ;
        Rect.Height = (int) RegistryManager.GetValue (WindowLocation + "Height") ;
        Rect.X = (int) RegistryManager.GetValue (WindowLocation + "X") ;
        Rect.Y = (int) RegistryManager.GetValue (WindowLocation + "Y") ;
      }
      else
      { Rect.Width = DefaultWidth ;
        Rect.Height = DefaultHeight ;
        Rect.X = DefaultX ;
        Rect.Y = DefaultY ;
      }

      return Rect ;
    }

    public static void SetLocation (Rectangle Rect)
    { RegistryManager.SetValue (WindowLocation + "Width", Rect.Width) ;
      RegistryManager.SetValue (WindowLocation + "Height", Rect.Height) ;
      RegistryManager.SetValue (WindowLocation + "X", Rect.X) ;
      RegistryManager.SetValue (WindowLocation + "Y", Rect.Y) ;
      RegistryManager.SetValue (HasWindowLocationData, true) ;
    }
  }
}

/* End */
