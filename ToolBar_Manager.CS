/* Model Editor / ToolBar_Manager

   Created : 2011-04-05
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class ToolBar_Manager
  { public static void Install (Panel ParentArg)
    { T_New New = new T_New (0) ;
      T_Open Open = new T_Open (1) ;
      T_Save Save = new T_Save (2) ;
      T_SaveAll SaveAll = new T_SaveAll (3) ;
      T_Close Close = new T_Close (4) ;
      T_Cut Cut = new T_Cut (5) ;
      T_Copy Copy = new T_Copy (6) ;
      T_Paste Paste = new T_Paste (7) ;
      T_Undo Undo = new T_Undo (8) ;
      T_ColorHighlighter ColorHighlighter = new T_ColorHighlighter (9) ;
      T_Search Search = new T_Search (10) ;
      T_Print Print = new T_Print (11) ;

      ToolBarButton Spacer = new ToolBarButton () ;
      Spacer.Style = ToolBarButtonStyle.Separator ;

      ImageList List = new ImageList () ;

      List.Images.Add (New.GetBMP()) ;
      List.Images.Add (Open.GetBMP()) ;
      List.Images.Add (Save.GetBMP()) ;
      List.Images.Add (SaveAll.GetBMP()) ;
      List.Images.Add (Close.GetBMP()) ;
      List.Images.Add (Cut.GetBMP()) ;
      List.Images.Add (Copy.GetBMP()) ;
      List.Images.Add (Paste.GetBMP()) ;
      List.Images.Add (Undo.GetBMP()) ;
      List.Images.Add (ColorHighlighter.GetBMP()) ;
      List.Images.Add (Search.GetBMP()) ;
      List.Images.Add (Print.GetBMP()) ;

      ToolBar Bar = new ToolBar () ;

      Bar.Parent = ParentArg ;
      Bar.ImageList = List ;
      Bar.ShowToolTips = true ;
      Bar.ButtonClick += new ToolBarButtonClickEventHandler (BarClick) ;

      Bar.Buttons.Add (New) ; 
      Bar.Buttons.Add (Open) ; 
      Bar.Buttons.Add (Save) ; 
      Bar.Buttons.Add (SaveAll) ; 
      Bar.Buttons.Add (Close) ;
 
      Bar.Buttons.Add (Spacer) ;
 
      Bar.Buttons.Add (Cut) ; 
      Bar.Buttons.Add (Copy) ; 
      Bar.Buttons.Add (Paste) ; 

      Bar.Buttons.Add (Spacer) ;
 
      Bar.Buttons.Add (Undo) ; 
      Bar.Buttons.Add (ColorHighlighter) ; 
      Bar.Buttons.Add (Search) ; 
      Bar.Buttons.Add (Print) ; 
    }

    private static void BarClick (object Obj, ToolBarButtonClickEventArgs EA)
    { ToolBarButton Clicked = EA.Button ;
      ToolBar_Delegate Call = (ToolBar_Delegate) Clicked.Tag ;
      Call () ;
    }

    public static void TurnOn ()
    { T_New.TurnOn () ;
      T_Open.TurnOn () ;
      T_Save.TurnOn () ;
      T_SaveAll.TurnOn () ;
      T_Close.TurnOn () ;
      T_Cut.TurnOn () ;
      T_Copy.TurnOn () ;
      T_Paste.TurnOn () ;
      T_Undo.TurnOn () ;
      T_ColorHighlighter.TurnOn () ;
      T_Search.TurnOn () ;
      T_Print.TurnOn () ;
    }

    public static void TurnOff ()
    { T_New.TurnOff () ;
      T_Open.TurnOff () ;
      T_Save.TurnOff () ;
      T_SaveAll.TurnOff () ;
      T_Close.TurnOff () ;
      T_Cut.TurnOff () ;
      T_Copy.TurnOff () ;
      T_Paste.TurnOff () ;
      T_Undo.TurnOff () ;
      T_ColorHighlighter.TurnOff () ;
      T_Search.TurnOff () ;
      T_Print.TurnOff () ;
    }

    public static void NoFilesOpen ()
    { T_Save.TurnOff () ;
      T_SaveAll.TurnOff () ;
      T_Close.TurnOff () ;
      T_Cut.TurnOff () ;
      T_Copy.TurnOff () ;
      T_Paste.TurnOff () ;
      T_Undo.TurnOff () ;
      T_ColorHighlighter.TurnOff () ;
      T_Search.TurnOff () ;
      T_Print.TurnOff () ;
    }

    public static void FilesOpen ()
    { T_Close.TurnOn () ;
      T_Paste.TurnOn () ;
      T_Undo.TurnOn () ;
      T_ColorHighlighter.TurnOn () ;
      T_Search.TurnOn () ;
      T_Print.TurnOn () ;
    }

    public static void SelectedDocHasChanges ()
    { T_Save.TurnOn () ;
      T_SaveAll.TurnOn () ;
    }

    public static void SomeDocHasChanges ()
    { T_Save.TurnOff () ;
      T_SaveAll.TurnOn () ;
    }

    public static void NoDocHasChanges ()
    { T_Save.TurnOff () ;
      T_SaveAll.TurnOff () ;
    }

    public static void DocHasSelection ()
    { T_Cut.TurnOn () ;
      T_Copy.TurnOn () ;
    }

    public static void DocHasNoSelection ()
    { T_Cut.TurnOff () ;
      T_Copy.TurnOff () ;
    }

  }
}

/* End */
