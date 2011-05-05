/* Model Controller / I_Docs

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
{ public class I_Docs
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Docs" ;
      Insert.Label = "<docs>...</docs>" ;
      Insert.Content += "  <docs>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "  </docs>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      I_StructureName.Install () ;
      I_VarDoc.Install () ;
      I_TopicDoc.Install () ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
