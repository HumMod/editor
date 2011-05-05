/* Model Controller / Insert_Dialog

   Created : 2011-04-11
   Last Modified : 2011-04-11
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.ComponentModel ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Insert_Dialog : Form
  { public static Insert_Dialog Dlg ;

    public static void Make ()
    { Dlg = new Insert_Dialog () ;
      Dlg.Show () ;
    }

    public Insert_Dialog ()
    { Text = AppMain.AppName + " - Insert" ;
      FormBorderStyle = FormBorderStyle.FixedDialog ;
      ClientSize =  new Size (300, 420) ;

      MaximizeBox = false ;
      MinimizeBox = false ;
      ControlBox = true ;
      ShowInTaskbar = false ;

      StartPosition = FormStartPosition.Manual ;
      Location = Insert_Registry.GetLocation () ;

      Owner = MainWindow.This ;

      TreeView Tree = new TreeView () ;

      Tree.Parent = this ;
      Tree.Dock = DockStyle.Fill ;
      Tree.BeforeSelect += new TreeViewCancelEventHandler (OnSelect) ;

      Insert_Manager.Install (Tree) ;
    }

    private void OnSelect (object Obj, TreeViewCancelEventArgs EA)
    { EA.Cancel = true ;

      if (EA.Action == TreeViewAction.ByMouse)
      { if (EA.Node.Tag != null) 
        { String Name = (String) EA.Node.Tag ;
          Insert_Manager.Select (Name) ;
        }
      }
    }

    protected override void OnClosing (CancelEventArgs CEA)
    { base.OnClosing (CEA) ;

      Insert_Registry.SetLocation (new Point (Location.X, Location.Y)) ;
    }
  }
}

/* End */
