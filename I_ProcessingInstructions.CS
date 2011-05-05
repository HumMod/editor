/* Model Controller / I_ProcessingInstructions

   Created : 2011-04-11
   Last Modified : 2011-04-12
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_ProcessingInstructions
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Include" ;
      Insert.Label = "<?include ?>" ;
      Insert.Content = "<?include ?>" + nl ;

      Insert_Manager.AddToRoot (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "Path" ;
      Insert.Label = "<?path ?>" ;
      Insert.Content = "<?path ?>" + nl ;

      Insert_Manager.AddToRoot (Insert) ;

      Insert = new Insert_Data () ;

      Insert.Name = "Comment" ;
      Insert.Label = "<!-- comment -->" ;
      Insert.Content = "<!--  -->" + nl ;

      Insert_Manager.AddToRoot (Insert) ;


    } 
  }
}

/* End */
