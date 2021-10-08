using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Axenta.Utils
{
	// Token: 0x0200000E RID: 14
	public static class CursorTings
	{
		// Token: 0x0600005E RID: 94
		[DllImport("user32.dll")]
		private static extern bool GetCursorInfo(ref CursorTings.CursorS pci);

		// Token: 0x0600005F RID: 95
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000060 RID: 96
		[DllImport("user32.dll")]
		private static extern IntPtr FindWindow(string lpWindowClass, string lpWindowCaption);

		// Token: 0x06000061 RID: 97 RVA: 0x001646AC File Offset: 0x0015F8AC
		public static bool InMenu(this Cursor cursor)
		{
			if (CursorTings.GetForegroundWindow() == CursorTings.FindWindow("LWJGL", null))
			{
				if (!Cursor.Current.IsVisible())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x001646E8 File Offset: 0x0015F8E8
		public static bool IsVisible(this Cursor cursor)
		{
			CursorTings.CursorS cursorS = default(CursorTings.CursorS);
			cursorS.cbSize = Marshal.SizeOf(typeof(CursorTings.CursorS));
			CursorTings.GetCursorInfo(ref cursorS);
			return cursorS.hCursor.ToInt32() > 100000;
		}

		// Token: 0x0200000F RID: 15
		public struct PointS
		{
			// Token: 0x04000087 RID: 135
			public int x;

			// Token: 0x04000088 RID: 136
			public int y;
		}

		// Token: 0x02000010 RID: 16
		public struct CursorS
		{
			// Token: 0x04000089 RID: 137
			public int cbSize;

			// Token: 0x0400008A RID: 138
			public int flags;

			// Token: 0x0400008B RID: 139
			public IntPtr hCursor;

			// Token: 0x0400008C RID: 140
			public CursorTings.PointS pt;
		}
	}
}
