/* Model Editor / ColorRegistry

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center

   Do not put a color in the registry. It is an
   object and it will throw coming out.

   Color types are

   # Tag
   # Content
   # Processing (Processing Instruction)
   # Comment
   # Incidental                               */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class ColorRegistry
  { public static String Prefix = "Color" ;

    public static bool HasColor (String Name)
    { if (RegistryManager.HasKey (Prefix + Name))
      { return true ;
      }
      else
      { return false ;
      }
    }

    public static void Set (String Name, Color Value)
    { int RGBValue = Value.ToArgb () ;
      RegistryManager.SetValue (Prefix + Name, (object) RGBValue) ;
    }

    public static Color Get (String Name)
    { int RGBValue = (int) RegistryManager.GetValue (Prefix + Name) ;
      return Color.FromArgb (RGBValue) ;
    }
  }
}

/* End */
