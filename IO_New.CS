/* Model Editor / IO_New

   Created : 2011-04-22
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class IO_New
  { private static int Index = 0 ;

    public static void Call ()
    { Index++ ;

      String Filename = "No Name " + Index.ToString () ;
      String Content = "" ;

      if (GeneralRegistry.GetUseTemplateFile ())
      { Content = IO_Reader.Read (GeneralRegistry.GetTemplateFile ()) ;
      }

      TabManager.Add (Filename, Content) ; 
      State.FilesOpen () ;
    }
  }
}

/* End */
