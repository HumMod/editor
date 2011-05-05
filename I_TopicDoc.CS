/* Model Controller / I_TopicDoc

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
{ public class I_TopicDoc
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "TopicDoc" ;
      Insert.Label = "<topicdoc>...</topicdoc>" ;
      Insert.Content += "    <topicdoc>" + nl ;
      Insert.Content += "      <name>  </name>" + nl ;
      Insert.Content += "      <label>  </label>" + nl ;
      Insert.Content += "      <content>  </content>" + nl ;
      Insert.Content += "    </topicdoc>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
