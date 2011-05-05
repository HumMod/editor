/* Model Controller / I_ShowTable

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
{ public class I_ShowTable
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ShowTable" ;
      Insert.Label = "<showtable>...</showtable>" ;

      Insert.Content += "      <showtable>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "      </showtable>" + nl ;

      Insert.WideContent += "      <showtable>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += nl ;
      Insert.WideContent += "      </showtable>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      Insert = new Insert_Data () ;

      Insert.Name = "Column" ;
      Insert.Label = "<column>...</column>" ;

      Insert.Content += "        <column>" + nl ;
      Insert.Content += "          <indent>  </indent>" + nl ;
      Insert.Content += "          <fieldwidth>  </fieldwidth>" + nl ;
      Insert.Content += "          <justify>  </justify>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "        </column>" + nl ;

      Insert.WideContent += "        <column>" + nl ;
      Insert.WideContent += "          <indent>  </indent><fieldwidth>  </fieldwidth><justify>  </justify>" + nl ;
      Insert.WideContent += nl ;
      Insert.WideContent += "        </column>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      Insert = new Insert_Data () ;

      Insert.Name = "EmptyCell" ;
      Insert.Label = "<emptycell/>" ;
      Insert.Content += "          <emptycell/>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "TextCell" ;
      Insert.Label = "<textcell>...</textcell>" ;
      Insert.Content += "          <textcell>  </textcell>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "ValueCell" ;
      Insert.Label = "<valuecell>...</valuecell>" ;

      Insert.Content += "          <valuecell>" + nl ;
      Insert.Content += "            <name>  </name>" + nl ;
      Insert.Content += "            <format>" + nl ;
      Insert.Content += "              <decimal>  </decimal>" + nl ;
      Insert.Content += "            </format>" + nl ;
      Insert.Content += "          </valuecell>" + nl ;

      Insert.WideContent += "          <valuecell>" + nl ;
      Insert.WideContent += "            <name>  </name>" + nl ;
      Insert.WideContent += "            <format><decimal>  </decimal></format>" + nl ;
      Insert.WideContent += "          </valuecell>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      Insert = new Insert_Data () ;

      Insert.Name = "TableFormat" ;
      Insert.Label = "<format>...</format>" ;
      Insert.Content += "            <format>" + nl ;
      Insert.Content += "              <none/>" + nl ;
      Insert.Content += "              <integer/>" + nl ;
      Insert.Content += "              <decimal>  </decimal>" + nl ;
      Insert.Content += "              <list>  </list>" + nl ;
      Insert.Content += "              <timer/>" + nl ;
      Insert.Content += "              <timestamp/>" + nl ;
      Insert.Content += "              <boolean/>" + nl ;
      Insert.Content += "              <fieldwidth>  </fieldwidth>" + nl ;
      Insert.Content += "              <justify>  </justify>" + nl ;
      Insert.Content += "            </format>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Pop () ;
      Insert_Manager.Pop () ;
      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
