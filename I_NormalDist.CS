/* Model Controller / I_NormalDist

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
{ public class I_NormalDist
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "NormalDist" ;
      Insert.Label = "<normaldist>...</normaldist>" ;

      Insert.Content += "      <normaldist>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <mean>  </mean>" + nl ;
      Insert.Content += "        <stddev>  </stddev>" + nl ;
      Insert.Content += "      </normaldist>" + nl ;

      Insert.WideContent += "      <normaldist>" + nl ;
      Insert.WideContent += "        <name>  </name><mean>  </mean><stddev>  </stddev>" + nl ;
      Insert.WideContent += "      </normaldist>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
