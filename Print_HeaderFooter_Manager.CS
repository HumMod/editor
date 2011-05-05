/* Model Editor / Print_HeaderFooter_Manager

   Created : 2011-05-03
   Last Modified : 2011-05-03
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Drawing.Printing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Print_HeaderFooter_Manager
  { private static String Filename ;
    private static String TimeStamp ;
    private static int PageNumber ;

    public static void Init ()
    { Filename = TabManager.GetFilename () ;
      TimeStamp = DateTime.Now.ToString () ;
      PageNumber = 0 ;
    }

    public static void Refresh ()
    { PageNumber++ ;
    }

    public static bool HasHeader ()
    { if (Print_Registry.Get_TopLeft () != "")
      { return true ;
      }

      if (Print_Registry.Get_TopRight () != "")
      { return true ;
      }

      return false ;
    }

    public static bool HasFooter ()
    { if (Print_Registry.Get_BottomLeft () != "")
      { return true ;
      }

      if (Print_Registry.Get_BottomRight () != "")
      { return true ;
      }

      return false ;
    }

    public static String Get_TopLeft ()
    { return MakeText (Print_Registry.Get_TopLeft ()) ;
    }

    public static String Get_TopRight ()
    { return MakeText (Print_Registry.Get_TopRight ()) ;
    }

    public static String Get_BottomLeft ()
    { return MakeText (Print_Registry.Get_BottomLeft ()) ;
    }

    public static String Get_BottomRight ()
    { return MakeText (Print_Registry.Get_BottomRight ()) ;
    }

    private static String MakeText (String Text)
    { if (Text == "Filename")
      { return Filename ;
      }
      else if (Text == "Date-Time")
      { return TimeStamp ;
      }
      else if (Text == "Page Number")
      { return "Page " + PageNumber.ToString () ;
      }
      else
      { return Text ;
      }
    }

  }
}

/* End */
