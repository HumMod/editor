/* Model Editor / MainWindow

   Created : 2011-04-04
   Last Modified : 2011-04-19
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.IO ;
using System.ComponentModel ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class MainWindow : Form
  { public static MainWindow This ;

    public static Font BasicFont ;

    public MainWindow ()
    { This = this ;

      BasicFont = This.Font ;
      RegistryManager.CreateAccount () ;

      Text = AppMain.AppName ;
      Icon = ResourceManager.GetAppIcon () ;

      WindowState = (FormWindowState) WindowStateManager.GetState () ;

      StartPosition = FormStartPosition.Manual ;

      Rectangle Rect = new Rectangle () ;

      Rect = WindowLocationManager.GetLocation () ;

      Size = new Size (Rect.Width, Rect.Height) ;
      Location = new Point (Rect.X, Rect.Y) ;

      Menu = new M_Main () ;

      /* The following three panels are docked.

         For reasons that I don't understand, when
         panels are docked the latter panels get
         priority over the earlier panels.

         # The left panel sits at the left.
         # The right panel is a fill.
         # The top panel goes last and get docked at the top. */

      new PanelRight (this) ;
      new Window_Splitter (this) ;
      new PanelLeft (this) ;
      new PanelTop (this) ;

      StatusBarManager.Create (this) ;
      Print_Manager.Install () ;

      State.NoFilesOpen () ;

      Visible = true ;
    }

    protected override void OnClosing (CancelEventArgs CEA)
    { base.OnClosing (CEA) ;

      FileTree.This.Save () ;
      PanelLeft.Closing () ;

      if (TabManager.HasTabs ())
      { IO_SaveAll.SaveAll () ;
      }

      if (Options_Registry.IsChecked)
      { RegistryManager.DeleteAccount () ;
        return ;
      }

      if (WindowState == FormWindowState.Normal)
      { WindowStateManager.SetState ((int) FormWindowState.Normal) ;

        Rectangle Rect = new Rectangle () ;

        Rect.Width = Size.Width ;
        Rect.Height = Size.Height ;
        Rect.X = Location.X ;
        Rect.Y = Location.Y ;
  
        WindowLocationManager.SetLocation (Rect) ;
      }
 
      else if (WindowState == FormWindowState.Maximized)
      { WindowStateManager.SetState ((int) FormWindowState.Maximized) ;
      }
    }

    public static void AppendTitle (String Text)
    { This.Text = AppMain.AppName + " : " + Text ;
    }
  }
}

/* End */
