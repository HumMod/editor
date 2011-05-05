/* Model Controller / I_SlideBar

   Created : 2011-04-18
   Last Modified : 2011-04-18
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_SlideBar
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "SlideBar" ;
      Insert.Label = "<slidebar>...</slidebar>" ;

      Insert.Content += "      <slidebar>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <high>  </high>" + nl ;
      Insert.Content += "        <wide>  </wide>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <listname>  </listname>" + nl ;
      Insert.Content += "        <label>  </label>" + nl ;
      Insert.Content += "        <fieldwidth>  </fieldwidth>" + nl ;
      Insert.Content += "      </slidebar>" + nl ;

      Insert.WideContent += "      <slidebar>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <high>  </high><wide>  </wide>" + nl ;
      Insert.WideContent += "        <name>  </name>" + nl ;
      Insert.WideContent += "        <listname>  </listname>" + nl ;
      Insert.WideContent += "        <label>  </label>" + nl ;
      Insert.WideContent += "        <fieldwidth>  </fieldwidth>" + nl ;
      Insert.WideContent += "      </slidebar>" + nl ;

      Insert_Manager.Add (Insert) ;

    } 
  }
}

/* End */
