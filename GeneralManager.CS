/* Model Editor / GeneralManager

   Created : 2011-04-05
   Last Modified : 2011-04-09
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class GeneralManager
  { public static void SetSaveFiles (bool Bool)
    { GeneralRegistry.SetSaveFiles (Bool) ;
    }

    public static bool GetSaveFiles ()
    { return GeneralRegistry.GetSaveFiles () ;
    }

    public static void SetUseColor (bool Bool)
    { GeneralRegistry.SetUseColor (Bool) ;
    }

    public static bool GetUseColor ()
    { return GeneralRegistry.GetUseColor () ;
    }

    public static void SetWaitForExit (bool Bool)
    { GeneralRegistry.SetWaitForExit (Bool) ;
    }

    public static bool GetWaitForExit ()
    { return GeneralRegistry.GetWaitForExit () ;
    }

    public static void SetUseTemplateFile (bool Bool)
    { GeneralRegistry.SetUseTemplateFile (Bool) ;
    }

    public static bool GetUseTemplateFile ()
    { return GeneralRegistry.GetUseTemplateFile () ;
    }

    public static void SetTemplateFile (String Filename)
    { GeneralRegistry.SetTemplateFile (Filename) ;
    }

    public static String GetTemplateFile ()
    { return GeneralRegistry.GetTemplateFile () ;
    }

    public static void SetInsertWideFormat (bool Bool)
    { GeneralRegistry.SetInsertWideFormat (Bool) ;
    }

    public static bool GetInsertWideFormat ()
    { return GeneralRegistry.GetInsertWideFormat () ;
    }

  }
}

/* End */
