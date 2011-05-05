/* Model Editor / Print_HeaderFooter_Dialog

   Created : 2011-04-25
   Last Modified : 2011-04-25
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.IO ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Print_HeaderFooter_Dialog : Form
  { private TextBox TopLeft ;
    private TextBox TopRight ;
    private TextBox BottomLeft ;
    private TextBox BottomRight ;

    public Print_HeaderFooter_Dialog ()
    { Text = AppMain.AppName + " - Print Header / Footer" ;

      StartPosition = FormStartPosition.CenterParent ;
      FormBorderStyle = FormBorderStyle.FixedDialog ;
      ClientSize =  new Size (400, 170) ;

      MaximizeBox = false ;
      MinimizeBox = false ;
      ControlBox = false ;
      ShowInTaskbar = false ;

      new Note (this, 20, 25, "Top Left") ;

      TopLeft = new TextBox () ;

      TopLeft.Parent = this ;
      TopLeft.Location = new Point (100, 23) ;
      TopLeft.Size = new Size (280, 20) ;
      TopLeft.Text = Print_Registry.Get_TopLeft () ;

      new Note (this, 20, 50, "Top Right") ;

      TopRight = new TextBox () ;

      TopRight.Parent = this ;
      TopRight.Location = new Point (100, 48) ;
      TopRight.Size = new Size (280, 20) ;
      TopRight.Text = Print_Registry.Get_TopRight () ;

      new Note (this, 20, 75, "Bottom Left") ;

      BottomLeft = new TextBox () ;

      BottomLeft.Parent = this ;
      BottomLeft.Location = new Point (100, 73) ;
      BottomLeft.Size = new Size (280, 20) ;
      BottomLeft.Text = Print_Registry.Get_BottomLeft () ;

      new Note (this, 20, 100, "Bottom Right") ;

      BottomRight = new TextBox () ;

      BottomRight.Parent = this ;
      BottomRight.Location = new Point (100, 98) ;
      BottomRight.Size = new Size (280, 20) ;
      BottomRight.Text = Print_Registry.Get_BottomRight () ;

      Button OK = new Button () ;

      OK.Parent = this ;
      OK.Location = new Point (20, 130) ;
      OK.Size = new Size (70, 20) ;
      OK.Text = "OK" ;
	    OK.Click += new EventHandler (OnOK) ;
      OK.DialogResult = DialogResult.OK ;

      Button Help = new Button () ;

      Help.Parent = this ;
      Help.Location = new Point (100, 130) ;
      Help.Size = new Size (70, 20) ;
      Help.Text = "Help" ;
	    Help.Click += new EventHandler (OnHelp) ;

    }

    private void OnOK (object Obj, EventArgs EA)
    { Print_Registry.Set_TopLeft (TopLeft.Text) ;
      Print_Registry.Set_TopRight (TopRight.Text) ;
      Print_Registry.Set_BottomLeft (BottomLeft.Text) ;
      Print_Registry.Set_BottomRight (BottomRight.Text) ;
  	}

    private void OnHelp (object Obj, EventArgs EA)
    { String nl = Environment.NewLine ;
      String Msg = "" ; 

      Msg += "Special words are" + nl ;
      Msg += "" + nl ;
      Msg += "# Filename - To show name of file being printer" + nl ;
      Msg += "# Date-Time - To show current data and time" + nl ;
      Msg += "# Page Number - To number the pages" + nl ;

      MsgBox.Show (Msg) ;
  	}


  }
}

/* End */
