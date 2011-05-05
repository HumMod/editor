/* Model Editor / T_Copy

   Created : 2011-04-05
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class T_Copy : ToolBarButton
  { private static T_Copy This ;

    public T_Copy (int Index)
    { This = this ;

      ImageIndex = Index ;
      ToolTipText = "Copy" ;
      Tag = new ToolBar_Delegate (Clicked) ;
      Enabled = true ;
    }

    public Bitmap GetBMP ()
    { Bitmap BMP = ResourceManager.GetBitmap ("Copy") ;
      Color Corner = BMP.GetPixel (0,0) ;
      BMP.MakeTransparent (Corner) ;

      return BMP ;
    }

    public void Clicked ()
    { EditManager.Copy () ;
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
