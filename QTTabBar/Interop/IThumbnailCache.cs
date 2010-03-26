// Generated by Reflector from c:\program files\qttabbar\QTTabBar.dll
namespace QTTabBarLib.Interop
{
  using System;
  using System.Runtime.InteropServices;
  using System.Security;
  
  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), SuppressUnmanagedCodeSecurity, Guid("F676C15D-596A-4ce2-8234-33996F445DB1")]
  internal interface IThumbnailCache
  {
    [PreserveSig]
    int GetThumbnail(IShellItem pShellItem, uint cxyRequestedThumbSize, uint flags, out ISharedBitmap ppvThumb, ref uint pOutFlags, [In, Out] ref WTS_THUMBNAILID pThumbnailID);
    [PreserveSig]
    int GetThumbnailByID(ref WTS_THUMBNAILID thumbnailID, uint cxyRequestedThumbSize, out ISharedBitmap ppvThumb, ref uint pOutFlags);
  }
}
