
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditorInternal
{public partial class RReorderableList
{
	
	/// <summary>
	/// UnityEditorInternal.ReorderableList+PropertyCacheEntry
	/// </summary>
    public partial class RPropertyCacheEntry : RMember //
    {

		/// <summary>
		/// UnityEditor.SerializedProperty property
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RSerializedProperty r_Fproperty;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RSerializedProperty RFproperty
		{
			get
			{
				if(r_Fproperty == null)
				{
					r_Fproperty = new(this, "property");
				}
				return r_Fproperty;
			}
		}

		/// <summary>
		/// System.Single height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fheight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFheight
		{
			get
			{
				if(r_Fheight == null)
				{
					r_Fheight = new(this, "height");
				}
				return r_Fheight;
			}
		}

		/// <summary>
		/// System.Single offset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Foffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFoffset
		{
			get
			{
				if(r_Foffset == null)
				{
					r_Foffset = new(this, "offset");
				}
				return r_Foffset;
			}
		}

		/// <summary>
		/// System.Int32 controlCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcontrolCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcontrolCount
		{
			get
			{
				if(r_FcontrolCount == null)
				{
					r_FcontrolCount = new(this, "controlCount");
				}
				return r_FcontrolCount;
			}
		}

		/// <summary>
		/// Boolean Set(UnityEditor.SerializedProperty, Single, Single)
		/// </summary>
		protected RMethod r_MSet_SerializedProperty_Single_Single;
		public virtual RMethod RMSet_SerializedProperty_Single_Single
		{
			get
			{
				if(r_MSet_SerializedProperty_Single_Single == null)
				{
					r_MSet_SerializedProperty_Single_Single = new(this, "Set", 0, typeof(UnityEditor.SerializedProperty), typeof(System.Single), typeof(System.Single));
				}
				return r_MSet_SerializedProperty_Single_Single;
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


        public RPropertyCacheEntry() : base("UnityEditorInternal.ReorderableList+PropertyCacheEntry")
        {
        }

        public RPropertyCacheEntry(System.Object instance) : base("UnityEditorInternal.ReorderableList+PropertyCacheEntry")
		{
            SetInstance(instance);
		}

        public RPropertyCacheEntry(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropertyCacheEntry(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Set(UnityEditor.SerializedProperty @property, System.Single @height, System.Single @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @height, @offset};
            var ___result = RMSet_SerializedProperty_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}