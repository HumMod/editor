/* Model Controller / I_ImplicitMath

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
{ public class I_ImplicitMath
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ImplicitMath" ;
      Insert.Label = "<implicitmath>...</implicitmath>" ;
      Insert.Content += "        <implicitmath>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "        </implicitmath>" + nl ;

      Insert_Manager.Add (Insert) ;

    } 
  }
}

/* End */
