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
		protected RSystem.RObject r_Key;
		public virtual RSystem.RObject RKey
		{
			get
			{
				if(r_Key == null)
				{
					r_Key = new(this, "Key", -1);
					r_Key.SetBelong(this.instance);
				}
				return r_Key;
			}
		}

		/// <summary>
		/// System.Object Value
		/// </summary>
		protected RSystem.RObject r_Value;
		public virtual RSystem.RObject RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// System.Collections.DictionaryEntry Entry
		/// </summary>
		protected RSystem.RCollections.RDictionaryEntry r_Entry;
		public virtual RSystem.RCollections.RDictionaryEntry REntry
		{
			get
			{
				if(r_Entry == null)
				{
					r_Entry = new(this, "Entry", -1);
					r_Entry.SetBelong(this.instance);
				}
				return r_Entry;
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
