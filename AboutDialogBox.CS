/* Model Editor / AboutDialogBox

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.IO ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class AboutDialogBox : Form
  { public AboutDialogBox ()
    { Text = "About " + AppMain.AppName ;

      StartPosition = FormStartPosition.CenterParent ;
      FormBorderStyle = FormBorderStyle.FixedDialog ;
      ClientSize =  new Size (300, 400) ;

      MaximizeBox = false ;
      MinimizeBox = false ;
      ControlBox = false ;
      ShowInTaskbar = false ;

      Icon DlgIcon = ResourceManager.GetAppIcon () ;

      PictureBox Box = new PictureBox () ;
      Box.Parent = this ;
      Box.Image = DlgIcon.ToBitmap () ;
      Box.SizeMode = PictureBoxSizeMode.AutoSize ;
      Box.Location = new Point (50, 10) ;

      new Note (this, 50,  50, "Model Editor") ;
      new Note (this, 50,  65, "Version 2.0.0") ;

      new Note (this, 50,  90, "Center for Computational Medicine") ;
      new Note (this, 50, 105, "University of Mississippi Medical Center") ;
      new Note (this, 50, 120, "Jackson MS 39216 USA") ;

      new Note (this, 50, 145, "Dr. Tom Coleman") ;
      new Note (this, 50, 160, "Department of Emergency Medicine") ;
      new Note (this, 50, 175, "support@biosim.com") ;

      new Note (this, 50, 200, "Dr. Robert Hester") ;
      new Note (this, 50, 215, "Department of Physiology and Biophysics") ;
      new Note (this, 50, 230, "rhester@umc.edu") ;

      new Note (this, 50, 255, "Dr. Richard Summers") ;
      new Note (this, 50, 270, "Department of Emergency Medicine") ;
      new Note (this, 50, 285, "rsummers@umc.edu") ;

      new Note (this, 50, 310, "Supported by NSF EPSCoR, NIH and NASA.") ;

      new OKButton (this) ;
    }
  }
}

/* End */
