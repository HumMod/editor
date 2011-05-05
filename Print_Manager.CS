/* Model Editor / Print_Manager

   Created : 2011-04-14
   Last Modified : 2011-04-19
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

/* Thank you Charlie Petzold for the sample code. */

using System ;
using System.Drawing ;
using System.Drawing.Printing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Print_Manager
  { public static PrintDocument PrintDoc ;

    private static PageSetupDialog SetupDlg ;
    private static PrintPreviewDialog PreviewDlg ;
    private static PrintDialog PrintDlg  ;

    private static String DocumentName ;
    private static String Content ;

    public static void Install ()
    { PrintDoc = new PrintDocument () ;

      SetupDlg = new PageSetupDialog () ;
      PreviewDlg = new PrintPreviewDialog () ;
      PrintDlg = new PrintDialog () ;

      SetupDlg.Document = PrintDoc ;
      PreviewDlg.Document = PrintDoc ;
      PrintDlg.Document = PrintDoc ;

      PrintDoc.PrintPage += new PrintPageEventHandler (OnPrintPage) ;
    }

    public static void PageSetup ()
    { DocumentName = TabManager.GetFilename () ;
      Content = TabManager.GetText () ;

      PrintDoc.DocumentName = DocumentName ;

      PrintDoc.DefaultPageSettings.Margins = Print_Registry.GetMargins () ;
      PrintDoc.DefaultPageSettings.Landscape = Print_Registry.GetLandscape () ;

      DialogResult OK = SetupDlg.ShowDialog () ;

      if (OK != DialogResult.OK)
      { return ;
      }

      Print_Registry.SetMargins (PrintDoc.DefaultPageSettings.Margins) ;
      Print_Registry.SetLandscape (PrintDoc.DefaultPageSettings.Landscape) ;
      
    }

    public static void HeaderFooter ()
    { DocumentName = TabManager.GetFilename () ;
      Content = TabManager.GetText () ;

      PrintDoc.DocumentName = DocumentName ;

      Print_HeaderFooter_Dialog Dlg = new Print_HeaderFooter_Dialog () ;
      Dlg.ShowDialog () ;
    }

    public static void PrintPreview ()
    { DocumentName = TabManager.GetFilename () ;
      Content = TabManager.GetText () ;

      PrintDoc.DocumentName = DocumentName ;
      Print_HeaderFooter_Manager.Init () ;

      PreviewDlg.ShowDialog () ;
    }

    public static void Print ()
    { DocumentName = TabManager.GetFilename () ;
      Content = TabManager.GetText () ;

      PrintDoc.DocumentName = DocumentName ;
      Print_HeaderFooter_Manager.Init () ;

      DialogResult OK = PrintDlg.ShowDialog () ;

      if (OK == DialogResult.OK)
      { PrintDoc.Print () ;
      }
    }

    private static void OnPrintPage (object Obj, PrintPageEventArgs EA)
    { Graphics Grfx = EA.Graphics ;
      Font PrintFont = FontManager.GetPrinting () ;

      Rectangle PrintArea = new Rectangle () ;
      PrintArea = EA.MarginBounds ;

      float FontHeight = PrintFont.GetHeight (Grfx) ;

      Print_HeaderFooter_Manager.Refresh () ;

      if (Print_HeaderFooter_Manager.HasHeader ())
      { Rectangle Rect = new Rectangle () ;

        Rect.X = PrintArea.X ;
        Rect.Y = PrintArea.Y ;
        Rect.Width = PrintArea.Width ;
        Rect.Height = (int) (2 * FontHeight) ;

        PrintArea.Y = PrintArea.Y + Rect.Height ;
        PrintArea.Height = PrintArea.Height - Rect.Height ;

        StringFormat StrFmt = new StringFormat () ;

        StrFmt.LineAlignment = StringAlignment.Near ;

        StrFmt.Alignment = StringAlignment.Near ;
        Grfx.DrawString (Print_HeaderFooter_Manager.Get_TopLeft (),
          PrintFont, Brushes.Black, Rect, StrFmt) ;

        StrFmt.Alignment = StringAlignment.Far ;
        Grfx.DrawString (Print_HeaderFooter_Manager.Get_TopRight (),
          PrintFont, Brushes.Black, Rect, StrFmt) ;
      }


      if (Print_HeaderFooter_Manager.HasFooter ())
      { Rectangle Rect = new Rectangle () ;

        Rect.Height = (int) (2 * FontHeight) ;
        Rect.X = PrintArea.X ;
        Rect.Y = PrintArea.Bottom - Rect.Height ;
        Rect.Width = PrintArea.Width ;

        PrintArea.Height = PrintArea.Height - Rect.Height ;

        StringFormat StrFmt = new StringFormat () ;

        StrFmt.LineAlignment = StringAlignment.Far ;

        StrFmt.Alignment = StringAlignment.Near ;
        Grfx.DrawString (Print_HeaderFooter_Manager.Get_BottomLeft (),
          PrintFont, Brushes.Black, Rect, StrFmt) ;

        StrFmt.Alignment = StringAlignment.Far ;
        Grfx.DrawString (Print_HeaderFooter_Manager.Get_BottomRight (),
          PrintFont, Brushes.Black, Rect, StrFmt) ;
      }

      int TotalLines = (int) Math.Floor (PrintArea.Height / FontHeight) ;

      PrintArea.Height = (int) (TotalLines * FontHeight) ;

      StringFormat PageFmt = new StringFormat () ;

      PageFmt.Trimming = StringTrimming.EllipsisCharacter ;
      PageFmt.FormatFlags |= StringFormatFlags.NoWrap ;

      int Chars ;
      int Lines ;

      Grfx.MeasureString (Content, PrintFont, PrintArea.Size,
         PageFmt, out Chars, out Lines) ;

      Grfx.DrawString (Content, PrintFont, Brushes.Black,
         PrintArea, PageFmt) ;

      Content = Content.Substring (Chars) ;

      if (Content.Length == 0)
      { Content = TabManager.GetText () ;
      }
      else
      { EA.HasMorePages = true ;
      }
    }

  }
}

/* End */
