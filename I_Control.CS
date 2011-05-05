/* Model Controller / I_Control

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
{ public class I_Control
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Control" ;
      Insert.Label = "<control>...</control>" ;
      Insert.Content += "  <control>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "  </control>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      Insert = new Insert_Data () ;

      Insert.Name = "GoFor" ;
      Insert.Label = "<gofor>...</gofor>" ;

      Insert.Content += "    <gofor>" + nl ;
      Insert.Content += "      <solutionint>  </solutionint>" + nl ;
      Insert.Content += "      <displayint>  </displayint>" + nl ;
      Insert.Content += "      <menuitem>  </menuitem>" + nl ;
      Insert.Content += "    </gofor>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "GoTo" ;
      Insert.Label = "<goto>...</goto>" ;
      Insert.Content += "    <goto>" + nl ;
      Insert.Content += "      <solutionint>  </solutionint>" + nl ;
      Insert.Content += "      <displayint>  </displayint>" + nl ;
      Insert.Content += "      <menuitem>  </menuitem>" + nl ;
      Insert.Content += "    </goto>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "GoBar" ;
      Insert.Label = "<gobar/>" ;
      Insert.Content = "    <gobar/>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "InitialX" ;
      Insert.Label = "<initialx>...</initialx>" ;
      Insert.Content = "    <initialx>  </initialx>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "Scramble" ;
      Insert.Label = "<scramble/>" ;
      Insert.Content = "    <scramble/>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "SettlingTime" ;
      Insert.Label = "<settlingtime>...</settlingtime>" ;
      Insert.Content = "    <settlingtime>  </settlingtime>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Pop () ;

    }
  } 
}

/* End */
