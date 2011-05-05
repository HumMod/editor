/* Model Editor / T_Search

   Created : 2011-04-08
   Last Modified : 2011-04-08
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class T_Search : ToolBarButton
  { private static T_Search This ;

    public T_Search (int Index)
    { This = this ;

      ImageIndex = Index ;
      ToolTipText = "Search" ;
      Tag = new ToolBar_Delegate (Clicked) ;
      Enabled = true ;
    }

    public Bitmap GetBMP ()
    { Bitmap BMP = ResourceManager.GetBitmap ("Search") ;
      Color Corner = BMP.GetPixel (0,0) ;
      BMP.MakeTransparent (Corner) ;

      return BMP ;
    }

    public void Clicked ()
    { Search_Dialog.Make () ;
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
