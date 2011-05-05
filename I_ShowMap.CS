/* Model Controller / I_ShowMap

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
{ public class I_ShowMap
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "I_ShowMap" ;
      Insert.Label = "<showmap>...</showmap>" ;

      Insert.Content += "      <showmap>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <high>  </high>" + nl ;
      Insert.Content += "        <wide>  </wide>" + nl ;
      Insert.Content += "        <leftmargin>  </leftmargin>" + nl ;
      Insert.Content += "        <xaxis>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += "          <label>  </label>" + nl ;
      Insert.Content += "          <scale>" + nl ;
      Insert.Content += "            <min>  </min>" + nl ;
      Insert.Content += "            <max>  </max>" + nl ;
      Insert.Content += "            <inc>  </inc>" + nl ;
      Insert.Content += "          </scale>" + nl ;
      Insert.Content += "        </xaxis>" + nl ;
      Insert.Content += "        <yaxis>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += "          <label>  </label>" + nl ;
      Insert.Content += "          <linetype>  </linetype>" + nl ;
      Insert.Content += "          <linecolor>  </linecolor>" + nl ;
      Insert.Content += "          <symbolname>  </symbolname>" + nl ;
      Insert.Content += "          <scale>" + nl ;
      Insert.Content += "            <min>  </min>" + nl ;
      Insert.Content += "            <max>  </max>" + nl ;
      Insert.Content += "            <inc>  </inc>" + nl ;
      Insert.Content += "          </scale>" + nl ;
      Insert.Content += "        </yaxis>" + nl ;
      Insert.Content += "        <blockname>  </blockname>" + nl ;
      Insert.Content += "        <noghost/>" + nl ;
      Insert.Content += "        <ghost>" + nl ;
      Insert.Content += "          <linetype>  </linetype>" + nl ;
      Insert.Content += "          <linecolor>  </linecolor>" + nl ;
      Insert.Content += "          <symbolname>  </symbolname>" + nl ;
      Insert.Content += "        </ghost>" + nl ;
      Insert.Content += "      </showmap>" + nl ;

      Insert.WideContent += "      <showmap>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col><high>  </high><wide>  </wide>" + nl ;
      Insert.WideContent += "        <leftmargin>  </leftmargin>" + nl ;
      Insert.WideContent += "        <xaxis>" + nl ;
      Insert.WideContent += "          <name>  </name><label>  </label>" + nl ;
      Insert.WideContent += "          <scale><min>  </min><max>  </max><inc>  </inc></scale>" + nl ;
      Insert.WideContent += "        </xaxis>" + nl ;
      Insert.WideContent += "        <yaxis>" + nl ;
      Insert.WideContent += "          <name>  </name><label>  </label>" + nl ;
      Insert.WideContent += "          <linetype>  </linetype><linecolor>  </linecolor>" + nl ;
      Insert.WideContent += "          <symbolname>  </symbolname>" + nl ;
      Insert.WideContent += "          <scale><min>  </min><max>  </max><inc>  </inc></scale>" + nl ;
      Insert.WideContent += "        </yaxis>" + nl ;
      Insert.WideContent += "        <blockname>  </blockname>" + nl ;
      Insert.WideContent += "        <noghost/>" + nl ;
      Insert.WideContent += "        <ghost>" + nl ;
      Insert.WideContent += "          <linetype>  </linetype><linecolor>  </linecolor><symbolname>  </symbolname>" + nl ;
      Insert.WideContent += "        </ghost>" + nl ;
      Insert.WideContent += "      </showmap>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
