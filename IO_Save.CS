/* Model Controller / IO_Save

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
{ public class IO_Save
  { public static void Save ()
    { TabData Data = TabManager.GetSelectedTabData () ;
      Save (Data) ;
      State.RefreshSaves () ;
    }

    public static DialogResult Save (TabData Data)
    { String NotNamed = "No Name" ;

      if (Data.Filename.IndexOf (NotNamed) == 0)
      { return NoName (Data) ;
      }

      else if (Data.Box.Modified)
      { BasicSave (Data) ;
        return DialogResult.OK ;
      }

      return DialogResult.OK ;
    }

    public static DialogResult SaveAskIfChanged (TabData Data)
    { String NotNamed = "No Name" ;

      if (Data.Filename.IndexOf (NotNamed) == 0)
      { return NoName (Data) ;
      }

      else if (Data.Box.Modified)
      { return Changed (Data) ;
      }

      return DialogResult.OK ;
    }

    private static DialogResult NoName (TabData Data)
    { String Msg = "" ;

      Msg += "Rename and save this document '" ;
      Msg += Data.Filename ;
      Msg += "'?" ;

      DialogResult OK = MsgBox.YesNoCancel (Msg) ;

      if (OK == DialogResult.Cancel)
      { return DialogResult.Cancel ;
      }

      if (OK == DialogResult.Yes)
      { SaveFileDialog Dlg = new SaveFileDialog () ;

        Dlg.Title = AppMain.AppName + " - Save As" ;
        Dlg.Filter = "DESolver Files (*.DES) |*.DES| All Files (*.*) |*.*" ;
        Dlg.FileName = Data.Filename ;

        DialogResult Result = Dlg.ShowDialog () ;

        if (Result != DialogResult.OK)
        { return Result ;
        }

        BasicSave (Data) ;
        TabManager.NewFilename (Data.Filename, Dlg.FileName) ;
        return DialogResult.Yes ;
      }

      return DialogResult.No ;
    }

    private static DialogResult Changed (TabData Data)
    { String Msg = "" ;

      Msg += "Document '" ;
      Msg += Data.Filename ;
      Msg += "' has been changed. Save changes?" ;

      DialogResult OK = MsgBox.YesNoCancel (Msg) ;

      if (OK == DialogResult.Cancel)
      { return DialogResult.Cancel ;
      }

      if (OK == DialogResult.Yes)
      { BasicSave (Data) ;
        return DialogResult.Yes ;
      }

      return DialogResult.No ;
    }

    private static void BasicSave (TabData Data)
    { IO_Writer.Write (Data.Filename, Data.Box.Text) ;
      Data.Box.Modified = false ;
    }

  }
}

/* End */
