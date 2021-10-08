using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Memory;

namespace Axenta.Modules.Visuals
{
	internal class Nametags
	{
		
		public void scan(bool destructing)
		{
			Nametags.scan1 scan = new Nametags.scan1();
		}

		
		public void write(bool enabled, float writeval, bool isDestructing)
		{
			Nametags.<write>d__6 <write>d__ = new Nametags.<write>d__6();
			<write>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<write>d__.<>4__this = this;
			<write>d__.enabled = enabled;
			<write>d__.writeval = writeval;
			<write>d__.isDestructing = isDestructing;
			<write>d__.<>1__state = -1;
			<write>d__.<>t__builder.Start<Nametags.<write>d__6>(ref <write>d__);
		}

		
		public void writeesp(bool enabled, bool isDestructing)
		{
			Nametags.<writeesp>d__7 <writeesp>d__ = new Nametags.<writeesp>d__7();
			<writeesp>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<writeesp>d__.<>4__this = this;
			<writeesp>d__.enabled = enabled;
			<writeesp>d__.isDestructing = isDestructing;
			<writeesp>d__.<>1__state = -1;
			<writeesp>d__.<>t__builder.Start<Nametags.<writeesp>d__7>(ref <writeesp>d__);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00165E30 File Offset: 0x00161030
		public Nametags()
		{
		}

		// Token: 0x040000C3 RID: 195
		public Mem M = new Mem();

		// Token: 0x040000C4 RID: 196
		private string arrayTags = "0F 74 DA 3C";

		// Token: 0x040000C5 RID: 197
		private IEnumerable<long> aTags;

		// Token: 0x040000C6 RID: 198
		private List<long> lTags = new List<long>();

		// Token: 0x040000C7 RID: 199
		private List<string> lastWrittedValues = new List<string>();

		// Token: 0x0200001C RID: 28
		[CompilerGenerated]
		private sealed class scan1 : IAsyncStateMachine
		{
			// Token: 0x0600008B RID: 139 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public scan1()
			{
			}

			// Token: 0x0600008C RID: 140 RVA: 0x00165E70 File Offset: 0x00161070
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<IEnumerable<long>> awaiter;
					if (num != 0)
					{
						if (this.destructing)
						{
							goto IL_16E;
						}
						this.<>4__this.M.OpenProcess("javaw");
						awaiter = this.<>4__this.M.AoBScan(33554432L, 90000000L, this.<>4__this.arrayTags, false, true, "").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							Nametags.scan1 <scan>d__ = this;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<long>>, Nametags.scan1>(ref awaiter, ref <scan>d__);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<long>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					this.<>s__1 = awaiter.GetResult();
					this.<>4__this.aTags = this.<>s__1;
					this.<>s__1 = null;
					this.<>s__2 = this.<>4__this.aTags.GetEnumerator();
					try
					{
						while (this.<>s__2.MoveNext())
						{
							this.<addr>5__3 = this.<>s__2.Current;
							if (!this.<>4__this.lTags.Contains(this.<addr>5__3))
							{
								this.<>4__this.lTags.Add(this.<addr>5__3);
							}
						}
					}
					finally
					{
						if (num < 0 && this.<>s__2 != null)
						{
							this.<>s__2.Dispose();
						}
					}
					this.<>s__2 = null;
					IL_16E:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600008D RID: 141 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000C8 RID: 200
			public int <>1__state;

			// Token: 0x040000C9 RID: 201
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040000CA RID: 202
			public bool destructing;

			// Token: 0x040000CB RID: 203
			public Nametags <>4__this;

			// Token: 0x040000CC RID: 204
			private IEnumerable<long> <>s__1;

			// Token: 0x040000CD RID: 205
			private IEnumerator<long> <>s__2;

			// Token: 0x040000CE RID: 206
			private long <addr>5__3;

			// Token: 0x040000CF RID: 207
			private TaskAwaiter<IEnumerable<long>> <>u__1;
		}

		// Token: 0x0200001D RID: 29
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x0600008E RID: 142 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x040000D0 RID: 208
			public Nametags <>4__this;

			// Token: 0x040000D1 RID: 209
			public float writeval;
		}

		// Token: 0x0200001E RID: 30
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_1
		{
			// Token: 0x0600008F RID: 143 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass6_1()
			{
			}

			// Token: 0x06000090 RID: 144 RVA: 0x0016604C File Offset: 0x0016124C
			internal bool <write>b__0()
			{
				return this.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aTag.ToString("X"), "float", this.CS$<>8__locals1.writeval.ToString(), "", null);
			}

			// Token: 0x06000091 RID: 145 RVA: 0x0016609C File Offset: 0x0016129C
			internal bool <write>b__1()
			{
				return this.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aTag.ToString("X"), "float", "0.02666666918", "", null);
			}

			// Token: 0x040000D2 RID: 210
			public long aTag;

			// Token: 0x040000D3 RID: 211
			public Nametags.<>c__DisplayClass6_0 CS$<>8__locals1;
		}

		// Token: 0x0200001F RID: 31
		[CompilerGenerated]
		private sealed class <write>d__6 : IAsyncStateMachine
		{
			// Token: 0x06000092 RID: 146 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <write>d__6()
			{
			}

			// Token: 0x06000093 RID: 147 RVA: 0x001660E0 File Offset: 0x001612E0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 1)
					{
						this.<>8__1 = new Nametags.<>c__DisplayClass6_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.writeval = this.writeval;
						this.<tagsList>5__2 = new List<long>();
						this.<>s__3 = this.<>4__this.lTags.ToList<long>().GetEnumerator();
						try
						{
							while (this.<>s__3.MoveNext())
							{
								this.<addr>5__4 = this.<>s__3.Current;
								if (!this.<tagsList>5__2.Contains(this.<addr>5__4))
								{
									this.<tagsList>5__2.Add(this.<addr>5__4);
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>s__3).Dispose();
							}
						}
						this.<>s__3 = default(List<long>.Enumerator);
						if (!this.<>4__this.M.OpenProcess("javaw"))
						{
							goto IL_5C6;
						}
						this.<>s__5 = this.<tagsList>5__2.ToList<long>().GetEnumerator();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						TaskAwaiter<bool> awaiter2;
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_591;
							}
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							goto IL_580;
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							int num3 = -5;
							num = -5;
							this.<>1__state = num3;
						}
						IL_48F:
						awaiter2.GetResult();
						if (!this.<>4__this.lastWrittedValues.Contains(this.<>4__this.M.ReadFloat(this.<>8__6.aTag.ToString("X"), "", true).ToString("F")))
						{
							this.<>4__this.lastWrittedValues.Add(this.<>4__this.M.ReadFloat(this.<>8__6.aTag.ToString("X"), "", true).ToString("F"));
						}
						goto IL_588;
						IL_580:
						awaiter.GetResult();
						IL_588:
						IL_589:
						IL_58A:
						this.<>8__6 = null;
						IL_591:
						if (this.<>s__5.MoveNext())
						{
							this.<>8__6 = new Nametags.<>c__DisplayClass6_1();
							this.<>8__6.CS$<>8__locals1 = this.<>8__1;
							this.<>8__6.aTag = this.<>s__5.Current;
							if (!(this.<>4__this.M.ReadFloat((this.<>8__6.aTag + 24L).ToString("X"), "", true).ToString("F") == "2.50") && !(this.<>4__this.M.ReadFloat((this.<>8__6.aTag + 24L).ToString("X"), "", true).ToString("F") == "3.35") && !(this.<>4__this.M.ReadFloat((this.<>8__6.aTag + 8L).ToString("X"), "", true).ToString("F") == "2.50") && !(this.<>4__this.M.ReadFloat((this.<>8__6.aTag + 8L).ToString("X"), "", true).ToString("F") == "3.35") && !(this.<>4__this.M.ReadFloat((this.<>8__6.aTag + 16L).ToString("X"), "", true).ToString("F") == "2.50") && !(this.<>4__this.M.ReadFloat((this.<>8__6.aTag + 16L).ToString("X"), "", true).ToString("F") == "3.35"))
							{
								goto IL_58A;
							}
							if (!(this.<>4__this.M.ReadFloat(this.<>8__6.aTag.ToString("X"), "", true).ToString("F") == "0.03") && !this.<>4__this.lastWrittedValues.Contains(this.<>4__this.M.ReadFloat(this.<>8__6.aTag.ToString("X"), "", true).ToString("F")))
							{
								goto IL_589;
							}
							if (this.enabled && !this.isDestructing)
							{
								awaiter2 = Task.Run<bool>(new Func<bool>(this.<>8__6.<write>b__0)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num4 = 0;
									num = 0;
									this.<>1__state = num4;
									this.<>u__1 = awaiter2;
									Nametags.<write>d__6 <write>d__ = this;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Nametags.<write>d__6>(ref awaiter2, ref <write>d__);
									return;
								}
								goto IL_48F;
							}
							else
							{
								awaiter = Task.Run<bool>(new Func<bool>(this.<>8__6.<write>b__1)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 1;
									num = 1;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									Nametags.<write>d__6 <write>d__ = this;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Nametags.<write>d__6>(ref awaiter, ref <write>d__);
									return;
								}
								goto IL_580;
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>s__5).Dispose();
						}
					}
					this.<>s__5 = default(List<long>.Enumerator);
					IL_5C6:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<tagsList>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<tagsList>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000094 RID: 148 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000D4 RID: 212
			public int <>1__state;

			// Token: 0x040000D5 RID: 213
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040000D6 RID: 214
			public bool enabled;

			// Token: 0x040000D7 RID: 215
			public float writeval;

			// Token: 0x040000D8 RID: 216
			public bool isDestructing;

			// Token: 0x040000D9 RID: 217
			public Nametags <>4__this;

			// Token: 0x040000DA RID: 218
			private Nametags.<>c__DisplayClass6_0 <>8__1;

			// Token: 0x040000DB RID: 219
			private List<long> <tagsList>5__2;

			// Token: 0x040000DC RID: 220
			private List<long>.Enumerator <>s__3;

			// Token: 0x040000DD RID: 221
			private long <addr>5__4;

			// Token: 0x040000DE RID: 222
			private List<long>.Enumerator <>s__5;

			// Token: 0x040000DF RID: 223
			private Nametags.<>c__DisplayClass6_1 <>8__6;

			// Token: 0x040000E0 RID: 224
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000020 RID: 32
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06000095 RID: 149 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06000096 RID: 150 RVA: 0x0016674C File Offset: 0x0016194C
			internal bool <writeesp>b__0()
			{
				return this.<>4__this.M.WriteMemory(this.address.ToString("X"), "float", "3.35", "", null);
			}

			// Token: 0x06000097 RID: 151 RVA: 0x0016678C File Offset: 0x0016198C
			internal bool <writeesp>b__1()
			{
				return this.<>4__this.M.WriteMemory(this.address.ToString("X"), "float", "2.5", "", null);
			}

			// Token: 0x06000098 RID: 152 RVA: 0x0015E11F File Offset: 0x0015931F
			internal bool <writeesp>b__2()
			{
				return this.<>4__this.M.WriteMemory(this.address2.ToString("X"), "float", "3.35", "", null);
			}

			// Token: 0x06000099 RID: 153 RVA: 0x0015E151 File Offset: 0x00159351
			internal bool <writeesp>b__3()
			{
				return this.<>4__this.M.WriteMemory(this.address2.ToString("X"), "float", "2.5", "", null);
			}

			// Token: 0x0600009A RID: 154 RVA: 0x0015E183 File Offset: 0x00159383
			internal bool <writeesp>b__4()
			{
				return this.<>4__this.M.WriteMemory(this.address3.ToString("X"), "float", "3.35", "", null);
			}

			// Token: 0x0600009B RID: 155 RVA: 0x0015E1B5 File Offset: 0x001593B5
			internal bool <writeesp>b__5()
			{
				return this.<>4__this.M.WriteMemory(this.address3.ToString("X"), "float", "2.5", "", null);
			}

			// Token: 0x040000E1 RID: 225
			public long address;

			// Token: 0x040000E2 RID: 226
			public long address2;

			// Token: 0x040000E3 RID: 227
			public long address3;

			// Token: 0x040000E4 RID: 228
			public Nametags <>4__this;
		}

		// Token: 0x02000021 RID: 33
		[CompilerGenerated]
		private sealed class <writeesp>d__7 : IAsyncStateMachine
		{
			// Token: 0x0600009C RID: 156 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <writeesp>d__7()
			{
			}

			// Token: 0x0600009D RID: 157 RVA: 0x001667CC File Offset: 0x001619CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 5)
					{
						this.<tagsList>5__1 = new List<long>();
						this.<>s__2 = this.<>4__this.lTags.ToList<long>().GetEnumerator();
						try
						{
							while (this.<>s__2.MoveNext())
							{
								this.<addr>5__3 = this.<>s__2.Current;
								if (!this.<tagsList>5__1.Contains(this.<addr>5__3))
								{
									this.<tagsList>5__1.Add(this.<addr>5__3);
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>s__2).Dispose();
							}
						}
						this.<>s__2 = default(List<long>.Enumerator);
						if (!this.<>4__this.M.OpenProcess("javaw"))
						{
							goto IL_673;
						}
						this.<>s__4 = this.<tagsList>5__1.ToList<long>().GetEnumerator();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						TaskAwaiter<bool> awaiter2;
						TaskAwaiter<bool> awaiter3;
						TaskAwaiter<bool> awaiter4;
						TaskAwaiter<bool> awaiter5;
						TaskAwaiter<bool> awaiter6;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<bool>);
								int num2 = -481149102;
								num = -481149102;
								this.<>1__state = num2;
								goto IL_329;
							}
							case 1:
								continue;
							case 2:
							{
								awaiter2 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<bool>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_481;
							}
							case 3:
							{
								awaiter3 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<bool>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_4D8;
							}
							case 4:
							{
								awaiter4 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<bool>);
								int num5 = -67457025;
								num = -67457025;
								this.<>1__state = num5;
								break;
							}
							case 5:
							{
								awaiter5 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<bool>);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								goto IL_630;
							}
							default:
								goto IL_63F;
							}
							IL_5D9:
							awaiter4.GetResult();
							continue;
							IL_63F:
							if (!this.<>s__4.MoveNext())
							{
								goto Block_30;
							}
							this.<aTag>5__5 = this.<>s__4.Current;
							this.<>8__6 = new Nametags.<>c__DisplayClass7_0();
							this.<>8__6.<>4__this = this.<>4__this;
							this.<>8__6.address = this.<aTag>5__5 + 24L;
							this.<>8__6.address2 = this.<aTag>5__5 + 8L;
							this.<>8__6.address3 = this.<aTag>5__5 + 16L;
							if (this.<>4__this.M.ReadFloat(this.<>8__6.address.ToString("X"), "", true).ToString("F") == "2.50" || this.<>4__this.M.ReadFloat(this.<>8__6.address.ToString("X"), "", true).ToString("F") == "3.35")
							{
								if (this.enabled && !this.isDestructing)
								{
									awaiter = Task.Run<bool>(new Func<bool>(this.<>8__6.<writeesp>b__0)).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										break;
									}
									goto IL_329;
								}
								else
								{
									awaiter6 = Task.Run<bool>(new Func<bool>(this.<>8__6.<writeesp>b__1)).GetAwaiter();
									if (!awaiter6.IsCompleted)
									{
										goto Block_17;
									}
									awaiter6.GetResult();
								}
							}
							else if (this.<>4__this.M.ReadFloat(this.<>8__6.address2.ToString("X"), "", true).ToString("F") == "2.50" || this.<>4__this.M.ReadFloat(this.<>8__6.address2.ToString("X"), "", true).ToString("F") == "3.35")
							{
								if (this.enabled && !this.isDestructing)
								{
									awaiter2 = Task.Run<bool>(new Func<bool>(this.<>8__6.<writeesp>b__2)).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										goto Block_22;
									}
									goto IL_481;
								}
								else
								{
									awaiter3 = Task.Run<bool>(new Func<bool>(this.<>8__6.<writeesp>b__3)).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										goto Block_23;
									}
									goto IL_4D8;
								}
							}
							else if (this.<>4__this.M.ReadFloat(this.<>8__6.address3.ToString("X"), "", true).ToString("F") == "2.50" || this.<>4__this.M.ReadFloat(this.<>8__6.address3.ToString("X"), "", true).ToString("F") == "3.35")
							{
								if (this.enabled && !this.isDestructing)
								{
									awaiter4 = Task.Run<bool>(new Func<bool>(this.<>8__6.<writeesp>b__4)).GetAwaiter();
									if (!awaiter4.IsCompleted)
									{
										goto Block_28;
									}
									goto IL_5D9;
								}
								else
								{
									awaiter5 = Task.Run<bool>(new Func<bool>(this.<>8__6.<writeesp>b__5)).GetAwaiter();
									if (!awaiter5.IsCompleted)
									{
										goto Block_29;
									}
									goto IL_630;
								}
							}
							IL_638:
							this.<>8__6 = null;
							goto IL_63F;
							IL_630:
							awaiter5.GetResult();
							IL_4E0:
							goto IL_638;
							IL_4D8:
							awaiter3.GetResult();
							goto IL_4E0;
							IL_481:
							awaiter2.GetResult();
							IL_388:
							goto IL_638;
							IL_329:
							awaiter.GetResult();
							goto IL_388;
						}
						int num7 = 0;
						num = 0;
						this.<>1__state = num7;
						this.<>u__1 = awaiter;
						Nametags.<writeesp>d__7 <writeesp>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Nametags.<writeesp>d__7>(ref awaiter, ref <writeesp>d__);
						return;
						Block_17:
						int num8 = 1;
						num = 1;
						this.<>1__state = num8;
						this.<>u__1 = awaiter6;
						<writeesp>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Nametags.<writeesp>d__7>(ref awaiter6, ref <writeesp>d__);
						return;
						Block_22:
						int num9 = 2;
						num = 2;
						this.<>1__state = num9;
						this.<>u__1 = awaiter2;
						<writeesp>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Nametags.<writeesp>d__7>(ref awaiter2, ref <writeesp>d__);
						return;
						Block_23:
						int num10 = 3;
						num = 3;
						this.<>1__state = num10;
						this.<>u__1 = awaiter3;
						<writeesp>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Nametags.<writeesp>d__7>(ref awaiter3, ref <writeesp>d__);
						return;
						Block_28:
						int num11 = 4;
						num = 4;
						this.<>1__state = num11;
						this.<>u__1 = awaiter4;
						<writeesp>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Nametags.<writeesp>d__7>(ref awaiter4, ref <writeesp>d__);
						return;
						Block_29:
						int num12 = 5;
						num = 5;
						this.<>1__state = num12;
						this.<>u__1 = awaiter5;
						<writeesp>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Nametags.<writeesp>d__7>(ref awaiter5, ref <writeesp>d__);
						return;
						Block_30:;
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>s__4).Dispose();
						}
					}
					this.<>s__4 = default(List<long>.Enumerator);
					IL_673:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<tagsList>5__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<tagsList>5__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600009E RID: 158 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000E5 RID: 229
			public int <>1__state;

			// Token: 0x040000E6 RID: 230
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040000E7 RID: 231
			public bool enabled;

			// Token: 0x040000E8 RID: 232
			public bool isDestructing;

			// Token: 0x040000E9 RID: 233
			public Nametags <>4__this;

			// Token: 0x040000EA RID: 234
			private List<long> <tagsList>5__1;

			// Token: 0x040000EB RID: 235
			private List<long>.Enumerator <>s__2;

			// Token: 0x040000EC RID: 236
			private long <addr>5__3;

			// Token: 0x040000ED RID: 237
			private List<long>.Enumerator <>s__4;

			// Token: 0x040000EE RID: 238
			private long <aTag>5__5;

			// Token: 0x040000EF RID: 239
			private Nametags.<>c__DisplayClass7_0 <>8__6;

			// Token: 0x040000F0 RID: 240
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
