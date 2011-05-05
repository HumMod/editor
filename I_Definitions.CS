/* Model Controller / I_Definitions

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
{ public class I_Definitions
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Definitions" ;
      Insert.Label = "<definitions>...</definitions>" ;
      Insert.Content += "    <definitions>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "    </definitions>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      I_Block.Install () ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
