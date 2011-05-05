/* Model Controller / Insert_Manager

   Created : 2011-04-11
   Last Modified : 2011-04-11
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Insert_Manager
  { private static ArrayList Inserts = new ArrayList (100) ;
    private static TreeNode Node ;
    private static TreeView Tree ;

    public static void Install (TreeView TreeArg)
    { Tree = TreeArg ;

      I_Model.Install () ;
      I_ProcessingInstructions.Install () ;

      ExpandModel () ;

    }

    public static void Push ()
    { Insert_Stack.TreeStack.Push (Node) ;
    }

    public static void Pop ()
    { Insert_Stack.TreeStack.Pop () ;
    }

    public static void Add (Insert_Data Insert)
    { if (! InInserts (Insert))
      { Inserts.Add (Insert) ;
      }

      Node = new TreeNode () ;

      Node.Text = Insert.Label ;
      Node.Tag = Insert.Name ;

      TreeNode Parent = (TreeNode) Insert_Stack.TreeStack.Peek() ;
      Parent.Nodes.Add (Node) ;
    }

    public static void AddToRoot (Insert_Data Insert)
    { if (! InInserts (Insert))
      { Inserts.Add (Insert) ;
      }

      Node = new TreeNode () ;

      Node.Text = Insert.Label ;
      Node.Tag = Insert.Name ;

      Tree.Nodes.Add (Node) ;
    }

    public static void Select (String NameArg)
    { foreach (Insert_Data Insert in Inserts)
      { if (Insert.Name == NameArg)
        { if (! GeneralRegistry.GetInsertWideFormat ())
          { EditManager.Insert (Insert.Content) ;
          }
          else if (Insert.WideContent == "")
          { EditManager.Insert (Insert.Content) ;
          }
          else
          { EditManager.Insert (Insert.WideContent) ;
          }
        }
      }
    }

    private static bool InInserts (Insert_Data InsertArg)
    { foreach (Insert_Data Insert in Inserts)
      { if (Insert.Name == InsertArg.Name)
        { return true ;
        }
      }

      return false ;
    }

    private static void ExpandModel ()
    { foreach (TreeNode Node in Tree.Nodes)
      { if (Node.Text == "<model>...</model>")
        { Node.Expand () ;
        }
      }
    }

  }   
}

/* End */
