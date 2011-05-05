/* Model Editor / Print_Registry

   Created : 2011-04-25
   Last Modified : 2011-05-02
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Drawing.Printing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Print_Registry
  { private static String MarginsLeftKey = "Print_Margins_Left" ;
    private static String MarginsTopKey = "Print_Margins_Top" ;
    private static String MarginsRightKey = "Print_Margins_Right" ;
    private static String MarginsBottomKey = "Print_Margins_Bottom" ;

    private static String LandscapeKey = "Print_Landscape" ;

    private static String HeaderFooter_TopLeft_Key = "Print_HeaderFooter_TopLeft" ;
    private static String HeaderFooter_TopRight_Key = "Print_HeaderFooter_TopRight" ;
    private static String HeaderFooter_BottomLeft_Key = "Print_HeaderFooter_BottomLeft" ;
    private static String HeaderFooter_BottomRight_Key = "Print_HeaderFooter_BottomRight" ;

    public static void SetMargins (Margins MarginsArg)
    { RegistryManager.SetValue (MarginsLeftKey, (object) MarginsArg.Left.ToString ()) ;
      RegistryManager.SetValue (MarginsTopKey, (object) MarginsArg.Top.ToString ()) ;
      RegistryManager.SetValue (MarginsRightKey, (object) MarginsArg.Right.ToString ()) ;
      RegistryManager.SetValue (MarginsBottomKey, (object) MarginsArg.Bottom.ToString ()) ;
    }

    public static Margins GetMargins ()
    { if (RegistryManager.HasKey (MarginsLeftKey))
      { int Left = (int) RegistryManager.GetValue (MarginsLeftKey) ;
        int Top = (int) RegistryManager.GetValue (MarginsTopKey) ;
        int Right = (int) RegistryManager.GetValue (MarginsRightKey) ;
        int Bottom = (int) RegistryManager.GetValue (MarginsBottomKey) ;

        return new Margins (Left, Top, Right, Bottom) ;
      }
      else
      { return new Margins (100,100,100,100) ;
      }
    }

    public static void SetLandscape (bool State)
    { RegistryManager.SetValue (LandscapeKey, (object) State.ToString ()) ;
    }

    public static bool GetLandscape ()
    { if (RegistryManager.HasKey (LandscapeKey))
      { String Image = (String) RegistryManager.GetValue (LandscapeKey) ;
        return Convert.ToBoolean (Image) ;
      }
      else
      { return false ;
      }
    }

    public static void Set_TopLeft (String Text)
    { RegistryManager.SetValue (HeaderFooter_TopLeft_Key, (object) Text) ;
    }

    public static String Get_TopLeft ()
    { if (RegistryManager.HasKey (HeaderFooter_TopLeft_Key))
      { return (String) RegistryManager.GetValue (HeaderFooter_TopLeft_Key) ;
      }
      else
      { return "" ;
      }
    }

    public static void Set_TopRight (String Text)
    { RegistryManager.SetValue (HeaderFooter_TopRight_Key, (object) Text) ;
    }

    public static String Get_TopRight ()
    { if (RegistryManager.HasKey (HeaderFooter_TopRight_Key))
      { return (String) RegistryManager.GetValue (HeaderFooter_TopRight_Key) ;
      }
      else
      { return "" ;
      }
    }

    public static void Set_BottomLeft (String Text)
    { RegistryManager.SetValue (HeaderFooter_BottomLeft_Key, (object) Text) ;
    }

    public static String Get_BottomLeft ()
    { if (RegistryManager.HasKey (HeaderFooter_BottomLeft_Key))
      { return (String) RegistryManager.GetValue (HeaderFooter_BottomLeft_Key) ;
      }
      else
      { return "" ;
      }
    }

    public static void Set_BottomRight (String Text)
    { RegistryManager.SetValue (HeaderFooter_BottomRight_Key, (object) Text) ;
    }

    public static String Get_BottomRight ()
    { if (RegistryManager.HasKey (HeaderFooter_BottomRight_Key))
      { return (String) RegistryManager.GetValue (HeaderFooter_BottomRight_Key) ;
      }
      else
      { return "" ;
      }
    }

  }
}

/* End */
