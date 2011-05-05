/* Model Editor / T_Print
   Created : 2011-04-08
   Last Modified : 2011-04-08
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class T_Print : ToolBarButton
  { private static T_Print This ;

    public T_Print (int Index)
    { This = this ;

      ImageIndex = Index ;
      ToolTipText = "Print" ;
      Tag = new ToolBar_Delegate (Clicked) ;
      Enabled = true ;
    }

    public Bitmap GetBMP ()
    { Bitmap BMP = ResourceManager.GetBitmap ("Print") ;
      Color Corner = BMP.GetPixel (0,0) ;
      BMP.MakeTransparent (Corner) ;

      return BMP ;
    }

    public void Clicked ()
    { Print_Manager.Print () ;
    }

    public static void TurnOn ()
    { This.Enabled = true ;
    }

    public static void TurnOff ()
    { This.Enabled = false ;
    }

  }
}

/* End */
