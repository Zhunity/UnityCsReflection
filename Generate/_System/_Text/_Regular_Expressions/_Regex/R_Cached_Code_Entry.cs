
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{public partial class RRegex
{
	
	/// <summary>
	/// System.Text.RegularExpressions.Regex+CachedCodeEntry
	/// </summary>
    public partial class RCachedCodeEntry : RMember //
    {

		/// <summary>
		/// System.Text.RegularExpressions.Regex+CachedCodeEntry Next
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry r_FNext;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry RFNext
		{
			get
			{
				if(r_FNext == null)
				{
					r_FNext = new(this, "Next");
				}
				return r_FNext;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex+CachedCodeEntry Previous
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry r_FPrevious;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry RFPrevious
		{
			get
			{
				if(r_FPrevious == null)
				{
					r_FPrevious = new(this, "Previous");
				}
				return r_FPrevious;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex+CachedCodeEntryKey Key
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey r_FKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey RFKey
		{
			get
			{
				if(r_FKey == null)
				{
					r_FKey = new(this, "Key");
				}
				return r_FKey;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexCode Code
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexCode r_FCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexCode RFCode
		{
			get
			{
				if(r_FCode == null)
				{
					r_FCode = new(this, "Code");
				}
				return r_FCode;
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
		/// System.Collections.Hashtable Capnames
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_FCapnames;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RFCapnames
		{
			get
			{
				if(r_FCapnames == null)
				{
					r_FCapnames = new(this, "Capnames");
				}
				return r_FCapnames;
			}
		}

		/// <summary>
		/// System.String[] Capslist
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FCapslist;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFCapslist
		{
			get
			{
				if(r_FCapslist == null)
				{
					r_FCapslist = new(this, "Capslist");
				}
				return r_FCapslist;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunnerFactory Factory
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexRunnerFactory r_FFactory;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexRunnerFactory RFFactory
		{
			get
			{
				if(r_FFactory == null)
				{
					r_FFactory = new(this, "Factory");
				}
				return r_FFactory;
			}
		}

		/// <summary>
		/// System.Int32 Capsize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FCapsize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFCapsize
		{
			get
			{
				if(r_FCapsize == null)
				{
					r_FCapsize = new(this, "Capsize");
				}
				return r_FCapsize;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.ExclusiveReference Runnerref
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RExclusiveReference r_FRunnerref;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RExclusiveReference RFRunnerref
		{
			get
			{
				if(r_FRunnerref == null)
				{
					r_FRunnerref = new(this, "Runnerref");
				}
				return r_FRunnerref;
			}
		}

		/// <summary>
		/// System.WeakReference`1[System.Text.RegularExpressions.RegexReplacement] ReplRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RWeakReference<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexReplacement> r_FReplRef;
		public virtual Hvak.Editor.Refleaction.RSystem.RWeakReference<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexReplacement> RFReplRef
		{
			get
			{
				if(r_FReplRef == null)
				{
					r_FReplRef = new(this, "ReplRef");
				}
				return r_FReplRef;
			}
		}

		/// <summary>
		/// Void AddCompiled(System.Text.RegularExpressions.RegexRunnerFactory)
		/// </summary>
		protected RMethod r_MAddCompiled_RegexRunnerFactory;
		public virtual RMethod RMAddCompiled_RegexRunnerFactory
		{
			get
			{
				if(r_MAddCompiled_RegexRunnerFactory == null)
				{
					r_MAddCompiled_RegexRunnerFactory = new(this, "AddCompiled", 0, typeof(System.Text.RegularExpressions.RegexRunnerFactory));
				}
				return r_MAddCompiled_RegexRunnerFactory;
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


        public RCachedCodeEntry() : base("System.Text.RegularExpressions.Regex+CachedCodeEntry")
        {
        }

        public RCachedCodeEntry(System.Object instance) : base("System.Text.RegularExpressions.Regex+CachedCodeEntry")
		{
            SetInstance(instance);
		}

        public RCachedCodeEntry(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCachedCodeEntry(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddCompiled(System.Text.RegularExpressions.RegexRunnerFactory @factory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@factory};
            var ___result = RMAddCompiled_RegexRunnerFactory.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}