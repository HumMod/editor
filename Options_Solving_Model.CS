/* Model Editor / Options_Solving_Model

   Created : 2011-04-05
   Last Modified : 2011-04-05
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Options_Solving_Model : TabPage
  { private Label ModelName ;
    private TextBox Edit ;

    public Options_Solving_Model ()
    { Text = " Model Root File " ;

      ModelName = new Label () ;

      ModelName.Parent = this ;
      ModelName.Location = new Point (20, 10) ;
      ModelName.AutoSize = true ;

	    RefreshLabel (RunRegistry.GetModel ()) ;

      new Note (this, 20, 35, "Edit") ;

      Edit = new TextBox () ;

      Edit.Parent = this ;
      Edit.Location = new Point (50, 33) ;
      Edit.Size = new Size (240, 20) ;
      Edit.Text = RunRegistry.GetModel () ;

      Button Apply = new Button () ;

      Apply.Parent = this ;
      Apply.Location = new Point (300, 33) ;
      Apply.Size = new Size (60, 20) ;
      Apply.Text = "Apply" ;
	    Apply.Click += new EventHandler (OnApply) ;

      Button Browse = new Button () ;

      Browse.Parent = this ;
      Browse.Location = new Point (370, 33) ;
      Browse.Size = new Size (60, 20) ;
      Browse.Text = "Browse" ;
	    Browse.Click += new EventHandler (OnBrowse) ;

      Button Reset = new Button () ;

      Reset.Parent = this ;
      Reset.Location = new Point (440, 33) ;
      Reset.Size = new Size (60, 20) ;
      Reset.Text = "Reset" ;
	    Reset.Click += new EventHandler (OnReset) ;

      Label DefaultName = new Label () ;

      DefaultName.Parent = this ;
      DefaultName.Location = new Point (20, 60) ;
      DefaultName.AutoSize = true ;
	    DefaultName.Text = "Default Name : " + RunRegistry.GetDefaultModel () ;

    }

    private void OnApply (object Obj, EventArgs EA)
    { RunRegistry.SetModel (Edit.Text) ;
  	  RefreshLabel (Edit.Text) ;
  	}

    private void OnBrowse (object Obj, EventArgs EA)
    { OpenFileDialog Dlg = new OpenFileDialog () ;

      Dlg.Title = AppMain.AppName + " - Model Root File" ;
      Dlg.Filter = "DESolver Files (*.DES) |*.DES| All Files (*.*) |*.*" ;

      DialogResult Result = Dlg.ShowDialog () ;

      if (Result != DialogResult.OK)
      { return ;
      }

      RunRegistry.SetModel (Dlg.FileName) ;
      RefreshLabel (Dlg.FileName) ;
      Edit.Text = Dlg.FileName ;
    }


    private void OnReset (object Obj, EventArgs EA)
    { String Model = RunRegistry.GetDefaultModel () ;

      RunRegistry.SetModel (Model) ;
      RefreshLabel (Model) ;
      Edit.Text = Model ;
    }

    private void RefreshLabel (String Name)
    { ModelName.Text = "Model Name : " + Name ;
    }

  }
}

/* End */
