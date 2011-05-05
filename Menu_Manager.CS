/* Model Editor / Menu_Manager

   Created : 2011-04-07
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Menu_Manager
  { public static void TurnOn ()
    { M_File.TurnOn () ;
      M_Edit.TurnOn () ;
      M_Search.TurnOn () ;
      M_Insert.TurnOn () ;
      M_Run.TurnOn () ;
      M_Options.TurnOn () ;
      M_Help.TurnOn () ;
    }

    public static void TurnOff ()
    { M_File.TurnOff () ;
      M_Edit.TurnOff () ;
      M_Search.TurnOff () ;
      M_Insert.TurnOff () ;
      M_Run.TurnOff () ;
      M_Options.TurnOff () ;
      M_Help.TurnOff () ;
    }

    public static void NoFilesOpen ()
    { M_Search.TurnOff () ;
      M_Insert.TurnOff () ;
      M_Run.TurnOff () ;

      M_Save.TurnOff () ;
      M_SaveAs.TurnOff () ;
      M_SaveAll.TurnOff () ;

      M_Close.TurnOff () ;
      M_CloseAll.TurnOff () ;

      M_PageSetup.TurnOff () ;
      M_HeaderFooter.TurnOff () ;
      M_PrintPreview.TurnOff () ;
      M_Print.TurnOff () ;

      M_Cut.TurnOff () ;
      M_Copy.TurnOff () ;
      M_Paste.TurnOff () ;
      M_SelectAll.TurnOff () ;
    }

    public static void FilesOpen ()
    { M_Search.TurnOn () ;
      M_Insert.TurnOn () ;
      M_Run.TurnOn () ;

      M_SaveAs.TurnOn () ;

      M_Close.TurnOn () ;
      M_CloseAll.TurnOn () ;

      M_PageSetup.TurnOn () ;
      M_HeaderFooter.TurnOn () ;
      M_PrintPreview.TurnOn () ;
      M_Print.TurnOn () ;

      M_Paste.TurnOn () ;
      M_SelectAll.TurnOn () ;
    }

    public static void SelectedDocHasChanges ()
    { M_Save.TurnOn () ;
      M_SaveAll.TurnOn () ;
    }

    public static void SomeDocHasChanges ()
    { M_Save.TurnOff () ;
      M_SaveAll.TurnOn () ;
    }

    public static void NoDocHasChanges ()
    { M_Save.TurnOff () ;
      M_SaveAll.TurnOff () ;
    }

    public static void DocHasSelection ()
    { M_Cut.TurnOn () ;
      M_Copy.TurnOn () ;
    }

    public static void DocHasNoSelection ()
    { M_Cut.TurnOff () ;
      M_Copy.TurnOff () ;
    }

  }
}

/* End */
