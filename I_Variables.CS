/* Model Controller / I_Variables

   Created : 2011-04-11
   Last Modified : 2011-04-13
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_Variables
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Variables" ;
      Insert.Label = "<variables>...</variables>" ;
      Insert.Content += "    <variables>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "    </variables>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      I_Var.Install () ;
      I_Parm.Install () ;
      I_Constant.Install () ;
      I_TimerVar.Install () ;
      I_NormalDist.Install () ;
      I_WhiteNoise.Install () ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
