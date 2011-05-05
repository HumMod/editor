/* Model Controller / I_RepeatList

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
{ public class I_RepeatList
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "RepeatList" ;
      Insert.Label = "<repeatlist>...</repeatlist>" ;
      Insert.Content += "        <repeatlist>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += "          <firstval>  </firstval>" + nl ;
      Insert.Content += "          <repeat><reps>  </reps><stepsize>  </stepsize></repeat>" + nl ;
      Insert.Content += "        </repeatlist>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
