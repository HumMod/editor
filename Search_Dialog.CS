/* Model Controller / Search_Dialog

   Created : 2011-04-12
   Last Modified : 2011-04-12
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.ComponentModel ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Search_Dialog : Form
  { public static void Make ()
    { Search_Dialog Dlg = new Search_Dialog () ;
      Dlg.Show () ;
    }

    private TextBox Find ;
    private TextBox ReplaceWith ;

    private CheckBox WholeWord ;
    private CheckBox MatchCase ;

    private Button FindNext ;
    private Button Replace ;

    private int Index ;

    public Search_Dialog ()
    { Text = AppMain.AppName + " - Search" ;
      FormBorderStyle = FormBorderStyle.FixedDialog ;
      ClientSize =  new Size (300, 150) ;

      MaximizeBox = false ;
      MinimizeBox = false ;
      ControlBox = true ;
      ShowInTaskbar = false ;

      Owner = MainWindow.This ;

      StartPosition = FormStartPosition.Manual ;
      Location = Search_Registry.GetLocation () ;

      new Note (this, 10, 10, "Find") ;

      Find = new TextBox () ;

      Find.Parent = this ;
      Find.Location = new Point (40, 8) ;
      Find.Size = new Size (250, 20) ;

      new Note (this, 10, 40, "Replace With") ;

      ReplaceWith = new TextBox () ;

      ReplaceWith.Parent = this ;
      ReplaceWith.Location = new Point (90, 38) ;
      ReplaceWith.Size = new Size (200, 20) ;

      WholeWord = new CheckBox () ;

      WholeWord.Parent = this ;
      WholeWord.Text = "Whole Word" ;
      WholeWord.AutoSize = true ;
      WholeWord.Location = new Point (10, 70) ;
      WholeWord.Checked = Search_Registry.GetWholeWord () ;
      WholeWord.CheckedChanged += new EventHandler (OnWholeWord) ;

      MatchCase = new CheckBox () ;

      MatchCase.Parent = this ;
      MatchCase.Text = "Match Case" ;
      MatchCase.AutoSize = true ;
      MatchCase.Location = new Point (10, 90) ;
      MatchCase.Checked = Search_Registry.GetMatchCase () ;
      MatchCase.CheckedChanged += new EventHandler (OnMatchCase) ;

      Button FindFirst = new Button () ;

      FindFirst.Parent = this ;
      FindFirst.Location = new Point (30, 120) ;
      FindFirst.Size = new Size (80, 20) ;
      FindFirst.Text = "Find First" ;
      FindFirst.Click += new EventHandler (OnFindFirst) ;

      FindNext = new Button () ;

      FindNext.Parent = this ;
      FindNext.Location = new Point (120, 120) ;
      FindNext.Size = new Size (80, 20) ;
      FindNext.Text = "Find Next" ;
      FindNext.Enabled = false ;
      FindNext.Click += new EventHandler (OnFindNext) ;

      Replace = new Button () ;

      Replace.Parent = this ;
      Replace.Location = new Point (210, 120) ;
      Replace.Size = new Size (80, 20) ;
      Replace.Text = "Replace" ;
      Replace.Enabled = false ;
      Replace.Click += new EventHandler (OnReplace) ;

    }

    public void OnWholeWord (object Obj, EventArgs EA)
    { Search_Registry.SetWholeWord (WholeWord.Checked) ;
    }

    public void OnMatchCase (object Obj, EventArgs EA)
    { Search_Registry.SetMatchCase (MatchCase.Checked) ;
    }

    private void OnFindFirst (object Obj, EventArgs EA)
    { Index = 0 ;
      
      Index = EditManager.Find (Find.Text, Index, GetFlags ()) ;

      if (Index != -1)
      { FindNext.Enabled = true ;
        Replace.Enabled = true ;
      } 
  	}

    private void OnFindNext (object Obj, EventArgs EA)
    { Index += Find.Text.Length ;
      Index = EditManager.Find (Find.Text, Index , GetFlags ()) ;

      if (Index != -1)
      { Replace.Enabled = true ;
      } 
      else
      { FindNext.Enabled = false ;
        Replace.Enabled = false ;
      } 

  	}

    private void OnReplace (object Obj, EventArgs EA)
    { EditManager.Insert (ReplaceWith.Text) ;
      Replace.Enabled = false ;
    }

    private RichTextBoxFinds GetFlags ()
    { RichTextBoxFinds Flags = RichTextBoxFinds.None ;

      if (WholeWord.Checked)
      { Flags |= RichTextBoxFinds.WholeWord ;
      }

      if (MatchCase.Checked)
      { Flags |= RichTextBoxFinds.MatchCase ;
      }

      return Flags ;
    }

    protected override void OnClosing (CancelEventArgs CEA)
    { base.OnClosing (CEA) ;

      Search_Registry.SetLocation (new Point (Location.X, Location.Y)) ;
    }
  }
}

/* End */
