/* Model Editor / T_Open

   Created : 2011-04-05
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class T_Open : ToolBarButton
  { private static T_Open This ;

    public T_Open (int Index)
    { This = this ;

      ImageIndex = Index ;
      ToolTipText = "Open" ;
      Tag = new ToolBar_Delegate (Clicked) ;
      Enabled = true ;
    }

    public Bitmap GetBMP ()
    { Bitmap BMP = ResourceManager.GetBitmap ("Open") ;
      Color Corner = BMP.GetPixel (0,0) ;
      BMP.MakeTransparent (Corner) ;

      return BMP ;
    }

    public void Clicked ()
    { IO_Open.Open () ;
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
