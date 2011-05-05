/* Model Editor / Options_Font

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Options_Font : TabPage
  { private static Options_Font This ;

    private Font EditingFont ;

    private Label EditingFontFamily ;
    private Label EditingSizeInPoints ;
    private Label EditingStyle ;

    private Font PrintingFont ;

    private Label PrintingFontFamily ;
    private Label PrintingSizeInPoints ;
    private Label PrintingStyle ;

    public Options_Font ()
    { This = this ;

      Text = " Font " ;

      new Note (this, 20, 10, "Editing Font") ;

      EditingFontFamily = new Label () ;

      EditingFontFamily.Parent = this ;
      EditingFontFamily.Location = new Point (20, 35) ;
      EditingFontFamily.AutoSize = true ;

      EditingSizeInPoints = new Label () ;

      EditingSizeInPoints.Parent = this ;
      EditingSizeInPoints.Location = new Point (20, 50) ;
      EditingSizeInPoints.AutoSize = true ;

      EditingStyle = new Label () ;

      EditingStyle.Parent = this ;
      EditingStyle.Location = new Point (20, 65) ;
      EditingStyle.AutoSize = true ;

      UpdateEditingLabels () ;

      Button ChangeEditingFont = new Button () ;

      ChangeEditingFont.Parent = this ;
      ChangeEditingFont.Location = new Point (20, 90) ;
      ChangeEditingFont.Size = new Size (100, 20) ;
      ChangeEditingFont.Text = "Change Font" ;
      ChangeEditingFont.Click += new EventHandler (OnChangeEditingFont) ;

      Button ResetEditingFont = new Button () ;

      ResetEditingFont.Parent = this ;
      ResetEditingFont.Location = new Point (130, 90) ;
      ResetEditingFont.Size = new Size (100, 20) ;
      ResetEditingFont.Text = "Reset Font" ;
      ResetEditingFont.Click += new EventHandler (OnResetEditingFont) ;

      new Note (this, 20, 130, "Printing Font") ;

      PrintingFontFamily = new Label () ;

      PrintingFontFamily.Parent = this ;
      PrintingFontFamily.Location = new Point (20, 155) ;
      PrintingFontFamily.AutoSize = true ;

      PrintingSizeInPoints = new Label () ;

      PrintingSizeInPoints.Parent = this ;
      PrintingSizeInPoints.Location = new Point (20, 170) ;
      PrintingSizeInPoints.AutoSize = true ;

      PrintingStyle = new Label () ;

      PrintingStyle.Parent = this ;
      PrintingStyle.Location = new Point (20, 185) ;
      PrintingStyle.AutoSize = true ;

      UpdatePrintingLabels () ;

      Button ChangePrintingFont = new Button () ;

      ChangePrintingFont.Parent = this ;
      ChangePrintingFont.Location = new Point (20, 210) ;
      ChangePrintingFont.Size = new Size (100, 20) ;
      ChangePrintingFont.Text = "Change Font" ;
      ChangePrintingFont.Click += new EventHandler (OnChangePrintingFont) ;

      Button ResetPrintingFont = new Button () ;

      ResetPrintingFont.Parent = this ;
      ResetPrintingFont.Location = new Point (130, 210) ;
      ResetPrintingFont.Size = new Size (100, 20) ;
      ResetPrintingFont.Text = "Reset Font" ;
      ResetPrintingFont.Click += new EventHandler (OnResetPrintingFont) ;

    }

    public void OnChangeEditingFont (object Obj, EventArgs EA)
    { FontDialog FD = new FontDialog () ;
      FD.Font = EditingFont ;

      if (FD.ShowDialog () == DialogResult.OK)
      { FontManager.SetEditing (FD.Font) ;
        UpdateEditingLabels () ;
      }
    }

    public void OnResetEditingFont (object Obj, EventArgs EA)
    { FontManager.SetEditing (MainWindow.BasicFont) ;
      UpdateEditingLabels () ;
    }


    public void UpdateEditingLabels ()
    { EditingFont = FontManager.GetEditing () ;

      EditingFontFamily.Text = "Font Family : " + EditingFont.FontFamily.Name ;
      EditingSizeInPoints.Text = "Size In Points : " + EditingFont.SizeInPoints.ToString () ;
      EditingStyle.Text = "Style : " + EditingFont.Style.ToString () ;
    }

    public void OnChangePrintingFont (object Obj, EventArgs EA)
    { FontDialog FD = new FontDialog () ;
      FD.Font = PrintingFont ;

      if (FD.ShowDialog () == DialogResult.OK)
      { FontManager.SetPrinting (FD.Font) ;
        UpdatePrintingLabels () ;
      }
    }

    public void OnResetPrintingFont (object Obj, EventArgs EA)
    { FontManager.SetPrinting (MainWindow.BasicFont) ;
      UpdatePrintingLabels () ;
    }


    public void UpdatePrintingLabels ()
    { PrintingFont = FontManager.GetPrinting () ;

      PrintingFontFamily.Text = "Font Family : " + PrintingFont.FontFamily.Name ;
      PrintingSizeInPoints.Text = "Size In Points : " + PrintingFont.SizeInPoints.ToString () ;
      PrintingStyle.Text = "Style : " + PrintingFont.Style.ToString () ;
    }

  }
}

/* End */
