/* Model Controller / I_Panel

   Created : 2011-04-13
   Last Modified : 2011-04-18
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_Panel
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Panel" ;
      Insert.Label = "<panel>...</panel>" ;

      Insert.Content += "    <panel>" + nl ;
      Insert.Content += "      <name>  </name>" + nl ;
      Insert.Content += "      <tablabel>  </tablabel>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "    </panel>" + nl ;

      Insert.WideContent += "    <panel>" + nl ;
      Insert.WideContent += "      <name>  </name><tablabel>  </tablabel>" + nl ;
      Insert.WideContent += nl ;
      Insert.WideContent += "    </panel>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      I_ActionButton.Install () ;
      I_CheckBox.Install () ;
      I_CheckMark.Install () ;
      I_EditBox.Install () ;
      I_GroupBox.Install () ;
      I_InfoButton.Install () ;
      I_Label.Install () ;
      I_MapListPanel.Install () ;
      I_Note.Install () ;
      I_RadioButtons.Install () ;
      I_RepeatListPanel.Install () ;
      I_ShowBargraph.Install () ;
      I_ShowBitmap.Install () ;
      I_ShowBitmapFile.Install () ;
      I_ShowClock.Install () ;
      I_ShowCurve.Install () ;
      I_ShowFile.Install () ;
      I_ShowGraph.Install () ;
      I_ShowMap.Install () ;
      I_ShowPanelName.Install () ;
      I_ShowTable.Install () ;
      I_ShowValue.Install () ;
      I_StructureNamePanel.Install () ;
      I_SlideBar.Install () ;
      I_SymbolPanel.Install () ;
      I_ValueBar.Install () ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
