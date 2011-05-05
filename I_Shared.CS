/* Model Controller / I_Shared

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
{ public class I_Shared
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Shared" ;
      Insert.Label = "<shared>...</shared>" ;
      Insert.Content += "      <shared>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "      </shared>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      I_MapList.Install () ;
      I_RepeatList.Install () ;
      I_Symbol.Install () ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
