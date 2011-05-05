/* Model Editor / Options_Solving_Executables

   Created : 2011-04-06
   Last Modified : 2011-04-06
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Options_Solving_Executables : TabPage
  { private RadioButton Modular ;
    private RadioButton Combined ;

    public Options_Solving_Executables ()
    { Text = " Controller - Solver " ;

      Modular = new RadioButton () ;

      Modular.Parent = this ;
      Modular.Text = "Modular Controller And Solver" ;
      Modular.AutoSize = true ;
      Modular.Location = new Point (10, 10) ;
      Modular.Checked = RunRegistry.GetIsModular () ;
      Modular.CheckedChanged += new EventHandler (OnModular) ;

      Options_Solving_Controller ControllerPanel = new Options_Solving_Controller () ;

      ControllerPanel.Parent = this ;
      ControllerPanel.Location = new Point (16, 30) ;
      ControllerPanel.Size = new Size (500, 80) ;

      Options_Solving_Solver SolverPanel = new Options_Solving_Solver () ;

      SolverPanel.Parent = this ;
      SolverPanel.Location = new Point (16, 120) ;
      SolverPanel.Size = new Size (500, 80) ;

      Combined = new RadioButton () ;

      Combined.Parent = this ;
      Combined.Text = "Combined Controller And Solver" ;
      Combined.AutoSize = true ;
      Combined.Location = new Point (10, 230) ;
      Combined.Checked = ! RunRegistry.GetIsModular () ;
      Combined.CheckedChanged += new EventHandler (OnCombined) ;

      Options_Solving_Combined CombinedPanel = new Options_Solving_Combined () ;

      CombinedPanel.Parent = this ;
      CombinedPanel.Location = new Point (16, 250) ;
      CombinedPanel.Size = new Size (500, 80) ;
   }

    private void OnModular (object Obj, EventArgs EA)
    { if (Modular.Checked)
      { RunRegistry.SetIsModular (true) ;
      }
    }

    private void OnCombined (object Obj, EventArgs EA)
    { if (Combined.Checked)
      { RunRegistry.SetIsModular (false) ;
      }
    }

  }
}

/* End */
