/* Model Editor / Options_General

   Created : 2011-04-05
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Options_General : TabPage
  { private static Options_General This ;

    private CheckBox UseColor ;
    private CheckBox SaveFiles ;
    private CheckBox WaitForExit ;
    private CheckBox UseTemplateFile ;
    private Label Filename ;
    private TextBox TemplateFile ;
    private CheckBox RestoreFileTree ;
    private CheckBox InsertWideFormat ;

    public Options_General ()
    { This = this ;
      Text = " General " ;

      UseColor = new CheckBox () ;

      UseColor.Parent = this ;
      UseColor.Text = "Use Color Highlighter On XML" ;
      UseColor.AutoSize = true ;
      UseColor.Location = new Point (10, 10) ;
      UseColor.Checked = GeneralRegistry.GetUseColor () ;
      UseColor.CheckedChanged += new EventHandler (OnUseColor) ;

      SaveFiles = new CheckBox () ;

      SaveFiles.Parent = this ;
      SaveFiles.Text = "Automatically Save All Open Files On Run" ;
      SaveFiles.AutoSize = true ;
      SaveFiles.Location = new Point (10, 30) ;
      SaveFiles.Checked = GeneralRegistry.GetSaveFiles () ;
      SaveFiles.CheckedChanged += new EventHandler (OnSaveFiles) ;

      WaitForExit = new CheckBox () ;

      WaitForExit.Parent = this ;
      WaitForExit.Text = "Editor Waits For Solver Modules To Exit" ;
      WaitForExit.AutoSize = true ;
      WaitForExit.Location = new Point (10, 50) ;
      WaitForExit.Checked = GeneralRegistry.GetWaitForExit () ;
      WaitForExit.CheckedChanged += new EventHandler (OnWaitForExit) ;

      UseTemplateFile = new CheckBox () ;

      UseTemplateFile.Parent = this ;
      UseTemplateFile.Text = "Use A Template File On New" ;
      UseTemplateFile.AutoSize = true ;
      UseTemplateFile.Location = new Point (10, 70) ;
      UseTemplateFile.Checked = GeneralRegistry.GetUseTemplateFile () ;
      UseTemplateFile.CheckedChanged += new EventHandler (OnUseTemplateFile) ;

      Filename = new Label () ;

      Filename.Parent = this ;
      Filename.Location = new Point (30, 90) ;
      Filename.AutoSize = true ;

      RefreshFilename () ;

      new Note (this, 30, 110, "Edit") ;

      TemplateFile = new TextBox () ;

      TemplateFile.Parent = this ;
      TemplateFile.Location = new Point (60, 108) ;
      TemplateFile.Size = new Size (230, 20) ;
      TemplateFile.Text = GeneralRegistry.GetTemplateFile () ;

      Button Apply = new Button () ;

      Apply.Parent = this ;
      Apply.Location = new Point (300, 108) ;
      Apply.Size = new Size (60, 20) ;
      Apply.Text = "Apply" ;
	    Apply.Click += new EventHandler (OnApply) ;

      Button Browse = new Button () ;

      Browse.Parent = this ;
      Browse.Location = new Point (370, 108) ;
      Browse.Size = new Size (60, 20) ;
      Browse.Text = "Browse" ;
	    Browse.Click += new EventHandler (OnBrowse) ;

      RestoreFileTree = new CheckBox () ;

      RestoreFileTree.Parent = this ;
      RestoreFileTree.Text = "Restore File Tree On Launch" ;
      RestoreFileTree.AutoSize = true ;
      RestoreFileTree.Location = new Point (10, 130) ;
      RestoreFileTree.Checked = GeneralRegistry.GetRestoreFileTree () ;
      RestoreFileTree.CheckedChanged += new EventHandler (OnRestoreFileTree) ;

      InsertWideFormat = new CheckBox () ;

      InsertWideFormat.Parent = this ;
      InsertWideFormat.Text = "Inserts Use Wide Format" ;
      InsertWideFormat.AutoSize = true ;
      InsertWideFormat.Location = new Point (10, 150) ;
      InsertWideFormat.Checked = GeneralRegistry.GetInsertWideFormat () ;
      InsertWideFormat.CheckedChanged += new EventHandler (OnInsertWideFormat) ;
    }

    public void OnUseColor (object Obj, EventArgs EA)
    { GeneralRegistry.SetUseColor (UseColor.Checked) ;
    }

    public void OnSaveFiles (object Obj, EventArgs EA)
    { GeneralRegistry.SetSaveFiles (SaveFiles.Checked) ;
    }

    public void OnWaitForExit (object Obj, EventArgs EA)
    { GeneralRegistry.SetWaitForExit (WaitForExit.Checked) ;
    }

    public void OnUseTemplateFile (object Obj, EventArgs EA)
    { GeneralRegistry.SetUseTemplateFile (UseTemplateFile.Checked) ;
    }

    private void OnApply (object Obj, EventArgs EA)
    { GeneralRegistry.SetTemplateFile (TemplateFile.Text) ;
  	  RefreshFilename () ;
  	}

    public void OnBrowse (object Obj, EventArgs EA)
    { OpenFileDialog Dlg = new OpenFileDialog () ;

      Dlg.Title = AppMain.AppName + " - Model Root File" ;
      Dlg.Filter = "DESolver Files (*.DES) |*.DES| All Files (*.*) |*.*" ;

      DialogResult Result = Dlg.ShowDialog () ;

      if (Result != DialogResult.OK)
      { return ;
      }

      GeneralRegistry.SetTemplateFile (Dlg.FileName) ;
  	  RefreshFilename () ;
      TemplateFile.Text = Dlg.FileName ;
    }

    public void RefreshFilename ()
    { Filename.Text = "File : " + GeneralRegistry.GetTemplateFile () ;
    }

    public void OnRestoreFileTree (object Obj, EventArgs EA)
    { GeneralRegistry.SetRestoreFileTree (RestoreFileTree.Checked) ;
    }

    public void OnInsertWideFormat (object Obj, EventArgs EA)
    { GeneralRegistry.SetInsertWideFormat (InsertWideFormat.Checked) ;
    }

  }
}

/* End */
