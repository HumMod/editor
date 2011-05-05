/* Model Editor / State

   Created : 2011-04-21
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class State
  { public static void WaitForExit ()
    { Menu_Manager.TurnOff () ;
      ToolBar_Manager.TurnOff () ;
    }

    public static void HaveExit ()
    { Menu_Manager.TurnOn () ;
      ToolBar_Manager.TurnOn () ;
    }

    public static void NoFilesOpen ()
    { Menu_Manager.NoFilesOpen () ;
      ToolBar_Manager.NoFilesOpen () ;
    }

    public static void FilesOpen ()
    { Menu_Manager.FilesOpen () ;
      ToolBar_Manager.FilesOpen () ;
    }

    public static void SelectedDocHasChanges ()
    { Menu_Manager.SelectedDocHasChanges () ;
      ToolBar_Manager.SelectedDocHasChanges () ;
    }

    public static void SomeDocHasChanges ()
    { Menu_Manager.SomeDocHasChanges () ;
      ToolBar_Manager.SomeDocHasChanges () ;
    }

    public static void NoDocHasChanges ()
    { Menu_Manager.NoDocHasChanges () ;
      ToolBar_Manager.NoDocHasChanges () ;
    }

    public static void DocHasSelection ()
    { Menu_Manager.DocHasSelection () ;
      ToolBar_Manager.DocHasSelection () ;
    }

    public static void DocHasNoSelection ()
    { Menu_Manager.DocHasNoSelection () ;
      ToolBar_Manager.DocHasNoSelection () ;
    }

    public static void RefreshSaves ()
    { if (TabManager.SelectedDocHasChanges ())
      { SelectedDocHasChanges () ;
      }
      else if (TabManager.SomeDocHasChanges ())
      { SomeDocHasChanges () ;
      }
      else
      { NoDocHasChanges () ;
      }
    }

  }
}

/* End */
