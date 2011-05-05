/* Model Editor / FontManager

   Created : 2011-04-04
   Last Modified : 2011-04-25
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class FontManager
  { public static Font GetEditing ()
    { if (FontRegistry.HasEditing ())
      { return FontRegistry.GetEditing () ;
      }
      else
      { return MainWindow.BasicFont ;
      }
    }

    public static void SetEditing (Font FontArg)
    { FontRegistry.SetEditing (FontArg) ;
    }

    public static Font GetPrinting ()
    { if (FontRegistry.HasPrinting ())
      { return FontRegistry.GetPrinting () ;
      }
      else
      { return MainWindow.BasicFont ;
      }
    }

    public static void SetPrinting (Font FontArg)
    { FontRegistry.SetPrinting (FontArg) ;
    }
  }
}

/* End */
