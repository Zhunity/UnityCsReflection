using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.IDictionaryEnumerator
	/// </summary>
    public partial class RIDictionaryEnumerator : RMember //
    {

		/// <summary>
		/// System.Object Key
		/// </summary>
		protected RSystem.RObject r_PKey;
		public virtual RSystem.RObject RPKey
		{
			get
			{
				if(r_PKey == null)
				{
					r_PKey = new(this, "Key", -1);
					r_PKey.SetBelong(this.instance);
				}
				return r_PKey;
			}
		}

		/// <summary>
		/// System.Object Value
		/// </summary>
		protected RSystem.RObject r_PValue;
		public virtual RSystem.RObject RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
					r_PValue.SetBelong(this.instance);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// System.Collections.DictionaryEntry Entry
		/// </summary>
		protected RSystem.RCollections.RDictionaryEntry r_PEntry;
		public virtual RSystem.RCollections.RDictionaryEntry RPEntry
		{
			get
			{
				if(r_PEntry == null)
				{
					r_PEntry = new(this, "Entry", -1);
					r_PEntry.SetBelong(this.instance);
				}
				return r_PEntry;
			}
		}


        public RIDictionaryEnumerator() : base("System.Collections.IDictionaryEnumerator")
        {
        }

        public RIDictionaryEnumerator(System.Object instance) : base("System.Collections.IDictionaryEnumerator")
		{
            SetInstance(instance);
		}

        public RIDictionaryEnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDictionaryEnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
