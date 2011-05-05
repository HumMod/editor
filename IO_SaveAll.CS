/* Model Controller / IO_SaveAll

   Created : 2011-04-21
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class IO_SaveAll
  { public static void SaveAll ()
    { ArrayList Datas = TabManager.GetAllTabData () ;

      foreach (TabData Data in Datas)
      { DialogResult OK = IO_Save.Save (Data) ;

        if (OK == DialogResult.Cancel)
        { State.RefreshSaves () ;
          return ;
        }
      }

      State.RefreshSaves () ;
    }

  }
}

/* End */
