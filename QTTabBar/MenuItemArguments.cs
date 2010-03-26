// Generated by Reflector from c:\program files\qttabbar\QTTabBar.dll
namespace QTTabBarLib
{
  using System;
  
  internal sealed class MenuItemArguments
  {
    public string Argument;
    public MenuGenre Genre;
    public int Index;
    public bool IsBack;
    public int KeyShortcut;
    public string OriginalArgument;
    public string OriginalWorkingDirectory;
    public string Path;
    public MenuTarget Target;
    public bool TokenReplaced;
    public string WorkingDirectory;
    
    public MenuItemArguments(string path, MenuTarget target, MenuGenre genre)
    {
      this.Path = path;
      this.Genre = genre;
      this.Target = target;
    }
    
    public MenuItemArguments(string path, bool fback, int index, MenuGenre genre)
    {
      this.Path = path;
      this.IsBack = fback;
      this.Index = index;
      this.Genre = genre;
    }
    
    public MenuItemArguments(string path, string arg, string work, int keyShortcut, MenuGenre genre)
    {
      this.Path = path;
      this.Argument = this.OriginalArgument = arg;
      this.WorkingDirectory = this.OriginalWorkingDirectory = work;
      this.KeyShortcut = keyShortcut;
      this.Genre = genre;
    }
    
    public void RestoreOriginalArgs()
    {
      this.Argument = this.OriginalArgument;
      this.WorkingDirectory = this.OriginalWorkingDirectory;
    }
  }
}
