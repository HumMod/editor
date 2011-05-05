/* Model Controller / I_ImplicitEq

   Created : 2011-04-13
   Last Modified : 2011-04-13
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_ImplicitEq
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ImplicitEq" ;
      Insert.Label = "<impliciteq>...</impliciteq>" ;
      Insert.Content += "      <impliciteq>" + nl ;
      Insert.Content += "        <name>...</name>" + nl ;
      Insert.Content += "        <startname>...</startname>" + nl ;
      Insert.Content += "        <initialval>...</initialval>" + nl ;
      Insert.Content += "        <endname>...</endname>" + nl ;
      Insert.Content += "        <errorlim>...</errorlim>" + nl ;
      Insert.Content += "        <searchmin>...</searchmin>" + nl ;
      Insert.Content += "        <searchmax>...</searchmax>" + nl ;
      Insert.Content += "      </impliciteq>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "      <!--<searchminname>...</searchminname>-->" + nl ;
      Insert.Content += "      <!--<searchmaxname>...</searchmaxname>-->" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
