using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.RegexCode
	/// </summary>
    public partial class RRegexCode : RMember //
    {

		/// <summary>
		/// System.Int32 Onerep
		/// </summary>
		protected static RField r_Onerep;
		public static RField ROnerep
		{
			get
			{
				if(r_Onerep == null)
				{
					r_Onerep = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Onerep");
					r_Onerep.SetBelong(null);
				}
				return r_Onerep;
			}
		}

		/// <summary>
		/// System.Int32 Notonerep
		/// </summary>
		protected static RField r_Notonerep;
		public static RField RNotonerep
		{
			get
			{
				if(r_Notonerep == null)
				{
					r_Notonerep = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Notonerep");
					r_Notonerep.SetBelong(null);
				}
				return r_Notonerep;
			}
		}

		/// <summary>
		/// System.Int32 Setrep
		/// </summary>
		protected static RField r_Setrep;
		public static RField RSetrep
		{
			get
			{
				if(r_Setrep == null)
				{
					r_Setrep = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Setrep");
					r_Setrep.SetBelong(null);
				}
				return r_Setrep;
			}
		}

		/// <summary>
		/// System.Int32 Oneloop
		/// </summary>
		protected static RField r_Oneloop;
		public static RField ROneloop
		{
			get
			{
				if(r_Oneloop == null)
				{
					r_Oneloop = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Oneloop");
					r_Oneloop.SetBelong(null);
				}
				return r_Oneloop;
			}
		}

		/// <summary>
		/// System.Int32 Notoneloop
		/// </summary>
		protected static RField r_Notoneloop;
		public static RField RNotoneloop
		{
			get
			{
				if(r_Notoneloop == null)
				{
					r_Notoneloop = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Notoneloop");
					r_Notoneloop.SetBelong(null);
				}
				return r_Notoneloop;
			}
		}

		/// <summary>
		/// System.Int32 Setloop
		/// </summary>
		protected static RField r_Setloop;
		public static RField RSetloop
		{
			get
			{
				if(r_Setloop == null)
				{
					r_Setloop = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Setloop");
					r_Setloop.SetBelong(null);
				}
				return r_Setloop;
			}
		}

		/// <summary>
		/// System.Int32 Onelazy
		/// </summary>
		protected static RField r_Onelazy;
		public static RField ROnelazy
		{
			get
			{
				if(r_Onelazy == null)
				{
					r_Onelazy = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Onelazy");
					r_Onelazy.SetBelong(null);
				}
				return r_Onelazy;
			}
		}

		/// <summary>
		/// System.Int32 Notonelazy
		/// </summary>
		protected static RField r_Notonelazy;
		public static RField RNotonelazy
		{
			get
			{
				if(r_Notonelazy == null)
				{
					r_Notonelazy = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Notonelazy");
					r_Notonelazy.SetBelong(null);
				}
				return r_Notonelazy;
			}
		}

		/// <summary>
		/// System.Int32 Setlazy
		/// </summary>
		protected static RField r_Setlazy;
		public static RField RSetlazy
		{
			get
			{
				if(r_Setlazy == null)
				{
					r_Setlazy = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Setlazy");
					r_Setlazy.SetBelong(null);
				}
				return r_Setlazy;
			}
		}

		/// <summary>
		/// System.Int32 One
		/// </summary>
		protected static RField r_One;
		public static RField ROne
		{
			get
			{
				if(r_One == null)
				{
					r_One = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "One");
					r_One.SetBelong(null);
				}
				return r_One;
			}
		}

		/// <summary>
		/// System.Int32 Notone
		/// </summary>
		protected static RField r_Notone;
		public static RField RNotone
		{
			get
			{
				if(r_Notone == null)
				{
					r_Notone = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Notone");
					r_Notone.SetBelong(null);
				}
				return r_Notone;
			}
		}

		/// <summary>
		/// System.Int32 Set
		/// </summary>
		protected static RField r_Set;
		public static RField RSet
		{
			get
			{
				if(r_Set == null)
				{
					r_Set = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Set");
					r_Set.SetBelong(null);
				}
				return r_Set;
			}
		}

		/// <summary>
		/// System.Int32 Multi
		/// </summary>
		protected static RField r_Multi;
		public static RField RMulti
		{
			get
			{
				if(r_Multi == null)
				{
					r_Multi = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Multi");
					r_Multi.SetBelong(null);
				}
				return r_Multi;
			}
		}

		/// <summary>
		/// System.Int32 Ref
		/// </summary>
		protected static RField r_Ref;
		public static RField Ref
		{
			get
			{
				if(r_Ref == null)
				{
					r_Ref = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Ref");
					r_Ref.SetBelong(null);
				}
				return r_Ref;
			}
		}

		/// <summary>
		/// System.Int32 Bol
		/// </summary>
		protected static RField r_Bol;
		public static RField RBol
		{
			get
			{
				if(r_Bol == null)
				{
					r_Bol = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Bol");
					r_Bol.SetBelong(null);
				}
				return r_Bol;
			}
		}

		/// <summary>
		/// System.Int32 Eol
		/// </summary>
		protected static RField r_Eol;
		public static RField REol
		{
			get
			{
				if(r_Eol == null)
				{
					r_Eol = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Eol");
					r_Eol.SetBelong(null);
				}
				return r_Eol;
			}
		}

		/// <summary>
		/// System.Int32 Boundary
		/// </summary>
		protected static RField r_Boundary;
		public static RField RBoundary
		{
			get
			{
				if(r_Boundary == null)
				{
					r_Boundary = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Boundary");
					r_Boundary.SetBelong(null);
				}
				return r_Boundary;
			}
		}

		/// <summary>
		/// System.Int32 Nonboundary
		/// </summary>
		protected static RField r_Nonboundary;
		public static RField RNonboundary
		{
			get
			{
				if(r_Nonboundary == null)
				{
					r_Nonboundary = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Nonboundary");
					r_Nonboundary.SetBelong(null);
				}
				return r_Nonboundary;
			}
		}

		/// <summary>
		/// System.Int32 Beginning
		/// </summary>
		protected static RField r_Beginning;
		public static RField RBeginning
		{
			get
			{
				if(r_Beginning == null)
				{
					r_Beginning = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Beginning");
					r_Beginning.SetBelong(null);
				}
				return r_Beginning;
			}
		}

		/// <summary>
		/// System.Int32 Start
		/// </summary>
		protected static RField r_Start;
		public static RField RStart
		{
			get
			{
				if(r_Start == null)
				{
					r_Start = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Start");
					r_Start.SetBelong(null);
				}
				return r_Start;
			}
		}

		/// <summary>
		/// System.Int32 EndZ
		/// </summary>
		protected static RField r_EndZ;
		public static RField REndZ
		{
			get
			{
				if(r_EndZ == null)
				{
					r_EndZ = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "EndZ");
					r_EndZ.SetBelong(null);
				}
				return r_EndZ;
			}
		}

		/// <summary>
		/// System.Int32 End
		/// </summary>
		protected static RField r_End;
		public static RField REnd
		{
			get
			{
				if(r_End == null)
				{
					r_End = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "End");
					r_End.SetBelong(null);
				}
				return r_End;
			}
		}

		/// <summary>
		/// System.Int32 Nothing
		/// </summary>
		protected static RField r_Nothing;
		public static RField RNothing
		{
			get
			{
				if(r_Nothing == null)
				{
					r_Nothing = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Nothing");
					r_Nothing.SetBelong(null);
				}
				return r_Nothing;
			}
		}

		/// <summary>
		/// System.Int32 Lazybranch
		/// </summary>
		protected static RField r_Lazybranch;
		public static RField RLazybranch
		{
			get
			{
				if(r_Lazybranch == null)
				{
					r_Lazybranch = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Lazybranch");
					r_Lazybranch.SetBelong(null);
				}
				return r_Lazybranch;
			}
		}

		/// <summary>
		/// System.Int32 Branchmark
		/// </summary>
		protected static RField r_Branchmark;
		public static RField RBranchmark
		{
			get
			{
				if(r_Branchmark == null)
				{
					r_Branchmark = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Branchmark");
					r_Branchmark.SetBelong(null);
				}
				return r_Branchmark;
			}
		}

		/// <summary>
		/// System.Int32 Lazybranchmark
		/// </summary>
		protected static RField r_Lazybranchmark;
		public static RField RLazybranchmark
		{
			get
			{
				if(r_Lazybranchmark == null)
				{
					r_Lazybranchmark = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Lazybranchmark");
					r_Lazybranchmark.SetBelong(null);
				}
				return r_Lazybranchmark;
			}
		}

		/// <summary>
		/// System.Int32 Nullcount
		/// </summary>
		protected static RField r_Nullcount;
		public static RField RNullcount
		{
			get
			{
				if(r_Nullcount == null)
				{
					r_Nullcount = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Nullcount");
					r_Nullcount.SetBelong(null);
				}
				return r_Nullcount;
			}
		}

		/// <summary>
		/// System.Int32 Setcount
		/// </summary>
		protected static RField r_Setcount;
		public static RField RSetcount
		{
			get
			{
				if(r_Setcount == null)
				{
					r_Setcount = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Setcount");
					r_Setcount.SetBelong(null);
				}
				return r_Setcount;
			}
		}

		/// <summary>
		/// System.Int32 Branchcount
		/// </summary>
		protected static RField r_Branchcount;
		public static RField RBranchcount
		{
			get
			{
				if(r_Branchcount == null)
				{
					r_Branchcount = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Branchcount");
					r_Branchcount.SetBelong(null);
				}
				return r_Branchcount;
			}
		}

		/// <summary>
		/// System.Int32 Lazybranchcount
		/// </summary>
		protected static RField r_Lazybranchcount;
		public static RField RLazybranchcount
		{
			get
			{
				if(r_Lazybranchcount == null)
				{
					r_Lazybranchcount = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Lazybranchcount");
					r_Lazybranchcount.SetBelong(null);
				}
				return r_Lazybranchcount;
			}
		}

		/// <summary>
		/// System.Int32 Nullmark
		/// </summary>
		protected static RField r_Nullmark;
		public static RField RNullmark
		{
			get
			{
				if(r_Nullmark == null)
				{
					r_Nullmark = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Nullmark");
					r_Nullmark.SetBelong(null);
				}
				return r_Nullmark;
			}
		}

		/// <summary>
		/// System.Int32 Setmark
		/// </summary>
		protected static RField r_Setmark;
		public static RField RSetmark
		{
			get
			{
				if(r_Setmark == null)
				{
					r_Setmark = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Setmark");
					r_Setmark.SetBelong(null);
				}
				return r_Setmark;
			}
		}

		/// <summary>
		/// System.Int32 Capturemark
		/// </summary>
		protected static RField r_Capturemark;
		public static RField RCapturemark
		{
			get
			{
				if(r_Capturemark == null)
				{
					r_Capturemark = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Capturemark");
					r_Capturemark.SetBelong(null);
				}
				return r_Capturemark;
			}
		}

		/// <summary>
		/// System.Int32 Getmark
		/// </summary>
		protected static RField r_Getmark;
		public static RField RGetmark
		{
			get
			{
				if(r_Getmark == null)
				{
					r_Getmark = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Getmark");
					r_Getmark.SetBelong(null);
				}
				return r_Getmark;
			}
		}

		/// <summary>
		/// System.Int32 Setjump
		/// </summary>
		protected static RField r_Setjump;
		public static RField RSetjump
		{
			get
			{
				if(r_Setjump == null)
				{
					r_Setjump = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Setjump");
					r_Setjump.SetBelong(null);
				}
				return r_Setjump;
			}
		}

		/// <summary>
		/// System.Int32 Backjump
		/// </summary>
		protected static RField r_Backjump;
		public static RField RBackjump
		{
			get
			{
				if(r_Backjump == null)
				{
					r_Backjump = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Backjump");
					r_Backjump.SetBelong(null);
				}
				return r_Backjump;
			}
		}

		/// <summary>
		/// System.Int32 Forejump
		/// </summary>
		protected static RField r_Forejump;
		public static RField RForejump
		{
			get
			{
				if(r_Forejump == null)
				{
					r_Forejump = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Forejump");
					r_Forejump.SetBelong(null);
				}
				return r_Forejump;
			}
		}

		/// <summary>
		/// System.Int32 Testref
		/// </summary>
		protected static RField r_Testref;
		public static RField RTestref
		{
			get
			{
				if(r_Testref == null)
				{
					r_Testref = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Testref");
					r_Testref.SetBelong(null);
				}
				return r_Testref;
			}
		}

		/// <summary>
		/// System.Int32 Goto
		/// </summary>
		protected static RField r_Goto;
		public static RField RGoto
		{
			get
			{
				if(r_Goto == null)
				{
					r_Goto = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Goto");
					r_Goto.SetBelong(null);
				}
				return r_Goto;
			}
		}

		/// <summary>
		/// System.Int32 Prune
		/// </summary>
		protected static RField r_Prune;
		public static RField RPrune
		{
			get
			{
				if(r_Prune == null)
				{
					r_Prune = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Prune");
					r_Prune.SetBelong(null);
				}
				return r_Prune;
			}
		}

		/// <summary>
		/// System.Int32 Stop
		/// </summary>
		protected static RField r_Stop;
		public static RField RStop
		{
			get
			{
				if(r_Stop == null)
				{
					r_Stop = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Stop");
					r_Stop.SetBelong(null);
				}
				return r_Stop;
			}
		}

		/// <summary>
		/// System.Int32 ECMABoundary
		/// </summary>
		protected static RField r_ECMABoundary;
		public static RField RECMABoundary
		{
			get
			{
				if(r_ECMABoundary == null)
				{
					r_ECMABoundary = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "ECMABoundary");
					r_ECMABoundary.SetBelong(null);
				}
				return r_ECMABoundary;
			}
		}

		/// <summary>
		/// System.Int32 NonECMABoundary
		/// </summary>
		protected static RField r_NonECMABoundary;
		public static RField RNonECMABoundary
		{
			get
			{
				if(r_NonECMABoundary == null)
				{
					r_NonECMABoundary = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "NonECMABoundary");
					r_NonECMABoundary.SetBelong(null);
				}
				return r_NonECMABoundary;
			}
		}

		/// <summary>
		/// System.Int32 Mask
		/// </summary>
		protected static RField r_Mask;
		public static RField RMask
		{
			get
			{
				if(r_Mask == null)
				{
					r_Mask = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Mask");
					r_Mask.SetBelong(null);
				}
				return r_Mask;
			}
		}

		/// <summary>
		/// System.Int32 Rtl
		/// </summary>
		protected static RField r_Rtl;
		public static RField Rtl
		{
			get
			{
				if(r_Rtl == null)
				{
					r_Rtl = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Rtl");
					r_Rtl.SetBelong(null);
				}
				return r_Rtl;
			}
		}

		/// <summary>
		/// System.Int32 Back
		/// </summary>
		protected static RField r_Back;
		public static RField RBack
		{
			get
			{
				if(r_Back == null)
				{
					r_Back = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Back");
					r_Back.SetBelong(null);
				}
				return r_Back;
			}
		}

		/// <summary>
		/// System.Int32 Back2
		/// </summary>
		protected static RField r_Back2;
		public static RField RBack2
		{
			get
			{
				if(r_Back2 == null)
				{
					r_Back2 = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Back2");
					r_Back2.SetBelong(null);
				}
				return r_Back2;
			}
		}

		/// <summary>
		/// System.Int32 Ci
		/// </summary>
		protected static RField r_Ci;
		public static RField RCi
		{
			get
			{
				if(r_Ci == null)
				{
					r_Ci = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "Ci");
					r_Ci.SetBelong(null);
				}
				return r_Ci;
			}
		}

		/// <summary>
		/// System.Int32[] Codes
		/// </summary>
		protected RFieldArray<RField> r_Codes;
		public virtual RFieldArray<RField> RCodes
		{
			get
			{
				if(r_Codes == null)
				{
					r_Codes = new(this, "Codes");
					r_Codes.SetBelong(this.instance);
				}
				return r_Codes;
			}
		}

		/// <summary>
		/// System.String[] Strings
		/// </summary>
		protected RFieldArray<RField> r_Strings;
		public virtual RFieldArray<RField> RStrings
		{
			get
			{
				if(r_Strings == null)
				{
					r_Strings = new(this, "Strings");
					r_Strings.SetBelong(this.instance);
				}
				return r_Strings;
			}
		}

		/// <summary>
		/// System.Int32 TrackCount
		/// </summary>
		protected RField r_TrackCount;
		public virtual RField RTrackCount
		{
			get
			{
				if(r_TrackCount == null)
				{
					r_TrackCount = new(this, "TrackCount");
					r_TrackCount.SetBelong(this.instance);
				}
				return r_TrackCount;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable Caps
		/// </summary>
		protected RSystem.RCollections.RHashtable r_Caps;
		public virtual RSystem.RCollections.RHashtable RCaps
		{
			get
			{
				if(r_Caps == null)
				{
					r_Caps = new(this, "Caps");
					r_Caps.SetBelong(this.instance);
				}
				return r_Caps;
			}
		}

		/// <summary>
		/// System.Int32 CapSize
		/// </summary>
		protected RField r_CapSize;
		public virtual RField RCapSize
		{
			get
			{
				if(r_CapSize == null)
				{
					r_CapSize = new(this, "CapSize");
					r_CapSize.SetBelong(this.instance);
				}
				return r_CapSize;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Text.RegularExpressions.RegexPrefix] FCPrefix
		/// </summary>
		protected RField r_FCPrefix;
		public virtual RField RFCPrefix
		{
			get
			{
				if(r_FCPrefix == null)
				{
					r_FCPrefix = new(this, "FCPrefix");
					r_FCPrefix.SetBelong(this.instance);
				}
				return r_FCPrefix;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexBoyerMoore BMPrefix
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegexBoyerMoore r_BMPrefix;
		public virtual RSystem.RText.RRegularExpressions.RRegexBoyerMoore RBMPrefix
		{
			get
			{
				if(r_BMPrefix == null)
				{
					r_BMPrefix = new(this, "BMPrefix");
					r_BMPrefix.SetBelong(this.instance);
				}
				return r_BMPrefix;
			}
		}

		/// <summary>
		/// System.Int32 Anchors
		/// </summary>
		protected RField r_Anchors;
		public virtual RField RAnchors
		{
			get
			{
				if(r_Anchors == null)
				{
					r_Anchors = new(this, "Anchors");
					r_Anchors.SetBelong(this.instance);
				}
				return r_Anchors;
			}
		}

		/// <summary>
		/// System.Boolean RightToLeft
		/// </summary>
		protected RField r_RightToLeft;
		public virtual RField RightToLeft
		{
			get
			{
				if(r_RightToLeft == null)
				{
					r_RightToLeft = new(this, "RightToLeft");
					r_RightToLeft.SetBelong(this.instance);
				}
				return r_RightToLeft;
			}
		}

		/// <summary>
		/// Boolean OpcodeBacktracks(Int32)
		/// </summary>
		protected static RMethod r_ROpcodeBacktracks_Int32;
		public static RMethod ROpcodeBacktracks_Int32
		{
			get
			{
				if(r_ROpcodeBacktracks_Int32 == null)
				{
					r_ROpcodeBacktracks_Int32 = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "OpcodeBacktracks", 0, typeof(System.Int32));
					r_ROpcodeBacktracks_Int32.SetBelong(null);
				}
				return r_ROpcodeBacktracks_Int32;
			}
		}

		/// <summary>
		/// Int32 OpcodeSize(Int32)
		/// </summary>
		protected static RMethod r_ROpcodeSize_Int32;
		public static RMethod ROpcodeSize_Int32
		{
			get
			{
				if(r_ROpcodeSize_Int32 == null)
				{
					r_ROpcodeSize_Int32 = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), "OpcodeSize", 0, typeof(System.Int32));
					r_ROpcodeSize_Int32.SetBelong(null);
				}
				return r_ROpcodeSize_Int32;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
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

        public static System.Boolean OpcodeBacktracks(System.Int32  @Op)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Op};
            var ___result = ROpcodeBacktracks_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 OpcodeSize(System.Int32  @opcode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode};
            var ___result = ROpcodeSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
