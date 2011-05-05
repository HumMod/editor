/* Model Controller / I_Block

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
{ public class I_Block
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Block" ;
      Insert.Label = "<block>...</block>" ;
      Insert.Content += "      <block>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "      </block>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      I_AndIf.Install () ;
      I_Beep.Install () ;
      I_CalcLag.Install () ;
      I_Call.Install () ;
      I_Conditional.Install () ;
      I_Copy.Install () ;
      I_Def.Install () ;
      I_ExitBlock.Install () ;
      I_If.Install () ;
      I_ImplicitMath.Install () ;
      I_Message.Install () ;
      I_OnJustChanged.Install () ;
      I_OnTimedOut.Install () ;
      I_Page.Install () ;
      I_Stop.Install () ;
      I_TestCase.Install () ;
      I_Timer.Install () ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
