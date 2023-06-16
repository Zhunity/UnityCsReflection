
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Collections.IDictionaryEnumerator
	/// </summary>
    public partial class RIDictionaryEnumerator : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Collections.IDictionaryEnumerator);
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


		/// <summary>
		/// System.Object Key
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPKey
		{
			get
			{
				if(r_PKey == null)
				{
					r_PKey = new(this, "Key", -1);
				}
				return r_PKey;
			}
		}

		/// <summary>
		/// System.Object Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// System.Collections.DictionaryEntry Entry
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RDictionaryEntry r_PEntry;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RDictionaryEntry RPEntry
		{
			get
			{
				if(r_PEntry == null)
				{
					r_PEntry = new(this, "Entry", -1);
				}
				return r_PEntry;
			}
		}


    }
}
