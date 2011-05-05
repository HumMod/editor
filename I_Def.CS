/* Model Controller / I_Def

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
{ public class I_Def
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Def" ;
      Insert.Label = "<def>...</def>" ;

      Insert.Content += "        <def>" + nl ;
      Insert.Content += "          <name>...</name>" + nl ;
      Insert.Content += "          <val>...</val>" + nl ;
      Insert.Content += "        </def>" + nl ;

      Insert.WideContent += "        <def>" + nl ;
      Insert.WideContent += "          <name>...</name><val>...</val>" + nl ;
      Insert.WideContent += "        </def>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
