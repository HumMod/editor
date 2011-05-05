/* Model Controller / I_Model

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
{ public class I_Model : Insert_Data
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Model" ;
      Insert.Label = "<model>...</model>" ;
      Insert.Content += "<model>" + nl ;
      Insert.Content += "  <title>" + nl ;
      Insert.Content += "    <basic>...</basic>" + nl ;
      Insert.Content += "    <navigator>...</navigator>" + nl ;
      Insert.Content += "  </title>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "</model>" + nl ;

      Insert_Manager.AddToRoot (Insert) ;

      Insert_Manager.Push () ;

      I_Structure.Install () ;
      I_Math.Install () ;
      I_Control.Install () ;
      I_Display.Install () ;
      I_Docs.Install () ;

      Insert_Manager.Pop () ;
    }
  }
}

/* End */
