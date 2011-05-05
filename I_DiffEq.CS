/* Model Controller / I_DiffEq

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
{ public class I_DiffEq
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "DiffEq" ;
      Insert.Label = "<diffeq>...</diffeq>" ;
      Insert.Content += "      <diffeq>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <integralname>  </integralname>" + nl ;
      Insert.Content += "        <initialval>  </initialval>" + nl ;
      Insert.Content += "        <dervname>  </dervname>" + nl ;
      Insert.Content += "        <errorlim>  </errorlim>" + nl ;
      Insert.Content += "      </diffeq>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
