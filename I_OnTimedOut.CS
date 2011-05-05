/* Model Controller / I_OnTimedOut

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
{ public class I_OnTimedOut
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "OpenOnTimedOut" ;
      Insert.Label = "<ontimedout>...</ontimedout>" ;
      Insert.Content += "        <ontimedout>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "        </ontimedout>" + nl ;

      Insert_Manager.Add (Insert) ;

    } 
  }
}

/* End */
