using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
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
		protected RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry r_Next;
		public virtual RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry RNext
		{
			get
			{
				if(r_Next == null)
				{
					r_Next = new(this, "Next");
					r_Next.SetBelong(this.instance);
				}
				return r_Next;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex+CachedCodeEntry Previous
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry r_Previous;
		public virtual RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry RPrevious
		{
			get
			{
				if(r_Previous == null)
				{
					r_Previous = new(this, "Previous");
					r_Previous.SetBelong(this.instance);
				}
				return r_Previous;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex+CachedCodeEntryKey Key
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey r_Key;
		public virtual RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey RKey
		{
			get
			{
				if(r_Key == null)
				{
					r_Key = new(this, "Key");
					r_Key.SetBelong(this.instance);
				}
				return r_Key;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexCode Code
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegexCode r_Code;
		public virtual RSystem.RText.RRegularExpressions.RRegexCode RCode
		{
			get
			{
				if(r_Code == null)
				{
					r_Code = new(this, "Code");
					r_Code.SetBelong(this.instance);
				}
				return r_Code;
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
		/// System.Collections.Hashtable Capnames
		/// </summary>
		protected RSystem.RCollections.RHashtable r_Capnames;
		public virtual RSystem.RCollections.RHashtable RCapnames
		{
			get
			{
				if(r_Capnames == null)
				{
					r_Capnames = new(this, "Capnames");
					r_Capnames.SetBelong(this.instance);
				}
				return r_Capnames;
			}
		}

		/// <summary>
		/// System.String[] Capslist
		/// </summary>
		protected RFieldArray<RField> r_Capslist;
		public virtual RFieldArray<RField> RCapslist
		{
			get
			{
				if(r_Capslist == null)
				{
					r_Capslist = new(this, "Capslist");
					r_Capslist.SetBelong(this.instance);
				}
				return r_Capslist;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunnerFactory Factory
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegexRunnerFactory r_Factory;
		public virtual RSystem.RText.RRegularExpressions.RRegexRunnerFactory RFactory
		{
			get
			{
				if(r_Factory == null)
				{
					r_Factory = new(this, "Factory");
					r_Factory.SetBelong(this.instance);
				}
				return r_Factory;
			}
		}

		/// <summary>
		/// System.Int32 Capsize
		/// </summary>
		protected RField r_Capsize;
		public virtual RField RCapsize
		{
			get
			{
				if(r_Capsize == null)
				{
					r_Capsize = new(this, "Capsize");
					r_Capsize.SetBelong(this.instance);
				}
				return r_Capsize;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.ExclusiveReference Runnerref
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RExclusiveReference r_Runnerref;
		public virtual RSystem.RText.RRegularExpressions.RExclusiveReference Runnerref
		{
			get
			{
				if(r_Runnerref == null)
				{
					r_Runnerref = new(this, "Runnerref");
					r_Runnerref.SetBelong(this.instance);
				}
				return r_Runnerref;
			}
		}

		/// <summary>
		/// System.WeakReference`1[System.Text.RegularExpressions.RegexReplacement] ReplRef
		/// </summary>
		protected RSystem.RWeakReference<RSystem.RText.RRegularExpressions.RRegexReplacement> r_ReplRef;
		public virtual RSystem.RWeakReference<RSystem.RText.RRegularExpressions.RRegexReplacement> ReplRef
		{
			get
			{
				if(r_ReplRef == null)
				{
					r_ReplRef = new(this, "ReplRef");
					r_ReplRef.SetBelong(this.instance);
				}
				return r_ReplRef;
			}
		}

		/// <summary>
		/// Void AddCompiled(System.Text.RegularExpressions.RegexRunnerFactory)
		/// </summary>
		protected RMethod r_RAddCompiled_RegexRunnerFactory;
		public virtual RMethod RAddCompiled_RegexRunnerFactory
		{
			get
			{
				if(r_RAddCompiled_RegexRunnerFactory == null)
				{
					r_RAddCompiled_RegexRunnerFactory = new(this, "AddCompiled", 0, typeof(System.Text.RegularExpressions.RegexRunnerFactory));
					r_RAddCompiled_RegexRunnerFactory.SetBelong(this.instance);
				}
				return r_RAddCompiled_RegexRunnerFactory;
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

        public virtual void AddCompiled(System.Text.RegularExpressions.RegexRunnerFactory  @factory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@factory};
            var ___result = RAddCompiled_RegexRunnerFactory.Invoke(___genericsType, ___parameters);

            
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
}