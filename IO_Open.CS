/* Model Controller / IO_Open

   Created : 2011-04-04
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.IO ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class IO_Open
  { public static void Open ()
    { OpenFileDialog Dlg = new OpenFileDialog () ;

      Dlg.Title = AppMain.AppName + " - Open" ;
      Dlg.Filter = "DESolver Files (*.DES) |*.DES| All Files (*.*) |*.*" ;

      DialogResult Result = Dlg.ShowDialog () ;

      if (Result != DialogResult.OK)
      { return ;
      }

      Open (Dlg.FileName) ;
    }

    public static void Open (String Filename)
    { String Content = IO_Reader.Read (Filename) ;

      TabManager.Add (Filename, Content) ;
      State.FilesOpen () ;
    }

  }
}

/* End */