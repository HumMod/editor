/* Model Editor / MsgBox

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

/* The DialogResult enumeration is

     None (No action)
     OK
     Cancel
     Abort
     Retry
     Ignore
     Yes
     No

   The MessageBoxButtons enumeration is

     OK
     OKCancel
     AbortRetryIgnore
     YesNoCancel
     YesNo
     RetryCancel

   The MessageBoxIcon enumeration is

     None
     Hand
     Question
     Exclamation
     Asterisk
     Stop
     Error
     Information                            */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class MsgBox
  { public static void Show (String TextArg)
    { MessageBox.Show (TextArg, AppMain.AppName) ;
    }

    public static DialogResult YesNo (String TextArg)
    { return MessageBox.Show (TextArg, AppMain.AppName,
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;
    }

    public static DialogResult YesNoCancel (String TextArg)
    { return MessageBox.Show (TextArg, AppMain.AppName,
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) ;
    }

  }
}

/* End */
