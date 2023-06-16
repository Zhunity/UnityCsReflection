
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Text.RegularExpressions.RegexCode
	/// </summary>
    public partial class RRegexCode : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Text.RegularExpressions.RegexCode");
            }
        }

        public RRegexCode() : base("System.Text.RegularExpressions.RegexCode")
        {
        }

        public RRegexCode(System.Object instance) : base("System.Text.RegularExpressions.RegexCode")
		{
            SetInstance(instance);
		}

        public RRegexCode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegexCode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 Onerep
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FOnerep;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFOnerep
		{
			get
			{
				if(r_FOnerep == null)
				{
					r_FOnerep = new(Type, "Onerep");
				}
				return r_FOnerep;
			}
		}

		/// <summary>
		/// System.Int32 Notonerep
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNotonerep;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNotonerep
		{
			get
			{
				if(r_FNotonerep == null)
				{
					r_FNotonerep = new(Type, "Notonerep");
				}
				return r_FNotonerep;
			}
		}

		/// <summary>
		/// System.Int32 Setrep
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSetrep;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSetrep
		{
			get
			{
				if(r_FSetrep == null)
				{
					r_FSetrep = new(Type, "Setrep");
				}
				return r_FSetrep;
			}
		}

		/// <summary>
		/// System.Int32 Oneloop
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FOneloop;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFOneloop
		{
			get
			{
				if(r_FOneloop == null)
				{
					r_FOneloop = new(Type, "Oneloop");
				}
				return r_FOneloop;
			}
		}

		/// <summary>
		/// System.Int32 Notoneloop
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNotoneloop;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNotoneloop
		{
			get
			{
				if(r_FNotoneloop == null)
				{
					r_FNotoneloop = new(Type, "Notoneloop");
				}
				return r_FNotoneloop;
			}
		}

		/// <summary>
		/// System.Int32 Setloop
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSetloop;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSetloop
		{
			get
			{
				if(r_FSetloop == null)
				{
					r_FSetloop = new(Type, "Setloop");
				}
				return r_FSetloop;
			}
		}

		/// <summary>
		/// System.Int32 Onelazy
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FOnelazy;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFOnelazy
		{
			get
			{
				if(r_FOnelazy == null)
				{
					r_FOnelazy = new(Type, "Onelazy");
				}
				return r_FOnelazy;
			}
		}

		/// <summary>
		/// System.Int32 Notonelazy
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNotonelazy;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNotonelazy
		{
			get
			{
				if(r_FNotonelazy == null)
				{
					r_FNotonelazy = new(Type, "Notonelazy");
				}
				return r_FNotonelazy;
			}
		}

		/// <summary>
		/// System.Int32 Setlazy
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSetlazy;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSetlazy
		{
			get
			{
				if(r_FSetlazy == null)
				{
					r_FSetlazy = new(Type, "Setlazy");
				}
				return r_FSetlazy;
			}
		}

		/// <summary>
		/// System.Int32 One
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FOne;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFOne
		{
			get
			{
				if(r_FOne == null)
				{
					r_FOne = new(Type, "One");
				}
				return r_FOne;
			}
		}

		/// <summary>
		/// System.Int32 Notone
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNotone;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNotone
		{
			get
			{
				if(r_FNotone == null)
				{
					r_FNotone = new(Type, "Notone");
				}
				return r_FNotone;
			}
		}

		/// <summary>
		/// System.Int32 Set
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSet;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSet
		{
			get
			{
				if(r_FSet == null)
				{
					r_FSet = new(Type, "Set");
				}
				return r_FSet;
			}
		}

		/// <summary>
		/// System.Int32 Multi
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMulti;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMulti
		{
			get
			{
				if(r_FMulti == null)
				{
					r_FMulti = new(Type, "Multi");
				}
				return r_FMulti;
			}
		}

		/// <summary>
		/// System.Int32 Ref
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FRef;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFRef
		{
			get
			{
				if(r_FRef == null)
				{
					r_FRef = new(Type, "Ref");
				}
				return r_FRef;
			}
		}

		/// <summary>
		/// System.Int32 Bol
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FBol;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFBol
		{
			get
			{
				if(r_FBol == null)
				{
					r_FBol = new(Type, "Bol");
				}
				return r_FBol;
			}
		}

		/// <summary>
		/// System.Int32 Eol
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FEol;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFEol
		{
			get
			{
				if(r_FEol == null)
				{
					r_FEol = new(Type, "Eol");
				}
				return r_FEol;
			}
		}

		/// <summary>
		/// System.Int32 Boundary
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FBoundary;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFBoundary
		{
			get
			{
				if(r_FBoundary == null)
				{
					r_FBoundary = new(Type, "Boundary");
				}
				return r_FBoundary;
			}
		}

		/// <summary>
		/// System.Int32 Nonboundary
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNonboundary;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNonboundary
		{
			get
			{
				if(r_FNonboundary == null)
				{
					r_FNonboundary = new(Type, "Nonboundary");
				}
				return r_FNonboundary;
			}
		}

		/// <summary>
		/// System.Int32 Beginning
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FBeginning;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFBeginning
		{
			get
			{
				if(r_FBeginning == null)
				{
					r_FBeginning = new(Type, "Beginning");
				}
				return r_FBeginning;
			}
		}

		/// <summary>
		/// System.Int32 Start
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FStart;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFStart
		{
			get
			{
				if(r_FStart == null)
				{
					r_FStart = new(Type, "Start");
				}
				return r_FStart;
			}
		}

		/// <summary>
		/// System.Int32 EndZ
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FEndZ;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFEndZ
		{
			get
			{
				if(r_FEndZ == null)
				{
					r_FEndZ = new(Type, "EndZ");
				}
				return r_FEndZ;
			}
		}

		/// <summary>
		/// System.Int32 End
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FEnd;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFEnd
		{
			get
			{
				if(r_FEnd == null)
				{
					r_FEnd = new(Type, "End");
				}
				return r_FEnd;
			}
		}

		/// <summary>
		/// System.Int32 Nothing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNothing;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNothing
		{
			get
			{
				if(r_FNothing == null)
				{
					r_FNothing = new(Type, "Nothing");
				}
				return r_FNothing;
			}
		}

		/// <summary>
		/// System.Int32 Lazybranch
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FLazybranch;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFLazybranch
		{
			get
			{
				if(r_FLazybranch == null)
				{
					r_FLazybranch = new(Type, "Lazybranch");
				}
				return r_FLazybranch;
			}
		}

		/// <summary>
		/// System.Int32 Branchmark
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FBranchmark;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFBranchmark
		{
			get
			{
				if(r_FBranchmark == null)
				{
					r_FBranchmark = new(Type, "Branchmark");
				}
				return r_FBranchmark;
			}
		}

		/// <summary>
		/// System.Int32 Lazybranchmark
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FLazybranchmark;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFLazybranchmark
		{
			get
			{
				if(r_FLazybranchmark == null)
				{
					r_FLazybranchmark = new(Type, "Lazybranchmark");
				}
				return r_FLazybranchmark;
			}
		}

		/// <summary>
		/// System.Int32 Nullcount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNullcount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNullcount
		{
			get
			{
				if(r_FNullcount == null)
				{
					r_FNullcount = new(Type, "Nullcount");
				}
				return r_FNullcount;
			}
		}

		/// <summary>
		/// System.Int32 Setcount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSetcount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSetcount
		{
			get
			{
				if(r_FSetcount == null)
				{
					r_FSetcount = new(Type, "Setcount");
				}
				return r_FSetcount;
			}
		}

		/// <summary>
		/// System.Int32 Branchcount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FBranchcount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFBranchcount
		{
			get
			{
				if(r_FBranchcount == null)
				{
					r_FBranchcount = new(Type, "Branchcount");
				}
				return r_FBranchcount;
			}
		}

		/// <summary>
		/// System.Int32 Lazybranchcount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FLazybranchcount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFLazybranchcount
		{
			get
			{
				if(r_FLazybranchcount == null)
				{
					r_FLazybranchcount = new(Type, "Lazybranchcount");
				}
				return r_FLazybranchcount;
			}
		}

		/// <summary>
		/// System.Int32 Nullmark
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNullmark;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNullmark
		{
			get
			{
				if(r_FNullmark == null)
				{
					r_FNullmark = new(Type, "Nullmark");
				}
				return r_FNullmark;
			}
		}

		/// <summary>
		/// System.Int32 Setmark
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSetmark;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSetmark
		{
			get
			{
				if(r_FSetmark == null)
				{
					r_FSetmark = new(Type, "Setmark");
				}
				return r_FSetmark;
			}
		}

		/// <summary>
		/// System.Int32 Capturemark
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCapturemark;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCapturemark
		{
			get
			{
				if(r_FCapturemark == null)
				{
					r_FCapturemark = new(Type, "Capturemark");
				}
				return r_FCapturemark;
			}
		}

		/// <summary>
		/// System.Int32 Getmark
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FGetmark;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFGetmark
		{
			get
			{
				if(r_FGetmark == null)
				{
					r_FGetmark = new(Type, "Getmark");
				}
				return r_FGetmark;
			}
		}

		/// <summary>
		/// System.Int32 Setjump
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSetjump;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSetjump
		{
			get
			{
				if(r_FSetjump == null)
				{
					r_FSetjump = new(Type, "Setjump");
				}
				return r_FSetjump;
			}
		}

		/// <summary>
		/// System.Int32 Backjump
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FBackjump;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFBackjump
		{
			get
			{
				if(r_FBackjump == null)
				{
					r_FBackjump = new(Type, "Backjump");
				}
				return r_FBackjump;
			}
		}

		/// <summary>
		/// System.Int32 Forejump
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FForejump;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFForejump
		{
			get
			{
				if(r_FForejump == null)
				{
					r_FForejump = new(Type, "Forejump");
				}
				return r_FForejump;
			}
		}

		/// <summary>
		/// System.Int32 Testref
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTestref;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTestref
		{
			get
			{
				if(r_FTestref == null)
				{
					r_FTestref = new(Type, "Testref");
				}
				return r_FTestref;
			}
		}

		/// <summary>
		/// System.Int32 Goto
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FGoto;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFGoto
		{
			get
			{
				if(r_FGoto == null)
				{
					r_FGoto = new(Type, "Goto");
				}
				return r_FGoto;
			}
		}

		/// <summary>
		/// System.Int32 Prune
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FPrune;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFPrune
		{
			get
			{
				if(r_FPrune == null)
				{
					r_FPrune = new(Type, "Prune");
				}
				return r_FPrune;
			}
		}

		/// <summary>
		/// System.Int32 Stop
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FStop;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFStop
		{
			get
			{
				if(r_FStop == null)
				{
					r_FStop = new(Type, "Stop");
				}
				return r_FStop;
			}
		}

		/// <summary>
		/// System.Int32 ECMABoundary
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FECMABoundary;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFECMABoundary
		{
			get
			{
				if(r_FECMABoundary == null)
				{
					r_FECMABoundary = new(Type, "ECMABoundary");
				}
				return r_FECMABoundary;
			}
		}

		/// <summary>
		/// System.Int32 NonECMABoundary
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FNonECMABoundary;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFNonECMABoundary
		{
			get
			{
				if(r_FNonECMABoundary == null)
				{
					r_FNonECMABoundary = new(Type, "NonECMABoundary");
				}
				return r_FNonECMABoundary;
			}
		}

		/// <summary>
		/// System.Int32 Mask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMask;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMask
		{
			get
			{
				if(r_FMask == null)
				{
					r_FMask = new(Type, "Mask");
				}
				return r_FMask;
			}
		}

		/// <summary>
		/// System.Int32 Rtl
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FRtl;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFRtl
		{
			get
			{
				if(r_FRtl == null)
				{
					r_FRtl = new(Type, "Rtl");
				}
				return r_FRtl;
			}
		}

		/// <summary>
		/// System.Int32 Back
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FBack;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFBack
		{
			get
			{
				if(r_FBack == null)
				{
					r_FBack = new(Type, "Back");
				}
				return r_FBack;
			}
		}

		/// <summary>
		/// System.Int32 Back2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FBack2;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFBack2
		{
			get
			{
				if(r_FBack2 == null)
				{
					r_FBack2 = new(Type, "Back2");
				}
				return r_FBack2;
			}
		}

		/// <summary>
		/// System.Int32 Ci
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCi;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCi
		{
			get
			{
				if(r_FCi == null)
				{
					r_FCi = new(Type, "Ci");
				}
				return r_FCi;
			}
		}

		/// <summary>
		/// System.Int32[] Codes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FCodes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFCodes
		{
			get
			{
				if(r_FCodes == null)
				{
					r_FCodes = new(this, "Codes");
				}
				return r_FCodes;
			}
		}

		/// <summary>
		/// System.String[] Strings
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FStrings;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFStrings
		{
			get
			{
				if(r_FStrings == null)
				{
					r_FStrings = new(this, "Strings");
				}
				return r_FStrings;
			}
		}

		/// <summary>
		/// System.Int32 TrackCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FTrackCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFTrackCount
		{
			get
			{
				if(r_FTrackCount == null)
				{
					r_FTrackCount = new(this, "TrackCount");
				}
				return r_FTrackCount;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable Caps
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_FCaps;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RFCaps
		{
			get
			{
				if(r_FCaps == null)
				{
					r_FCaps = new(this, "Caps");
				}
				return r_FCaps;
			}
		}

		/// <summary>
		/// System.Int32 CapSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FCapSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFCapSize
		{
			get
			{
				if(r_FCapSize == null)
				{
					r_FCapSize = new(this, "CapSize");
				}
				return r_FCapSize;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Text.RegularExpressions.RegexPrefix] FCPrefix
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexPrefix> r_FFCPrefix;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexPrefix> RFFCPrefix
		{
			get
			{
				if(r_FFCPrefix == null)
				{
					r_FFCPrefix = new(this, "FCPrefix");
				}
				return r_FFCPrefix;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexBoyerMoore BMPrefix
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexBoyerMoore r_FBMPrefix;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexBoyerMoore RFBMPrefix
		{
			get
			{
				if(r_FBMPrefix == null)
				{
					r_FBMPrefix = new(this, "BMPrefix");
				}
				return r_FBMPrefix;
			}
		}

		/// <summary>
		/// System.Int32 Anchors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FAnchors;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFAnchors
		{
			get
			{
				if(r_FAnchors == null)
				{
					r_FAnchors = new(this, "Anchors");
				}
				return r_FAnchors;
			}
		}

		/// <summary>
		/// System.Boolean RightToLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FRightToLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFRightToLeft
		{
			get
			{
				if(r_FRightToLeft == null)
				{
					r_FRightToLeft = new(this, "RightToLeft");
				}
				return r_FRightToLeft;
			}
		}

		/// <summary>
		/// Boolean OpcodeBacktracks(Int32)
		/// </summary>
		protected static RMethod r_MOpcodeBacktracks_Int32;
		public static RMethod RMOpcodeBacktracks_Int32
		{
			get
			{
				if(r_MOpcodeBacktracks_Int32 == null)
				{
					r_MOpcodeBacktracks_Int32 = new(Type, "OpcodeBacktracks", 0, typeof(System.Int32));
				}
				return r_MOpcodeBacktracks_Int32;
			}
		}

		/// <summary>
		/// Int32 OpcodeSize(Int32)
		/// </summary>
		protected static RMethod r_MOpcodeSize_Int32;
		public static RMethod RMOpcodeSize_Int32
		{
			get
			{
				if(r_MOpcodeSize_Int32 == null)
				{
					r_MOpcodeSize_Int32 = new(Type, "OpcodeSize", 0, typeof(System.Int32));
				}
				return r_MOpcodeSize_Int32;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_MFinalize;
		public virtual RMethod RMFinalize
		{
			get
			{
				if(r_MFinalize == null)
				{
					r_MFinalize = new(this, "Finalize", 0);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_MGetHashCode;
		public virtual RMethod RMGetHashCode
		{
			get
			{
				if(r_MGetHashCode == null)
				{
					r_MGetHashCode = new(this, "GetHashCode", 0);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_MGetType;
		public virtual RMethod RMGetType
		{
			get
			{
				if(r_MGetType == null)
				{
					r_MGetType = new(this, "GetType", 0);
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MMemberwiseClone;
		public virtual RMethod RMMemberwiseClone
		{
			get
			{
				if(r_MMemberwiseClone == null)
				{
					r_MMemberwiseClone = new(this, "MemberwiseClone", 0);
				}
				return r_MMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
				}
				return r_MToString;
			}
		}


        public static System.Boolean OpcodeBacktracks(System.Int32 @Op)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Op};
            var ___result = RMOpcodeBacktracks_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Int32 OpcodeSize(System.Int32 @opcode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode};
            var ___result = RMOpcodeSize_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
