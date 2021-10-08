using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Axenta.Properties
{
	// Token: 0x0200000C RID: 12
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000050 RID: 80 RVA: 0x001644B0 File Offset: 0x0015F6B0
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000051 RID: 81 RVA: 0x001644C4 File Offset: 0x0015F6C4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("Axenta.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00164504 File Offset: 0x0015F704
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00164518 File Offset: 0x0015F718
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0016452C File Offset: 0x0015F72C
		internal static Bitmap cancel_28px
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("cancel_28px", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00164558 File Offset: 0x0015F758
		internal static Bitmap eye_32px
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("eye_32px", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00164584 File Offset: 0x0015F784
		internal static Bitmap eye_32px1
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("eye_32px1", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000057 RID: 87 RVA: 0x001645B0 File Offset: 0x0015F7B0
		internal static Bitmap Layer_1
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Layer_1", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000058 RID: 88 RVA: 0x001645DC File Offset: 0x0015F7DC
		internal static Bitmap settings_28px
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("settings_28px", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00164608 File Offset: 0x0015F808
		internal static Bitmap target_28px
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("target_28px", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00164634 File Offset: 0x0015F834
		internal static Bitmap Untitled
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Untitled", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000084 RID: 132
		private static ResourceManager resourceMan;

		// Token: 0x04000085 RID: 133
		private static CultureInfo resourceCulture;
	}
}
