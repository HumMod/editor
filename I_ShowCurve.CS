/* Model Controller / I_ShowCurve

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
{ public class I_ShowCurve
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ShowCurve" ;
      Insert.Label = "<showcurve>...</showcurve>" ;

      Insert.Content += "      <showcurve>" + nl ;
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
      Insert.Content += "        <curvename>  </curvename>" + nl ;
      Insert.Content += "        <noghost/>" + nl ;
      Insert.Content += "        <ghost>" + nl ;
      Insert.Content += "          <symbolname>  </symbolname>" + nl ;
      Insert.Content += "        </ghost>" + nl ;
      Insert.Content += "      </showcurve>" + nl ;

      Insert.WideContent += "      <showcurve>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>  <high>  </high><wide>  </wide>" + nl ;
      Insert.WideContent += "        <leftmargin>  </leftmargin>" + nl ;
      Insert.WideContent += "        <xaxis>" + nl ;
      Insert.WideContent += "          <name>  </name>" + nl ;
      Insert.WideContent += "          <label>  </label>" + nl ;
      Insert.WideContent += "          <scale><min>  </min><max>  </max><inc>  </inc></scale>" + nl ;
      Insert.WideContent += "        </xaxis>" + nl ;
      Insert.WideContent += "        <yaxis>" + nl ;
      Insert.WideContent += "          <label>  </label>" + nl ;
      Insert.WideContent += "          <linetype>  </linetype><linecolor>  </linecolor>" + nl ;
      Insert.WideContent += "          <symbolname>  </symbolname>" + nl ;
      Insert.WideContent += "          <scale><min>  </min><max>  </max><inc>  </inc></scale>" + nl ;
      Insert.WideContent += "        </yaxis>" + nl ;
      Insert.WideContent += "        <curvename>  </curvename>" + nl ;
      Insert.WideContent += "        <noghost/>" + nl ;
      Insert.WideContent += "        <ghost><symbolname>  </symbolname></ghost>" + nl ;
      Insert.WideContent += "      </showcurve>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
