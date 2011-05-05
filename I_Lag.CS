/* Model Controller / I_Lag

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
{ public class I_Lag
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Lag" ;
      Insert.Label = "<lag>...</lag>" ;
      Insert.Content += "      <lag>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <outputname>  </outputname>" + nl ;
      Insert.Content += "        <initialval>  </initialval>" + nl ;
      Insert.Content += "        <inputname>  </inputname>" + nl ;
      Insert.Content += "        <rateconstname>  </rateconstname>" + nl ;
      Insert.Content += "        <dervname>  </dervname>" + nl ;
      Insert.Content += "      </lag>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
