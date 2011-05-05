/* Model Editor / ColorManager

   Created : 2011-04-04
   Last Modified : 2011-04-05
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class ColorManager
  { private static Color DefaultTag = Color.DarkRed ;
    private static Color DefaultContent = Color.Blue ;
    private static Color DefaultProcessing = Color.Indigo ;
    private static Color DefaultComment = Color.DarkGreen ;
    private static Color DefaultIncidental = Color.Black ;

    public static Color Get (String Name)
    { if (ColorRegistry.HasColor (Name))
      { return ColorRegistry.Get (Name) ;
      }
      else
      { return GetDefault (Name) ;
      }
	}

    public static void Set (String Name, Color Value)
    { ColorRegistry.Set (Name, Value) ;
    }

    private static Color GetDefault (String Name)
    { if (Name == "Tag")
      { return DefaultTag ;
      }
      else if (Name == "Content")
      { return DefaultContent ;
      }
      else if (Name == "Processing")
      { return DefaultProcessing ;
      }
      else if (Name == "Comment")
      { return DefaultComment ;
      }
      else if (Name == "Incidental")
      { return DefaultIncidental ;
      }

      return Color.Black ;
    }
  }
}

/* End */
