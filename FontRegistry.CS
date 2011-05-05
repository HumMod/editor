/* Model Editor / FontRegistry

   Created : 2011-04-04
   Last Modified : 2011-04-2011-04-25
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center

   A font has 3 properties that can be extracted
   and stored in the registry

   # Font FontFamily (String)
   # Font Height (float)
   # Font Style (FontStyle)                      */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class FontRegistry
  { private static String Editing = "Font_Editing_" ;
    private static String Printing = "Font_Printing_" ;

    public static bool HasEditing ()
    { if (RegistryManager.HasKey (Editing + "FontFamily"))
      { return true ;
      }
      else
      { return false ;
      }
    }

    public static bool HasPrinting ()
    { if (RegistryManager.HasKey (Printing + "FontFamily"))
      { return true ;
      }
      else
      { return false ;
      }
    }

    public static void SetEditing (Font FontArg)
    { Set (Editing, FontArg) ;
    }

    public static Font GetEditing ()
    { return Get (Editing) ;
    }

    public static void SetPrinting (Font FontArg)
    { Set (Printing, FontArg) ;
    }

    public static Font GetPrinting ()
    { return Get (Printing) ;
    }

    private static void Set (String Prefix, Font FontArg)
    { String FontFamilyName = FontArg.FontFamily.Name ; 
      RegistryManager.SetValue (Prefix + "FontFamilyName", (object) FontFamilyName) ;

      float Size = FontArg.SizeInPoints ;
      RegistryManager.SetValue (Prefix + "SizeInPoints", (object) Size.ToString ()) ;

      FontStyle Style = FontArg.Style ;
      RegistryManager.SetValue (Prefix + "Style", (object) Style.ToString ()) ;
    }

    private static Font Get (String Prefix)
    { String FontFamilyName = (String) RegistryManager.GetValue (Prefix + "FontFamilyName") ;

      String Size = (String) RegistryManager.GetValue (Prefix + "Size") ;
      float SizeInPoints = Convert.ToSingle (Size) ;

      FontStyle Style = (FontStyle) RegistryManager.GetValue (Prefix + "Style") ;
 
      Font NewFont = new Font (FontFamilyName, SizeInPoints, Style) ;
      return NewFont ;
    }
  }
}

/* End */
