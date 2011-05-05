/* Model Editor / ColorHighlighter

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

/* The color highlighter sets Modified to true which
   doesn't really count as a change. So save the
   modified state and restore at the end.

   The color highlighter also fires the text changed
   and selection changed events, so we must turn off
   the handlers when the highlighter is active.      */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class ColorHighlighter
  { public static bool Active = false ;

    private int Index ;
    private int Next ;

    private RichTextBox Box ; 

    public static void Parse (RichTextBox RTB)
    { ColorHighlighter CH = new ColorHighlighter () ;

      CH.Box = RTB ;
      CH.Index = 0 ;

      try
      { Active = true ;
        bool ModifiedState = CH.Box.Modified ;

        CH.ParseEngine () ;

        CH.Box.Modified = ModifiedState ;
        Active = false ;
      }

      catch
      { CH.ShowIncidentalToEnd () ;
      }
    }

    private void ParseEngine ()
    { bool Done = false ;

      do
      { Next = Box.Text.IndexOf ('<', Index) ;

        if (Next == -1)
        { Done = true ;
        }
        else
        { ShowIncidental () ;

          if (Box.Text [Next + 1] == '/')
          { ShowContent () ;
          }

          Index = Next ;

          if (Box.Text [Index + 1] == '!')
          { ShowComment () ;
          }
          else if (Box.Text [Index + 1] == '?')
          { ShowProcessing () ;
          }
          else
          { ParseAndShowTag() ;
          }

          Index = Next + 1 ;
        }
      }
      while (! Done) ;
 
      ShowIncidentalToEnd () ;
    }

    private void AdvanceTo (String Target)
    { Next = Box.Text.IndexOf (Target, Index) ;

      if (Next == -1)
      { throw (new Exception ()) ;
      }
    }

    private void ParseAndShowTag ()
    { AdvanceTo (">") ;

      int Count = Next - Index ;

      Box.Select (Index, Count + 1) ;
      Box.SelectionColor = ColorManager.Get ("Tag") ;
    }

    /* We call ShowContent () with Index pointing to 1 past >
       and Next pointing to < .                              */

    private void ShowContent ()
    { Box.Select (Index, Next - Index + 1) ;
      Box.SelectionColor = ColorManager.Get ("Content") ;
    }

    /* We call ShowComment () and ShowProcessing (also
       ParseAndShowTag () with Index pointing to < and
       Next undefined.                                  */

    private void ShowComment ()
    { AdvanceTo ("-->") ;

      Box.Select (Index, Next - Index + 3) ;
      Box.SelectionColor = ColorManager.Get ("Comment") ;
    }

    private void ShowProcessing ()
    { AdvanceTo ("?>") ;

      Box.Select (Index, Next - Index + 2) ;
      Box.SelectionColor = ColorManager.Get ("Processing") ;
    }

    private void ShowIncidental ()
    { Box.Select (Index, Next - Index) ;
      Box.SelectionColor = ColorManager.Get ("Incidental") ;
    }

    private void ShowIncidentalToEnd ()
    { Next = Box.Text.Length ;
      ShowIncidental () ;
    }
  }
}

/* End */
