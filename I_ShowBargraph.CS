/* Model Controller / I_ShowBargraph

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
{ public class I_ShowBargraph
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ShowBargraph" ;
      Insert.Label = "<showbargraph>...</showbargraph>" ;

      Insert.Content += "      <showbargraph>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <high>  </high>" + nl ;
      Insert.Content += "        <wide>  </wide>" + nl ;
      Insert.Content += "        <leftmargin>  </leftmargin>" + nl ;
      Insert.Content += "        <title>  </title>" + nl ;
      Insert.Content += "        <bar>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += "          <label>  </label>" + nl ;
      Insert.Content += "          <color>  </color>" + nl ;
      Insert.Content += "        </bar>" + nl ;
      Insert.Content += "        <scale>" + nl ;
      Insert.Content += "          <min>  </min>" + nl ;
      Insert.Content += "          <max>  </max>" + nl ;
      Insert.Content += "          <inc>  </inc>" + nl ;
      Insert.Content += "        </scale>" + nl ;
      Insert.Content += "      </showbargraph>" + nl ;

      Insert.WideContent += "      <showbargraph>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <high>  </high><wide>  </wide>" + nl ;
      Insert.WideContent += "        <leftmargin>  </leftmargin><title>  </title>" + nl ;
      Insert.WideContent += "        <bar>" + nl ;
      Insert.WideContent += "          <name>  </name><label>  </label><color>  </color>" + nl ;
      Insert.WideContent += "        </bar>" + nl ;
      Insert.WideContent += "        <scale><min>  </min><max>  </max><inc>  </inc></scale>" + nl ;
      Insert.WideContent += "      </showbargraph>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      Insert = new Insert_Data () ;

      Insert.Name = "Bar" ;
      Insert.Label = "<bar>...</bar>" ;

      Insert.Content += "        <bar>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += "          <label>  </label>" + nl ;
      Insert.Content += "          <color>  </color>" + nl ;
      Insert.Content += "        </bar>" + nl ;

      Insert.WideContent += "        <bar>" + nl ;
      Insert.WideContent += "          <name>  </name><label>  </label><color>  </color>" + nl ;
      Insert.WideContent += "        </bar>" + nl ;
      Insert_Manager.Add (Insert) ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
