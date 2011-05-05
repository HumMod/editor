/* Model Controller / I_Math

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
{ public class I_Math
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Math" ;
      Insert.Label = "<math>...</math>" ;
      Insert.Content += "  <math>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "  </math>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      Insert = new Insert_Data () ;

      Insert.Name = "Context" ;
      Insert.Label = "<context>...</context>" ;
      Insert.Content = "    <context>  </context>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "Parms" ;
      Insert.Label = "<parms>...</parms>" ;
      Insert.Content = "    <parms>  </parms>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "Dervs" ;
      Insert.Label = "<dervs>...</dervs>" ;
      Insert.Content = "    <dervs>  </dervs>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "WrapUp" ;
      Insert.Label = "<wrapup>...</wrapup>" ;
      Insert.Content = "    <wrapup>  </wrapup>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
