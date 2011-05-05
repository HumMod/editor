/* Model Controller / I_TestCase

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
{ public class I_TestCase
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "TestCase" ;
      Insert.Label = "<testcase>...</testcase>" ;
      Insert.Content += "        <testcase>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "        </testcase>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      I_Case.Install () ;

      Insert_Manager.Pop () ;

    } 
  }
}

/* End */
