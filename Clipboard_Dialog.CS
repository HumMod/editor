/* Model Controller / Clipboard_Dialog

   Created : 2011-04-11
   Last Modified : 2011-04-11
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Clipboard_Dialog : Form
  { private TextBox Edit ;

    public static void Make ()
    { Clipboard_Dialog Dlg = new Clipboard_Dialog () ;
      Dlg.ShowDialog () ;
    }

    private Clipboard_Dialog ()
    { Text = AppMain.AppName + " - Clipboard" ;
      StartPosition = FormStartPosition.CenterParent ;
      FormBorderStyle = FormBorderStyle.FixedDialog ;
      ClientSize =  new Size (400, 420) ;

      MaximizeBox = false ;
      MinimizeBox = false ;
      ControlBox = false ;
      ShowInTaskbar = false ;

      Edit = new TextBox () ;

      Edit.Parent = this ;
      Edit.Multiline = true ;
      Edit.WordWrap = true ;
      Edit.ScrollBars = ScrollBars.Both ;
      Edit.Location = new Point (10, 10) ;
      Edit.Size = new Size (380, 340) ;
      Edit.Text = Clipboard.GetText () ;
      Edit.Select (0,0) ;

      Button Apply = new Button () ;

      Apply.Parent = this ;
      Apply.Location = new Point (50, 360) ;
      Apply.Size = new Size (70, 20) ;
      Apply.Text = "Apply" ;
	    Apply.Click += new EventHandler (OnApply) ;

      new OKButton (this) ;
    }

    private void OnApply (object Obj, EventArgs EA)
    { Clipboard.SetText (Edit.Text) ;
  	}

  }
}

/* End */
