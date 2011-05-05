/* Model Editor / FileTree

   Created : 2011-04-08
   Last Modified : 2011-04-20
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

/* Thank you Chandana Subasinghe for the basic concepts. */

using System ;
using System.Collections ;
using System.Drawing ;
using System.IO;
using System.Windows.Forms ;

namespace ModelEditor
{ class FileTree : TreeView
  { public static FileTree This ;
    private static TreeNode CurrentPick = null ;

    public FileTree (Panel ParentArg)
    { This = this ;

      Parent = ParentArg ;

      Dock = DockStyle.Fill ;
      BeforeExpand += new TreeViewCancelEventHandler (OnExpand) ; 
      BeforeSelect += new TreeViewCancelEventHandler (OnSelect) ;

      foreach (DriveInfo Drive in DriveInfo.GetDrives())
      { TreeNode Child = new TreeNode();

        Child.Text = Drive.Name;
        Child.Nodes.Add("");

        Nodes.Add (Child);
      }

      Restore () ;
    }

    private void OnExpand (object Obj, TreeViewCancelEventArgs EA)
    { if (EA.Node.Nodes[0].Text == "")
      { MakeNodes (EA.Node);
      }
    }

    private void OnSelect (object Obj, TreeViewCancelEventArgs EA)
    { EA.Cancel = true ;

      if (EA.Action == TreeViewAction.ByMouse)
      { if (EA.Node.Tag != null) 
        { IO_Open.Open ((String) EA.Node.Tag) ;
          CurrentPick = EA.Node ;
        }
      }
    }

    private void MakeNodes (TreeNode ParentNode)
    { try
      { ParentNode.Nodes.Clear () ; 

        DirectoryInfo RootDir ;
        RootDir = new DirectoryInfo(ParentNode.FullPath + "\\") ;
                
        foreach (DirectoryInfo Dir in RootDir.GetDirectories())
        { TreeNode Node = new TreeNode() ;

          Node.Text = Dir.Name ;
          Node.Tag = null ;
          Node.Nodes.Add("") ;

          ParentNode.Nodes.Add(Node) ;
        }

        foreach (FileInfo File in RootDir.GetFiles())
        { TreeNode Node = new TreeNode();

          Node.Text = File.Name ;
          Node.Tag = (object) File.FullName ;
          Node.ContextMenu = new FileContextMenu (File.FullName) ;

          ParentNode.Nodes.Add(Node) ;
        }
      }

      catch
      { MsgBox.Show ("Building the file tree failed.") ;
      }
    }    

    /* FullPath works if the CurrentPick is a
       selection, but it throws when current
       pick is a folder. Catch.               */

    public void Save ()
    { if (GeneralRegistry.GetRestoreFileTree ())
      { if (CurrentPick != null)
        { try
          { String Path = CurrentPick.FullPath ;
            FileRegistry.SetFileTreePath (Path) ;
          }

          catch {}
        }
      }
    }

    /* The FullPath property gives us something like

         C:\\Model Library\Windkessel.DES

       when the Windkessel model was the last file
       selected. Note the double backslash after the
       drive. We do a Replace (Old, New) to get rid
       of \\ before splitting.                       */

    private void Restore ()
    { if (! GeneralRegistry.GetRestoreFileTree ())
      { return ;
      }

      if (! FileRegistry.HasFileTreePath ())
      { return ;
      }

      TreeNode CurrentNode = null ;

      String Path = FileRegistry.GetFileTreePath () ;
      Path = Path.Replace ("\\\\", "\\") ;

      String [] Tokens = Path.Split (new char [] { '\\' });

      try
      { foreach (TreeNode Node in Nodes)
        { if (Node.Text == Tokens [0] + "\\")
          { CurrentNode = Node ;
            MakeNodes (CurrentNode) ;
            CurrentNode.Expand () ;
          }
        }

        for (int i = 1 ; i <= Tokens.Length - 2 ; i++)
        { ArrayList List = new ArrayList (CurrentNode.Nodes) ;

          foreach (TreeNode Node in List)
          { if (Node.Text == Tokens [i])
            { CurrentNode = Node ;
              MakeNodes (CurrentNode) ;
              CurrentNode.Expand () ;
            }
          }
        }
      }

      catch
      { MsgBox.Show ("Can't restore this path : " + Path) ;
      }
    }

    public void RefreshTree ()
    { try
      { TreeNode Node = CurrentPick.Parent ;

        Node.Collapse () ;
        MakeNodes (Node) ;
        Node.Expand () ;
      }

      catch {}
    }

  }
}

/* End */
