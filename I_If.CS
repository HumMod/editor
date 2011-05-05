/* Model Controller / I_If

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
{ public class I_If
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "If" ;
      Insert.Label = "<if>...</if>" ;
      Insert.Content += "        <if>" + nl ;
      Insert.Content += "          <test>  </test>" + nl ;
      Insert.Content += "          <true>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "          </true>" + nl ;
      Insert.Content += "          <false>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "          </false>" + nl ;
      Insert.Content += "        </if>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
