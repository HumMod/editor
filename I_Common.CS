/* Model Controller / I_Common

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
{ public class I_Common
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Common" ;
      Insert.Label = "<common>...</common>" ;
      Insert.Content = "    <common>" + nl ;
      Insert.Content = nl ;
      Insert.Content = "    </common>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      I_Tree.Install () ;
      I_DisplayFirst.Install () ;
      I_Shared.Install () ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
