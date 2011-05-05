/* Model Controller / Options_Dialog

   Created : 2011-04-04
   Last Modified : 2011-04-07
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Options_Dialog : Form
  { public Options_Dialog ()
    { Text = AppMain.AppName + " - Options" ;
      StartPosition = FormStartPosition.CenterParent ;
      FormBorderStyle = FormBorderStyle.FixedDialog ;
      ClientSize =  new Size (610, 420) ;

      MaximizeBox = false ;
      MinimizeBox = false ;
      ControlBox = false ;
      ShowInTaskbar = false ;

      TabControl Tabs = new TabControl () ;

      Tabs.Parent = this ;
      Tabs.Dock = DockStyle.Fill ;
      Tabs.Multiline = true ;

      Options_General General = new Options_General () ;
      Tabs.Controls.Add (General) ;

      Options_Font Fonts = new Options_Font () ;
      Tabs.Controls.Add (Fonts) ;

      Options_Colors Colors = new Options_Colors () ;
      Tabs.Controls.Add (Colors) ;

      Options_Solving_Model Model = new Options_Solving_Model () ;
      Tabs.Controls.Add (Model) ;

      Options_Solving_Executables Executables = new Options_Solving_Executables () ;
      Tabs.Controls.Add (Executables) ;

      Options_Registry Registry = new Options_Registry () ;
      Tabs.Controls.Add (Registry) ;

      new OKButton (this) ;
    }
  }
}

/* End */
