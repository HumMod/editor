/* Model Navigator / Options_Colors

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Options_Colors : TabPage
  { private static Options_Colors This ;

    private Label ColorLabel1 ;
    private Label ColorLabel2 ;
    private Label ColorLabel3 ;
    private Label ColorLabel4 ;
    private Label ColorLabel5 ;

    public Options_Colors ()
    { This = this ;

      Text = " Colors " ;

      String Name ;
      Label NameLabel ;
      Color NameColor ;

      Name = "Tag" ;

      NameLabel = new Label () ;

      NameLabel.Parent = this ;
      NameLabel.Location = new Point (20, 10) ;
      NameLabel.AutoSize = true ;
      NameLabel.Text = Name ;

      NameColor = ColorManager.Get (Name) ;

      ColorLabel1 = new Label () ;

      ColorLabel1.Parent = this ;
      ColorLabel1.Location = new Point (85, 10) ;
      ColorLabel1.AutoSize = true ;
      ColorLabel1.Text = NameColor.ToString () ;
      ColorLabel1.ForeColor = NameColor ;
      ColorLabel1.Click += new EventHandler (OnClick1) ;

      Name = "Content" ;

      NameLabel = new Label () ;

      NameLabel.Parent = this ;
      NameLabel.Location = new Point (20, 25) ;
      NameLabel.AutoSize = true ;
      NameLabel.Text = Name ;

      NameColor = ColorManager.Get (Name) ;

      ColorLabel2 = new Label () ;

      ColorLabel2.Parent = this ;
      ColorLabel2.Location = new Point (85, 25) ;
      ColorLabel2.AutoSize = true ;
      ColorLabel2.Text = NameColor.ToString () ;
      ColorLabel2.ForeColor = NameColor ;
      ColorLabel2.Click += new EventHandler (OnClick2) ;

      Name = "Processing" ;

      NameLabel = new Label () ;

      NameLabel.Parent = this ;
      NameLabel.Location = new Point (20, 40) ;
      NameLabel.AutoSize = true ;
      NameLabel.Text = Name ;

      NameColor = ColorManager.Get (Name) ;

      ColorLabel3 = new Label () ;

      ColorLabel3.Parent = this ;
      ColorLabel3.Location = new Point (85, 40) ;
      ColorLabel3.AutoSize = true ;
      ColorLabel3.Text = NameColor.ToString () ;
      ColorLabel3.ForeColor = NameColor ;
      ColorLabel3.Click += new EventHandler (OnClick3) ;

      Name = "Comment" ;

      NameLabel = new Label () ;

      NameLabel.Parent = this ;
      NameLabel.Location = new Point (20, 55) ;
      NameLabel.AutoSize = true ;
      NameLabel.Text = Name ;

      NameColor = ColorManager.Get (Name) ;

      ColorLabel4 = new Label () ;

      ColorLabel4.Parent = this ;
      ColorLabel4.Location = new Point (85, 55) ;
      ColorLabel4.AutoSize = true ;
      ColorLabel4.Text = NameColor.ToString () ;
      ColorLabel4.ForeColor = NameColor ;
      ColorLabel4.Click += new EventHandler (OnClick4) ;

      Name = "Incidental" ;

      NameLabel = new Label () ;

      NameLabel.Parent = this ;
      NameLabel.Location = new Point (20, 70) ;
      NameLabel.AutoSize = true ;
      NameLabel.Text = Name ;

      NameColor = ColorManager.Get (Name) ;

      ColorLabel5 = new Label () ;

      ColorLabel5.Parent = this ;
      ColorLabel5.Location = new Point (85, 70) ;
      ColorLabel5.AutoSize = true ;
      ColorLabel5.Text = NameColor.ToString () ;
      ColorLabel5.ForeColor = NameColor ;
      ColorLabel5.Click += new EventHandler (OnClick5) ;


      new Note (this, 20, 90, "Click on color to edit.") ;

    }

    private void OnClick1 (object Obj, EventArgs EA)
    { ColorDialog CD = new ColorDialog () ;
      CD.Color = ColorManager.Get ("Tag") ;

      if (CD.ShowDialog () == DialogResult.OK)
      { ColorRegistry.Set ("Tag", CD.Color) ;
        ColorLabel1.Text = CD.Color.ToString () ;
        ColorLabel1.ForeColor = CD.Color ;
      }
    }

    private void OnClick2 (object Obj, EventArgs EA)
    { ColorDialog CD = new ColorDialog () ;
      CD.Color = ColorManager.Get ("Content") ;

      if (CD.ShowDialog () == DialogResult.OK)
      { ColorRegistry.Set ("Content", CD.Color) ;
        ColorLabel2.Text = CD.Color.ToString () ;
        ColorLabel2.ForeColor = CD.Color ;
      }
    }

    private void OnClick3 (object Obj, EventArgs EA)
    { ColorDialog CD = new ColorDialog () ;
      CD.Color = ColorManager.Get ("Processing") ;

      if (CD.ShowDialog () == DialogResult.OK)
      { ColorRegistry.Set ("Processing", CD.Color) ;
        ColorLabel3.Text = CD.Color.ToString () ;
        ColorLabel3.ForeColor = CD.Color ;
      }
    }

    private void OnClick4 (object Obj, EventArgs EA)
    { ColorDialog CD = new ColorDialog () ;
      CD.Color = ColorManager.Get ("Comment") ;

      if (CD.ShowDialog () == DialogResult.OK)
      { ColorRegistry.Set ("Comment", CD.Color) ;
        ColorLabel4.Text = CD.Color.ToString () ;
        ColorLabel4.ForeColor = CD.Color ;
      }
    }

    private void OnClick5 (object Obj, EventArgs EA)
    { ColorDialog CD = new ColorDialog () ;
      CD.Color = ColorManager.Get ("Incidental") ;

      if (CD.ShowDialog () == DialogResult.OK)
      { ColorRegistry.Set ("Incidental", CD.Color) ;
        ColorLabel5.Text = CD.Color.ToString () ;
        ColorLabel5.ForeColor = CD.Color ;
      }
    }

  }
}

/* End */
