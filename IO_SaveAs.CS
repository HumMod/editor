/* Model Controller / IO_SaveAs

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
{ public class IO_SaveAs
  { public static void SaveAs ()
    { TabData Data = TabManager.GetSelectedTabData () ;

      SaveFileDialog Dlg = new SaveFileDialog () ;

      Dlg.Title = AppMain.AppName + " - Save As" ;
      Dlg.Filter = "DESolver Files (*.DES) |*.DES| All Files (*.*) |*.*" ;
      Dlg.FileName = Data.Filename ;

      DialogResult Result = Dlg.ShowDialog () ;

      if (Result != DialogResult.OK)
      { return ;
      }

      IO_Writer.Write (Dlg.FileName, Data.Box.Text) ;  
      TabManager.NewFilename (Data.Filename, Dlg.FileName) ;

      Data.Box.Modified = false ;
      State.RefreshSaves () ;

      FileTree.This.RefreshTree () ;
    }

  }
}

/* End */
