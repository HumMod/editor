/* Model Editor / EditManager

   Created : 2011-04-11
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.IO ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class EditManager
  { public static void Insert (String Text)
    { if (TabManager.HasTabs ())
      { RichTextBox Box = TabManager.GetBox () ;

        /* If text is selected, it is replaced. If
           no text is selected, new text is inserted
           at the insertion point or caret.           */

        Box.SelectedText = Text ;
      }
    }

    public static int Find (String Text, int Index, RichTextBoxFinds Flags)
    { if (TabManager.HasTabs ())
      { RichTextBox Box = TabManager.GetBox () ;

        Index = Box.Find (Text, Index, Flags) ;

        if (Index != -1)
        { Box.SelectionStart = Index ;
          Box.SelectionLength = Text.Length ;
          Box.HideSelection = false ;
        }
      }
      else
      { Index = -1 ;
      }

      return Index ;
    }

    public static void RefreshColorHighlighter ()
    { if (TabManager.HasTabs ())
      { RichTextBox Box = TabManager.GetBox () ;
        ColorHighlighter.Parse (Box) ;
      }
    }

    public static void Cut ()
    { if (TabManager.HasTabs ())
      { RichTextBox Box = TabManager.GetBox () ;
        Box.Cut () ;
      }
    }
    
    public static void Copy ()
    { if (TabManager.HasTabs ())
      { RichTextBox Box = TabManager.GetBox () ;
        Box.Copy () ;
      }
    }
    
    public static void Paste ()
    { if (TabManager.HasTabs ())
      { RichTextBox Box = TabManager.GetBox () ;
        Box.Paste () ;
      }
    }
    
    public static void SelectAll ()
    { if (TabManager.HasTabs ())
      { RichTextBox Box = TabManager.GetBox () ;
        Box.SelectAll () ;
      }
    }
    
  }
}

/* End */
