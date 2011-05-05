/* Model Editor / TabManager

   Created : 2011-04-04
   Last Modified : 2011-04-28
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.IO ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class TabManager
  { private static TabControl Tabs ;

    public static void Attach (Panel ParentArg)
    { Tabs = new TabControl () ;

      Tabs.Parent = ParentArg ;
      Tabs.Dock = DockStyle.Fill ;
      Tabs.Multiline = true ;
    }

    public static void Add (String FilenameArg, String ContentArg)
    { TabData Data = new TabData () ;
      Data.Filename = FilenameArg ;

      TabPage Tab = new TabPage () ;

      Tab.AutoScroll = true ;
      Tab.ContextMenu = new TabContextMenu (FilenameArg) ;
      Tab.Text = Path.GetFileNameWithoutExtension (FilenameArg) ;
      Tab.Tag = Data ;
      Tab.VisibleChanged += new EventHandler (OnVisibleChanged) ;

      Tabs.Controls.Add (Tab) ;
      Tabs.SelectTab (Tab) ;

      RichTextBox Box = new RichTextBox () ;

      Box.Parent = Tab ;
      Box.Dock = DockStyle.Fill ;
      Box.Multiline = true ;
      Box.WordWrap = false ;
      Box.ReadOnly = false ;
      Box.Text = ContentArg ;
      Box.ContextMenu = new TabContextMenu (FilenameArg) ;
      Box.TextChanged += new EventHandler (OnTextChange) ;
      Box.SelectionChanged += new EventHandler (OnSelectionChange) ;
      Box.AcceptsTab = true ;

      // Default is Box.ScrollBars = RichTextBoxScrollBars.Both

      Data.Box = Box ;

      if (GeneralRegistry.GetUseColor ())
      { ColorHighlighter.Parse (Box) ;
      }
    }

    private static void OnVisibleChanged (object Obj, EventArgs EA)
    { TabPage Tab = (TabPage) Obj ;

      if (Tab.Visible)
      { TabData Data = (TabData) Tab.Tag ;
        StatusBarManager.ShowText ("File : " + Data.Filename) ;

//        RefreshStatus () ;
//        RefreshState () ;
      }
    }

    private static void OnTextChange (object Obj, EventArgs EA)
    { if (ColorHighlighter.Active)
      { return ;
      }

      RefreshStatus () ;
      RefreshState () ;
    }

    private static void OnSelectionChange (object Obj, EventArgs EA)
    { if (ColorHighlighter.Active)
      { return ;
      }

      RefreshStatus () ;
      RefreshState () ;
    }

    private static void RefreshStatus ()
    { TabPage Tab ;

      if (Tabs.Controls.Count == 1)
      { Tab = (TabPage) Tabs.Controls[0] ;
      }
      else
      { Tab = Tabs.SelectedTab ;
      }

      TabData Data = (TabData) Tab.Tag ;
      RichTextBox Box = Data.Box ;

      String Msg = "" ;

      Msg += Box.SelectionStart.ToString () ;
      Msg += " / " ;
      Msg += Box.TextLength.ToString () ;

      StatusBarManager.UpdateRect1 (Msg) ;

      int Line = Box.GetLineFromCharIndex (Box.SelectionStart) + 1 ;

      Msg = "" ;
      Msg += "Line : " + Line.ToString () ;

      StatusBarManager.UpdateRect2 (Msg) ;
    }

    private static void RefreshState ()
    { TabPage Tab ;

      if (Tabs.Controls.Count == 1)
      { Tab = (TabPage) Tabs.Controls[0] ;
      }
      else
      { Tab = Tabs.SelectedTab ;
      }

      TabData Data = (TabData) Tab.Tag ;
      RichTextBox Box = Data.Box ;

      if (Box.Modified)
      { State.SelectedDocHasChanges () ;
      }

      if (Box.SelectionLength == 0)
      { State.DocHasNoSelection () ;
      }
      else
      { State.DocHasSelection () ;
      }
    }

    public static void Remove ()
    { TabPage Tab ;

      if (Tabs.Controls.Count == 1)
      { Tab = (TabPage) Tabs.Controls[0] ;
      }
      else
      { Tab = Tabs.SelectedTab ;
      }


      if (Tab != null)
      { Tabs.Controls.Remove (Tab) ;
      }
    }

    public static void RemoveAll ()
    { Tabs.Controls.Clear () ; 
    }

    public static void RefreshColor ()
    { TabPage Tab ;

      if (Tabs.Controls.Count == 1)
      { Tab = (TabPage) Tabs.Controls[0] ;
      }
      else
      { Tab = Tabs.SelectedTab ;
      }

      TabData Data = (TabData) Tab.Tag ;
      ColorHighlighter.Parse (Data.Box) ;
    }

    public static RichTextBox GetBox ()
    { if (HasTabs ())
      { TabPage Tab ;

        if (Tabs.Controls.Count == 1)
        { Tab = (TabPage) Tabs.Controls[0] ;
        }
        else
        { Tab = Tabs.SelectedTab ;
        }

        TabData Data = (TabData) Tab.Tag ;
        return Data.Box ;
      }

      return null ;
    }

    public static bool HasTabs ()
    { if (Tabs.Controls.Count == 0)
      { return false ;
      }
      else
      { return true ;
      }
    }

    public static String GetFilename ()
    { if (HasTabs ())
      { TabPage Tab = Tabs.SelectedTab ;
        TabData Data = (TabData) Tab.Tag ;
        return Data.Filename ;
      }

      return null ;
    }

    public static String GetText ()
    { if (HasTabs ())
      { RichTextBox Box = GetBox () ;
        return Box.Text ;
      }

      return null ;
    }

    public static TabData GetSelectedTabData ()
    { if (HasTabs ())
      { TabPage Tab = Tabs.SelectedTab ;
        return (TabData) Tab.Tag ;
      }

      return null ;
    }

    public static ArrayList GetAllTabData ()
    { if (HasTabs ())
      { ArrayList Datas = new ArrayList () ;

        foreach (TabPage Tab in Tabs.Controls)
        { TabData Data = (TabData) Tab.Tag ;
          Datas.Add (Data) ;
        }

        return Datas ; 
      }

      return null ;
    }

    public static void NewFilename (String Current, String New)
    { foreach (TabPage Tab in Tabs.Controls)
      { TabData Data = (TabData) Tab.Tag ;
        if (Data.Filename == Current)
        { Data.Filename = New ;
          Tab.Text = Path.GetFileNameWithoutExtension (New) ;
        }
      }
    }

    public static bool SomeDocHasChanges ()
    { foreach (TabPage Tab in Tabs.Controls)
      { TabData Data = (TabData) Tab.Tag ;

        if (Data.Box.Modified)
        { return true ;
        }
      }

      return false ;
    }

    public static bool SelectedDocHasChanges ()
    { if (HasTabs ())
      { TabPage Tab = Tabs.SelectedTab ;
        TabData Data = (TabData) Tab.Tag ;

        if (Data.Box.Modified)
        { return true ;
        }
      }

      return false ;
    }


  }
}

/* End */
