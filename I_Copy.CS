/* Model Controller / I_Copy

   Created : 2011-04-13
   Last Modified : 2011-04-13
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_Copy
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Copy" ;
      Insert.Label = "<copy>...</copy>" ;

      Insert.Content += "        <copy>" + nl ;
      Insert.Content += "          <from>...</from>" + nl ;
      Insert.Content += "          <to>...</to>" + nl ;
      Insert.Content += "        </copy>" + nl ;

      Insert.WideContent += "        <copy>" + nl ;
      Insert.WideContent += "          <from>...</from><to>...</to>" + nl ;
      Insert.WideContent += "        </copy>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
