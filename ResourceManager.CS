/* Model Editor / ResourceManager

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center

   Embed bitmaps, icons and cursors in an application
   in the resource.

   Here are the steps needed to get an image into the
   application

   # Add the file to the project.
   # Use a right click to expose its properties.
   # Change Build Action from Compile to Embedded Resource.

   Use the calls below to get the image when needed.

   The name of the image in the resource is a function
   of the Default Namespace and the original filename.

      DefaultNamespace.FileName.Ext

   The default namespace is the name of the project with
   one additional markup. Spaces in the project name are
   replaced with underscores.

   This project : Model Editor
   Default namespace : Model_Editor               */

using System ;
using System.Drawing ;
using System.Reflection ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class ResourceManager
  { public static Icon GetAppIcon ()
    { String Name = "Model_Editor.Model Editor.ICO" ;
	    return new Icon (Assembly.GetExecutingAssembly ().GetManifestResourceStream (Name)) ;
    }

    public static Bitmap GetBitmap (String NameArg)
    { String Name = "Model_Editor.BMP_" + NameArg + ".BMP" ;
      return new Bitmap (Assembly.GetExecutingAssembly ().GetManifestResourceStream (Name)) ;
    }


  }
}

/* End */
