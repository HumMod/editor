/* Model Editor / StatusBarManager

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.IO ;
using System.ComponentModel ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class StatusBarManager
  { public static StatusBarPanel Panel ;
    public static StatusBarPanel Rect1 ;
    public static StatusBarPanel Rect2 ;


    public static void Create (Form Parent)
    { StatusBar Instance = new StatusBar () ;
      Instance.Parent = Parent ;
      Parent.Controls.Add (Instance) ;

      Panel = new StatusBarPanel () ;
      Panel.BorderStyle = StatusBarPanelBorderStyle.Sunken ;
      Panel.AutoSize = StatusBarPanelAutoSize.Spring ;

      Rect1 = new StatusBarPanel () ;
      Rect1.BorderStyle = StatusBarPanelBorderStyle.Sunken ;
      Rect1.Width = 70 ;
      Rect1.Alignment = HorizontalAlignment.Center ;

      Rect2 = new StatusBarPanel () ;
      Rect2.BorderStyle = StatusBarPanelBorderStyle.Sunken ;
      Rect2.Width = 70 ;
      Rect2.Alignment = HorizontalAlignment.Center ;

      Instance.ShowPanels = true ;

      Instance.Panels.Add (Panel) ;
      Instance.Panels.Add (Rect1) ;
      Instance.Panels.Add (Rect2) ;

      ShowText (" Ready") ;
    }

    public static void ShowText (String Message)
    { Panel.Text = Message ;
    }

    public static void AddText (String Message)
    { Panel.Text = Panel.Text + Message ;
    }

    public static void ClearText ()
    { Panel.Text = "" ;
    }

    public static void UpdateRect1 (String Message)
    { Rect1.Text = Message ;
    }

    public static void UpdateRect2 (String Message)
    { Rect2.Text = Message ;
    }



  }
}

/* End */
