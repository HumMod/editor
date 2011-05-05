/* Model Editor / T_Paste

   Created : 2011-04-05
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class T_Paste : ToolBarButton
  { private static T_Paste This ;

    public T_Paste (int Index)
    { This = this ;

      ImageIndex = Index ;
      ToolTipText = "Paste" ;
      Tag = new ToolBar_Delegate (Clicked) ;
      Enabled = true ;
    }

    public Bitmap GetBMP ()
    { Bitmap BMP = ResourceManager.GetBitmap ("Paste") ;
      Color Corner = BMP.GetPixel (0,0) ;
      BMP.MakeTransparent (Corner) ;

      return BMP ;
    }

    public void Clicked ()
    { EditManager.Paste () ;
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
