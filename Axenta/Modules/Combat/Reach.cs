using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Memory;

namespace Axenta.Modules.Combat
{
	// Token: 0x02000022 RID: 34
	internal class Reach
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00166ED4 File Offset: 0x001620D4
		
		public void scan(bool destructing)
		{
			Reach.<scan>d__15 <scan>d__ = new Reach.<scan>d__15();
			<scan>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<scan>d__.<>4__this = this;
			<scan>d__.destructing = destructing;
			<scan>d__.<>1__state = -1;
			<scan>d__.<>t__builder.Start<Reach.<scan>d__15>(ref <scan>d__);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00166F14 File Offset: 0x00162114
		
		public void write(bool enabled, float writeval, bool isDestructing)
		{
			Reach.<write>d__16 <write>d__ = new Reach.<write>d__16();
			<write>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<write>d__.<>4__this = this;
			<write>d__.enabled = enabled;
			<write>d__.writeval = writeval;
			<write>d__.isDestructing = isDestructing;
			<write>d__.<>1__state = -1;
			<write>d__.<>t__builder.Start<Reach.<write>d__16>(ref <write>d__);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00166F64 File Offset: 0x00162164
		public Reach()
		{
		}

		// Token: 0x040000F1 RID: 241
		public Mem M = new Mem();

		// Token: 0x040000F2 RID: 242
		private string arrayReach = "00 00 40 40";

		// Token: 0x040000F3 RID: 243
		private string arrayReachBuffer = "00 00 00 00 00 00 12 40";

		// Token: 0x040000F4 RID: 244
		private string arrayReachDouble = "00 00 00 00 00 00 08 40";

		// Token: 0x040000F5 RID: 245
		private bool isScanning = false;

		// Token: 0x040000F6 RID: 246
		private IEnumerable<long> aReach;

		// Token: 0x040000F7 RID: 247
		private IEnumerable<long> aReachDouble;

		// Token: 0x040000F8 RID: 248
		private IEnumerable<long> aReachBuffer;

		// Token: 0x040000F9 RID: 249
		private List<long> lReach = new List<long>();

		// Token: 0x040000FA RID: 250
		private List<long> lReachDouble = new List<long>();

		// Token: 0x040000FB RID: 251
		private List<long> lReachBuffer = new List<long>();

		// Token: 0x040000FC RID: 252
		private float reachVal;

		// Token: 0x040000FD RID: 253
		private double reachBufferVal;

		// Token: 0x040000FE RID: 254
		private double reachDoubleVal;

		// Token: 0x040000FF RID: 255
		private List<string> lastWrittedValues = new List<string>();

		// Token: 0x02000023 RID: 35
		[CompilerGenerated]
		private sealed class <scan>d__15 : IAsyncStateMachine
		{
			// Token: 0x060000A2 RID: 162 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <scan>d__15()
			{
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00166FD8 File Offset: 0x001621D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<IEnumerable<long>> awaiter;
					TaskAwaiter<IEnumerable<long>> awaiter2;
					TaskAwaiter<IEnumerable<long>> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<long>>);
						num = (this.<>1__state = -1);
						break;
					case 1:
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<long>>);
						num = (this.<>1__state = -1);
						goto IL_17A;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<long>>);
						num = (this.<>1__state = -1);
						goto IL_222;
					default:
					{
						bool flag = !this.destructing;
						if (!flag)
						{
							goto IL_401;
						}
						this.<>4__this.M.OpenProcess("javaw");
						awaiter = this.<>4__this.M.AoBScan(33554432L, 90000000L, this.<>4__this.arrayReach, false, true, "").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (this.<>1__state = 0);
							this.<>u__1 = awaiter;
							Reach.<scan>d__15 <scan>d__ = this;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<long>>, Reach.<scan>d__15>(ref awaiter, ref <scan>d__);
							return;
						}
						break;
					}
					}
					this.<>s__1 = awaiter.GetResult();
					this.<>4__this.aReach = this.<>s__1;
					this.<>s__1 = null;
					awaiter2 = this.<>4__this.M.AoBScan(33554432L, 90000000L, this.<>4__this.arrayReachDouble, false, true, "").GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (this.<>1__state = 1);
						this.<>u__1 = awaiter2;
						Reach.<scan>d__15 <scan>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<long>>, Reach.<scan>d__15>(ref awaiter2, ref <scan>d__);
						return;
					}
					IL_17A:
					this.<>s__2 = awaiter2.GetResult();
					this.<>4__this.aReachDouble = this.<>s__2;
					this.<>s__2 = null;
					awaiter3 = this.<>4__this.M.AoBScan(33554432L, 90000000L, this.<>4__this.arrayReachBuffer, false, true, "").GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (this.<>1__state = 2);
						this.<>u__1 = awaiter3;
						Reach.<scan>d__15 <scan>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<long>>, Reach.<scan>d__15>(ref awaiter3, ref <scan>d__);
						return;
					}
					IL_222:
					this.<>s__3 = awaiter3.GetResult();
					this.<>4__this.aReachBuffer = this.<>s__3;
					this.<>s__3 = null;
					this.<>s__4 = this.<>4__this.aReach.GetEnumerator();
					try
					{
						while (this.<>s__4.MoveNext())
						{
							this.<addr>5__5 = this.<>s__4.Current;
							bool flag2 = !this.<>4__this.lReach.Contains(this.<addr>5__5);
							if (flag2)
							{
								this.<>4__this.lReach.Add(this.<addr>5__5);
							}
						}
					}
					finally
					{
						if (num < 0 && this.<>s__4 != null)
						{
							this.<>s__4.Dispose();
						}
					}
					this.<>s__4 = null;
					this.<>s__6 = this.<>4__this.aReachDouble.GetEnumerator();
					try
					{
						while (this.<>s__6.MoveNext())
						{
							this.<addr>5__7 = this.<>s__6.Current;
							bool flag3 = !this.<>4__this.lReachDouble.Contains(this.<addr>5__7);
							if (flag3)
							{
								this.<>4__this.lReachDouble.Add(this.<addr>5__7);
							}
						}
					}
					finally
					{
						if (num < 0 && this.<>s__6 != null)
						{
							this.<>s__6.Dispose();
						}
					}
					this.<>s__6 = null;
					this.<>s__8 = this.<>4__this.aReachBuffer.GetEnumerator();
					try
					{
						while (this.<>s__8.MoveNext())
						{
							this.<addr>5__9 = this.<>s__8.Current;
							bool flag4 = !this.<>4__this.lReachBuffer.Contains(this.<addr>5__9);
							if (flag4)
							{
								this.<>4__this.lReachBuffer.Add(this.<addr>5__9);
							}
						}
					}
					finally
					{
						if (num < 0 && this.<>s__8 != null)
						{
							this.<>s__8.Dispose();
						}
					}
					this.<>s__8 = null;
					IL_401:;
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

			// Token: 0x060000A4 RID: 164 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000100 RID: 256
			public int <>1__state;

			// Token: 0x04000101 RID: 257
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000102 RID: 258
			public bool destructing;

			// Token: 0x04000103 RID: 259
			public Reach <>4__this;

			// Token: 0x04000104 RID: 260
			private IEnumerable<long> <>s__1;

			// Token: 0x04000105 RID: 261
			private IEnumerable<long> <>s__2;

			// Token: 0x04000106 RID: 262
			private IEnumerable<long> <>s__3;

			// Token: 0x04000107 RID: 263
			private IEnumerator<long> <>s__4;

			// Token: 0x04000108 RID: 264
			private long <addr>5__5;

			// Token: 0x04000109 RID: 265
			private IEnumerator<long> <>s__6;

			// Token: 0x0400010A RID: 266
			private long <addr>5__7;

			// Token: 0x0400010B RID: 267
			private IEnumerator<long> <>s__8;

			// Token: 0x0400010C RID: 268
			private long <addr>5__9;

			// Token: 0x0400010D RID: 269
			private TaskAwaiter<IEnumerable<long>> <>u__1;
		}

		// Token: 0x02000024 RID: 36
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x060000A5 RID: 165 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x0400010E RID: 270
			public Reach <>4__this;

			// Token: 0x0400010F RID: 271
			public float writeval;
		}

		// Token: 0x02000025 RID: 37
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_1
		{
			// Token: 0x060000A6 RID: 166 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass16_1()
			{
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x0015E1E7 File Offset: 0x001593E7
			internal bool <write>b__1()
			{
				return this.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aBuffer.ToString("X"), "double", "7.5", "", null);
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x0015E21E File Offset: 0x0015941E
			internal bool <write>b__3()
			{
				return this.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aBuffer.ToString("X"), "double", "4.5", "", null);
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x0015E1E7 File Offset: 0x001593E7
			internal bool <write>b__5()
			{
				return this.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aBuffer.ToString("X"), "double", "7.5", "", null);
			}

			// Token: 0x060000AA RID: 170 RVA: 0x0015E21E File Offset: 0x0015941E
			internal bool <write>b__7()
			{
				return this.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aBuffer.ToString("X"), "double", "4.5", "", null);
			}

			// Token: 0x04000110 RID: 272
			public long aBuffer;

			// Token: 0x04000111 RID: 273
			public Reach.<>c__DisplayClass16_0 CS$<>8__locals1;

			// Token: 0x04000112 RID: 274
			public Func<bool> <>9__1;

			// Token: 0x04000113 RID: 275
			public Func<bool> <>9__3;

			// Token: 0x04000114 RID: 276
			public Func<bool> <>9__5;

			// Token: 0x04000115 RID: 277
			public Func<bool> <>9__7;
		}

		// Token: 0x02000026 RID: 38
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_2
		{
			// Token: 0x060000AB RID: 171 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass16_2()
			{
			}

			// Token: 0x060000AC RID: 172 RVA: 0x0016747C File Offset: 0x0016267C
			internal bool <write>b__0()
			{
				return this.CS$<>8__locals2.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aReach.ToString("X"), "float", this.CS$<>8__locals2.CS$<>8__locals1.writeval.ToString("F"), "", null);
			}

			// Token: 0x060000AD RID: 173 RVA: 0x0015E255 File Offset: 0x00159455
			internal bool <write>b__2()
			{
				return this.CS$<>8__locals2.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aReach.ToString("X"), "float", "3.00", "", null);
			}

			// Token: 0x04000116 RID: 278
			public long aReach;

			// Token: 0x04000117 RID: 279
			public Reach.<>c__DisplayClass16_1 CS$<>8__locals2;
		}

		// Token: 0x02000027 RID: 39
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_3
		{
			// Token: 0x060000AE RID: 174 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass16_3()
			{
			}

			// Token: 0x060000AF RID: 175 RVA: 0x001674D8 File Offset: 0x001626D8
			internal bool <write>b__4()
			{
				return this.CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aReachDouble.ToString("X"), "double", this.CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.writeval.ToString("F"), "", null);
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x00167540 File Offset: 0x00162740
			internal bool <write>b__6()
			{
				return this.CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aReachDouble.ToString("X"), "double", "3.00", "", null);
			}

			// Token: 0x04000118 RID: 280
			public long aReachDouble;

			// Token: 0x04000119 RID: 281
			public Reach.<>c__DisplayClass16_2 CS$<>8__locals3;
		}

		// Token: 0x02000028 RID: 40
		[CompilerGenerated]
		private sealed class <write>d__16 : IAsyncStateMachine
		{
			// Token: 0x060000B1 RID: 177 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <write>d__16()
			{
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x0016758C File Offset: 0x0016278C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 7)
					{
						this.<>8__1 = new Reach.<>c__DisplayClass16_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.writeval = this.writeval;
						this.<reachBufferList>5__2 = new List<long>();
						this.<reachList>5__3 = new List<long>();
						this.<reachDoubleList>5__4 = new List<long>();
						this.<>s__5 = this.<>4__this.lReach.ToList<long>().GetEnumerator();
						try
						{
							while (this.<>s__5.MoveNext())
							{
								this.<addr>5__6 = this.<>s__5.Current;
								bool flag = !this.<reachList>5__3.Contains(this.<addr>5__6);
								if (flag)
								{
									this.<reachList>5__3.Add(this.<addr>5__6);
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
						this.<>s__7 = this.<>4__this.lReachDouble.ToList<long>().GetEnumerator();
						try
						{
							while (this.<>s__7.MoveNext())
							{
								this.<addr>5__8 = this.<>s__7.Current;
								bool flag2 = !this.<reachDoubleList>5__4.Contains(this.<addr>5__8);
								if (flag2)
								{
									this.<reachDoubleList>5__4.Add(this.<addr>5__8);
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>s__7).Dispose();
							}
						}
						this.<>s__7 = default(List<long>.Enumerator);
						this.<>s__9 = this.<>4__this.lReachBuffer.ToList<long>().GetEnumerator();
						try
						{
							while (this.<>s__9.MoveNext())
							{
								this.<addr>5__10 = this.<>s__9.Current;
								bool flag3 = !this.<reachBufferList>5__2.Contains(this.<addr>5__10);
								if (flag3)
								{
									this.<reachBufferList>5__2.Add(this.<addr>5__10);
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>s__9).Dispose();
							}
						}
						this.<>s__9 = default(List<long>.Enumerator);
						bool flag4 = this.<>4__this.M.OpenProcess("javaw");
						if (!flag4)
						{
							goto IL_DDB;
						}
						this.<>s__11 = this.<reachBufferList>5__2.ToList<long>().GetEnumerator();
					}
					try
					{
						if (num > 7)
						{
							goto IL_DA5;
						}
						IL_29C:
						try
						{
							TaskAwaiter<bool> awaiter;
							TaskAwaiter<bool> awaiter2;
							TaskAwaiter<bool> awaiter3;
							TaskAwaiter<bool> awaiter4;
							switch (num)
							{
							case 0:
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<bool>);
								num = (this.<>1__state = -1);
								break;
							case 1:
								awaiter2 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<bool>);
								num = (this.<>1__state = -1);
								goto IL_5E9;
							case 2:
								awaiter3 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<bool>);
								num = (this.<>1__state = -1);
								goto IL_6CE;
							case 3:
								awaiter4 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<bool>);
								num = (this.<>1__state = -1);
								goto IL_770;
							case 4:
							case 5:
							case 6:
							case 7:
								goto IL_7D9;
							default:
								goto IL_D68;
							}
							IL_547:
							awaiter.GetResult();
							Func<bool> function;
							if ((function = this.<>8__14.CS$<>8__locals2.<>9__1) == null)
							{
								function = (this.<>8__14.CS$<>8__locals2.<>9__1 = new Func<bool>(this.<>8__14.CS$<>8__locals2.<write>b__1));
							}
							awaiter2 = Task.Run<bool>(function).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (this.<>1__state = 1);
								this.<>u__1 = awaiter2;
								Reach.<write>d__16 <write>d__ = this;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Reach.<write>d__16>(ref awaiter2, ref <write>d__);
								return;
							}
							IL_5E9:
							awaiter2.GetResult();
							bool flag5 = !this.<>4__this.lastWrittedValues.Contains(this.<>8__14.CS$<>8__locals2.CS$<>8__locals1.writeval.ToString("F"));
							if (flag5)
							{
								this.<>4__this.lastWrittedValues.Add(this.<>8__14.CS$<>8__locals2.CS$<>8__locals1.writeval.ToString("F"));
							}
							goto IL_779;
							IL_6CE:
							awaiter3.GetResult();
							Func<bool> function2;
							if ((function2 = this.<>8__14.CS$<>8__locals2.<>9__3) == null)
							{
								function2 = (this.<>8__14.CS$<>8__locals2.<>9__3 = new Func<bool>(this.<>8__14.CS$<>8__locals2.<write>b__3));
							}
							awaiter4 = Task.Run<bool>(function2).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num = (this.<>1__state = 3);
								this.<>u__1 = awaiter4;
								Reach.<write>d__16 <write>d__ = this;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Reach.<write>d__16>(ref awaiter4, ref <write>d__);
								return;
							}
							IL_770:
							awaiter4.GetResult();
							IL_779:
							IL_79F:
							IL_7C0:
							IL_7C1:
							IL_7C2:
							this.<>s__15 = this.<reachDoubleList>5__4.ToList<long>().GetEnumerator();
							IL_7D9:
							try
							{
								TaskAwaiter<bool> awaiter5;
								TaskAwaiter<bool> awaiter6;
								TaskAwaiter<bool> awaiter7;
								TaskAwaiter<bool> awaiter8;
								switch (num)
								{
								case 4:
									awaiter5 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<bool>);
									num = (this.<>1__state = -1);
									break;
								case 5:
									awaiter6 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<bool>);
									num = (this.<>1__state = -1);
									goto IL_B2C;
								case 6:
									awaiter7 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<bool>);
									num = (this.<>1__state = -1);
									goto IL_C1B;
								case 7:
									awaiter8 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<bool>);
									num = (this.<>1__state = -1);
									goto IL_CCC;
								default:
									goto IL_D2B;
								}
								IL_A7B:
								awaiter5.GetResult();
								Func<bool> function3;
								if ((function3 = this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.<>9__5) == null)
								{
									function3 = (this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.<>9__5 = new Func<bool>(this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.<write>b__5));
								}
								awaiter6 = Task.Run<bool>(function3).GetAwaiter();
								if (!awaiter6.IsCompleted)
								{
									num = (this.<>1__state = 5);
									this.<>u__1 = awaiter6;
									Reach.<write>d__16 <write>d__ = this;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Reach.<write>d__16>(ref awaiter6, ref <write>d__);
									return;
								}
								IL_B2C:
								awaiter6.GetResult();
								bool flag6 = !this.<>4__this.lastWrittedValues.Contains(this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.writeval.ToString("F"));
								if (flag6)
								{
									this.<>4__this.lastWrittedValues.Add(this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.writeval.ToString("F"));
								}
								goto IL_CD5;
								IL_C1B:
								awaiter7.GetResult();
								Func<bool> function4;
								if ((function4 = this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.<>9__7) == null)
								{
									function4 = (this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.<>9__7 = new Func<bool>(this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.<write>b__7));
								}
								awaiter8 = Task.Run<bool>(function4).GetAwaiter();
								if (!awaiter8.IsCompleted)
								{
									num = (this.<>1__state = 7);
									this.<>u__1 = awaiter8;
									Reach.<write>d__16 <write>d__ = this;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Reach.<write>d__16>(ref awaiter8, ref <write>d__);
									return;
								}
								IL_CCC:
								awaiter8.GetResult();
								IL_CD5:
								IL_D00:
								IL_D21:
								IL_D22:
								IL_D23:
								this.<>8__16 = null;
								IL_D2B:
								if (this.<>s__15.MoveNext())
								{
									this.<>8__16 = new Reach.<>c__DisplayClass16_3();
									this.<>8__16.CS$<>8__locals3 = this.<>8__14;
									this.<>8__16.aReachDouble = this.<>s__15.Current;
									bool flag7 = this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.aBuffer.ToString("X").Substring(0, 3) == this.<>8__16.aReachDouble.ToString("X").Substring(0, 3);
									if (!flag7)
									{
										goto IL_D23;
									}
									this.<>4__this.reachDoubleVal = this.<>4__this.M.ReadDouble(this.<>8__16.aReachDouble.ToString("X"), "", true);
									this.<>4__this.reachBufferVal = this.<>4__this.M.ReadDouble(this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.aBuffer.ToString("X"), "", true);
									bool flag8 = this.<>4__this.reachDoubleVal.ToString().Length < 5 && this.<>4__this.reachDoubleVal.ToString().Length > 0;
									if (!flag8)
									{
										goto IL_D22;
									}
									bool flag9 = this.<>4__this.reachDoubleVal.ToString("F") == "3.00" || this.<>4__this.reachDoubleVal.ToString("F") == "6.00" || this.<>4__this.lastWrittedValues.Contains(this.<>4__this.reachDoubleVal.ToString("F"));
									if (!flag9)
									{
										this.<>4__this.lReach.Remove(this.<>8__16.aReachDouble);
										goto IL_D21;
									}
									bool flag10 = this.<>4__this.reachBufferVal == 4.5 || this.<>4__this.reachBufferVal == 7.5;
									if (!flag10)
									{
										this.<>4__this.lReachBuffer.Remove(this.<>8__16.CS$<>8__locals3.CS$<>8__locals2.aBuffer);
										goto IL_D00;
									}
									bool flag11 = this.enabled && !this.isDestructing;
									if (flag11)
									{
										awaiter5 = Task.Run<bool>(new Func<bool>(this.<>8__16.<write>b__4)).GetAwaiter();
										if (!awaiter5.IsCompleted)
										{
											num = (this.<>1__state = 4);
											this.<>u__1 = awaiter5;
											Reach.<write>d__16 <write>d__ = this;
											this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Reach.<write>d__16>(ref awaiter5, ref <write>d__);
											return;
										}
										goto IL_A7B;
									}
									else
									{
										awaiter7 = Task.Run<bool>(new Func<bool>(this.<>8__16.<write>b__6)).GetAwaiter();
										if (!awaiter7.IsCompleted)
										{
											num = (this.<>1__state = 6);
											this.<>u__1 = awaiter7;
											Reach.<write>d__16 <write>d__ = this;
											this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Reach.<write>d__16>(ref awaiter7, ref <write>d__);
											return;
										}
										goto IL_C1B;
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)this.<>s__15).Dispose();
								}
							}
							this.<>s__15 = default(List<long>.Enumerator);
							this.<>8__14 = null;
							IL_D68:
							if (this.<>s__13.MoveNext())
							{
								this.<>8__14 = new Reach.<>c__DisplayClass16_2();
								this.<>8__14.CS$<>8__locals2 = this.<>8__12;
								this.<>8__14.aReach = this.<>s__13.Current;
								bool flag12 = this.<>8__14.CS$<>8__locals2.aBuffer.ToString("X").Substring(0, 3) == this.<>8__14.aReach.ToString("X").Substring(0, 3);
								if (!flag12)
								{
									goto IL_7C2;
								}
								this.<>4__this.reachVal = this.<>4__this.M.ReadFloat(this.<>8__14.aReach.ToString("X"), "", true);
								this.<>4__this.reachBufferVal = this.<>4__this.M.ReadDouble(this.<>8__14.CS$<>8__locals2.aBuffer.ToString("X"), "", true);
								bool flag13 = this.<>4__this.reachVal.ToString().Length < 5 && this.<>4__this.reachVal.ToString().Length > 0;
								if (!flag13)
								{
									goto IL_7C1;
								}
								bool flag14 = this.<>4__this.reachVal.ToString("F") == "3.00" || this.<>4__this.reachVal.ToString("F") == "6.00" || this.<>4__this.lastWrittedValues.Contains(this.<>4__this.reachVal.ToString("F"));
								if (!flag14)
								{
									this.<>4__this.lReach.Remove(this.<>8__14.aReach);
									goto IL_7C0;
								}
								bool flag15 = this.<>4__this.reachBufferVal == 4.5 || this.<>4__this.reachBufferVal == 7.5;
								if (!flag15)
								{
									this.<>4__this.lReachBuffer.Remove(this.<>8__14.CS$<>8__locals2.aBuffer);
									goto IL_79F;
								}
								bool flag16 = this.enabled && !this.isDestructing;
								if (flag16)
								{
									awaiter = Task.Run<bool>(new Func<bool>(this.<>8__14.<write>b__0)).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = (this.<>1__state = 0);
										this.<>u__1 = awaiter;
										Reach.<write>d__16 <write>d__ = this;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Reach.<write>d__16>(ref awaiter, ref <write>d__);
										return;
									}
									goto IL_547;
								}
								else
								{
									awaiter3 = Task.Run<bool>(new Func<bool>(this.<>8__14.<write>b__2)).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num = (this.<>1__state = 2);
										this.<>u__1 = awaiter3;
										Reach.<write>d__16 <write>d__ = this;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Reach.<write>d__16>(ref awaiter3, ref <write>d__);
										return;
									}
									goto IL_6CE;
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>s__13).Dispose();
							}
						}
						this.<>s__13 = default(List<long>.Enumerator);
						this.<>8__12 = null;
						IL_DA5:
						if (this.<>s__11.MoveNext())
						{
							this.<>8__12 = new Reach.<>c__DisplayClass16_1();
							this.<>8__12.CS$<>8__locals1 = this.<>8__1;
							this.<>8__12.aBuffer = this.<>s__11.Current;
							this.<>s__13 = this.<reachList>5__3.ToList<long>().GetEnumerator();
							goto IL_29C;
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>s__11).Dispose();
						}
					}
					this.<>s__11 = default(List<long>.Enumerator);
					IL_DDB:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<reachBufferList>5__2 = null;
					this.<reachList>5__3 = null;
					this.<reachDoubleList>5__4 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<reachBufferList>5__2 = null;
				this.<reachList>5__3 = null;
				this.<reachDoubleList>5__4 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400011A RID: 282
			public int <>1__state;

			// Token: 0x0400011B RID: 283
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400011C RID: 284
			public bool enabled;

			// Token: 0x0400011D RID: 285
			public float writeval;

			// Token: 0x0400011E RID: 286
			public bool isDestructing;

			// Token: 0x0400011F RID: 287
			public Reach <>4__this;

			// Token: 0x04000120 RID: 288
			private Reach.<>c__DisplayClass16_0 <>8__1;

			// Token: 0x04000121 RID: 289
			private List<long> <reachBufferList>5__2;

			// Token: 0x04000122 RID: 290
			private List<long> <reachList>5__3;

			// Token: 0x04000123 RID: 291
			private List<long> <reachDoubleList>5__4;

			// Token: 0x04000124 RID: 292
			private List<long>.Enumerator <>s__5;

			// Token: 0x04000125 RID: 293
			private long <addr>5__6;

			// Token: 0x04000126 RID: 294
			private List<long>.Enumerator <>s__7;

			// Token: 0x04000127 RID: 295
			private long <addr>5__8;

			// Token: 0x04000128 RID: 296
			private List<long>.Enumerator <>s__9;

			// Token: 0x04000129 RID: 297
			private long <addr>5__10;

			// Token: 0x0400012A RID: 298
			private List<long>.Enumerator <>s__11;

			// Token: 0x0400012B RID: 299
			private Reach.<>c__DisplayClass16_1 <>8__12;

			// Token: 0x0400012C RID: 300
			private List<long>.Enumerator <>s__13;

			// Token: 0x0400012D RID: 301
			private Reach.<>c__DisplayClass16_2 <>8__14;

			// Token: 0x0400012E RID: 302
			private List<long>.Enumerator <>s__15;

			// Token: 0x0400012F RID: 303
			private Reach.<>c__DisplayClass16_3 <>8__16;

			// Token: 0x04000130 RID: 304
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
