/* Model Controller / I_StableDiffEq

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
{ public class I_StableDiffEq
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "StableDiffEq" ;
      Insert.Label = "<stablediffeq>...</stablediffeq>" ;
      Insert.Content += "      <stablediffeq>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <integralname>  </integralname>" + nl ;
      Insert.Content += "        <initialval>  </initialval>" + nl ;
      Insert.Content += "        <dervname>  </dervname>" + nl ;
      Insert.Content += "        <errorlim>  </errorlim>" + nl ;
      Insert.Content += "        <dxmaxname>  </dxmaxname>" + nl ;
      Insert.Content += "      </stablediffeq>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
