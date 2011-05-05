/* Model Editor / IO_Reader

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ModelEditor
{ public class IO_Reader
  { public static String Read (String Filename)
    { try
      { StatusBarManager.ShowText ("Reading " + Filename + " ... ") ;

        StreamReader SR = new StreamReader(Filename) ;
        String Content = SR.ReadToEnd() ;
        SR.Close();

        StatusBarManager.AddText ("Done") ;
        return Content ;
      }

      catch
      { StatusBarManager.AddText ("Failed") ;
        return null ;             
      }
    }
  }
}

/* End */
