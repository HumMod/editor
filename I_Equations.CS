/* Model Controller / I_Equations

   Created : 2011-04-11
   Last Modified : 2011-04-12
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_Equations
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Equations" ;
      Insert.Label = "<equations>...</equations>" ;
      Insert.Content += "    <equations>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "    </equations>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      I_DiffEq.Install () ;
      I_BackwardEuler.Install () ;
      I_Delay.Install () ;
      I_Lag.Install () ;
      I_ImplicitEq.Install () ;
      I_StableDiffEq.Install () ;
      I_StableDelay.Install () ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
