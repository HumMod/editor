/* Model Editor / RunManager_Modular

   Created : 2011-04-07
   Last Modified : 2011-04-07
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Diagnostics ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class RunManager_Modular
  { private static Process Task ;
    private static bool Running = false ;

    public static void Run ()
    { if (Running)
      { if (! Task.HasExited)
        { AlreadyRunning () ;
          return ;
        }
      }

      String Controller = RunRegistry.GetController () ;

      if (! System.IO.File.Exists (Controller))
      { CantFind ("controller", Controller) ;
        return ;
      }

      String Solver = RunRegistry.GetSolver () ;
      String Model = RunRegistry.GetModel () ;

      String Msg = "" ;

      Msg += "<root> " ;
      Msg += "<model> " + Model + " </model>" ;
      Msg += "<solver> " + Solver + " </solver>" ;
      Msg += " </root>" ;

      Task = new Process () ;

      Task.StartInfo.FileName = Controller ;
      Task.StartInfo.Arguments = AddQuotes (Msg) ;

      if (GeneralRegistry.GetWaitForExit ())
      { State.WaitForExit () ;
      }

      bool OK = Task.Start () ;

      /* Task.Start() starts the named task, but also associates
         the task with the process object. You can invoke
         WaitForExit() only after this association has been made.
         If invoked to early, an exception is thrown.             */

      if (GeneralRegistry.GetWaitForExit ())
      { Task.WaitForExit () ;
        State.HaveExit () ;
      }

      if (! OK)
      { FailedToStart (Controller) ;
        Running = false ;
      }
      else
      { Running = true ;
      }

    }

    private static String AddQuotes (String Msg)
    { String Quote = "\"" ;
      return Quote + Msg + Quote ;
    }

    private static void CantFind (String Name, String File)
    { String Msg = "" ;

      Msg += "Can't find this " + Name + " : " + File + ". " ;
      Msg += "Adjust settings." ;

      MsgBox.Show (Msg) ;
    }

    private static void FailedToStart (String Name)
    { String Msg = "" ;

      Msg += "The model controller exists but it failed to start : " ;
      Msg += Name + " File may be corrupted." ;

      MsgBox.Show (Msg) ;
    }

    private static void AlreadyRunning ()
    { String Msg = "" ;

      Msg += "Solver modules are already running. You must " ;
      Msg += "close them before starting a fresh run." ;

      MsgBox.Show (Msg) ;
    }

  }
}

/* End */
