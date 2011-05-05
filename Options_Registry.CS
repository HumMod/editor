/* Model Editor / Options_Registry

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Options_Registry : TabPage
  { public static bool IsChecked = false ;
    public CheckBox CB ;

    public Options_Registry ()
    { Text = " Registry " ;

      String List = "" ;
      ArrayList Entries = RegistryManager.GetEntries () ;

      foreach (String Entry in Entries)
      { List += Entry + "\r\n" ;
      }

      Label VC = new Label () ;

      VC.Parent = this ;
      VC.Text = "Registry Entries = " + Entries.Count ;
      VC.AutoSize = true ;
      VC.Location = new Point (10, 6) ;

      TextBox TB = new TextBox () ;

      TB.Parent = this ;
      TB.Location = new Point (10, 32) ;
      TB.Size = new Size (370, 110) ;
      TB.Multiline = true ;
      TB.WordWrap = false ;
      TB.ReadOnly = true ;
      TB.ScrollBars = ScrollBars.Vertical ;
      TB.Text = List ;

      CB = new CheckBox () ;

      CB.Parent = this ;
      CB.Text = "Clear application registry on program exit." ;
      CB.AutoSize = true ;
      CB.Location = new Point (10, 158) ;
      CB.CheckedChanged += new EventHandler (OnCheckedChanged) ;
     }

    public void OnCheckedChanged (object Obj, EventArgs EA)
    { IsChecked = CB.Checked ;
    }
  }
}

/* End */
