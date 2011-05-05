/* Model Controller / I_ShowBitmap

   Created : 2011-04-18
   Last Modified : 2011-04-18
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_ShowBitmap
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ShowBitmap" ;
      Insert.Label = "<showbitmap>...</showbitmap>" ;

      Insert.Content += "      <showbitmap>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "      </showbitmap>" + nl ;

      Insert.WideContent += "      <showbitmap>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <name>  </name>" + nl ;
      Insert.WideContent += "      </showbitmap>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
