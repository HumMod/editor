/* Model Editor / Options_Solving_Combined

   Created : 2011-04-05
   Last Modified : 2011-04-05
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Options_Solving_Combined : Panel
  { private Label ModuleName ;
    private TextBox Edit ;

    public Options_Solving_Combined ()
    { ModuleName = new Label () ;

      ModuleName.Parent = this ;
      ModuleName.Location = new Point (10, 10) ;
      ModuleName.AutoSize = true ;

      RefreshLabel (RunRegistry.GetCombined ()) ;

      new Note (this, 10, 35, "Edit") ;

      Edit = new TextBox () ;

      Edit.Parent = this ;
      Edit.Location = new Point (40, 33) ;
      Edit.Size = new Size (240, 20) ;
      Edit.Text = RunRegistry.GetCombined () ;

      Button Apply = new Button () ;

      Apply.Parent = this ;
      Apply.Location = new Point (290, 33) ;
      Apply.Size = new Size (60, 20) ;
      Apply.Text = "Apply" ;
	    Apply.Click += new EventHandler (OnApply) ;

      Button Browse = new Button () ;

      Browse.Parent = this ;
      Browse.Location = new Point (360, 33) ;
      Browse.Size = new Size (60, 20) ;
      Browse.Text = "Browse" ;
	    Browse.Click += new EventHandler (OnBrowse) ;

      Button Reset = new Button () ;

      Reset.Parent = this ;
      Reset.Location = new Point (430, 33) ;
      Reset.Size = new Size (60, 20) ;
      Reset.Text = "Reset" ;
	    Reset.Click += new EventHandler (OnReset) ;

      Label DefaultName = new Label () ;

      DefaultName.Parent = this ;
      DefaultName.Location = new Point (10, 60) ;
      DefaultName.AutoSize = true ;
	    DefaultName.Text = "Default Name : " + RunRegistry.GetDefaultCombined () ;

    }

    private void OnApply (object Obj, EventArgs EA)
    { RunRegistry.SetCombined (Edit.Text) ;
      RefreshLabel (Edit.Text) ;
  	}

    private void OnBrowse (object Obj, EventArgs EA)
    { OpenFileDialog Dlg = new OpenFileDialog () ;

      Dlg.Title = AppMain.AppName + " - Model Controller" ;
      Dlg.Filter = "Executable Files (*.EXE) |*.EXE| All Files (*.*) |*.*" ;

      DialogResult Result = Dlg.ShowDialog () ;

      if (Result != DialogResult.OK)
      { return ;
      }

      RunRegistry.SetCombined (Dlg.FileName) ;
      RefreshLabel (Dlg.FileName) ;
      Edit.Text = Dlg.FileName ;
    }


    private void OnReset (object Obj, EventArgs EA)
    { String Combined = RunRegistry.GetDefaultCombined () ;

      RunRegistry.SetCombined (Combined) ;
      RefreshLabel (Combined) ;
      Edit.Text = Combined ;
    }

    private void RefreshLabel (String Name)
    { ModuleName.Text = "Executable Name : " + Name ;
    }
  }
}

/* End */
