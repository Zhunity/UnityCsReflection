using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditorInternal
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
		protected RUnityEditor.RSerializedProperty r_property;
		public virtual RUnityEditor.RSerializedProperty Rproperty
		{
			get
			{
				if(r_property == null)
				{
					r_property = new(this, "property");
					r_property.SetBelong(this.instance);
				}
				return r_property;
			}
		}

		/// <summary>
		/// System.Single height
		/// </summary>
		protected RSystem.RSingle r_height;
		public virtual RSystem.RSingle Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height");
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// System.Single offset
		/// </summary>
		protected RSystem.RSingle r_offset;
		public virtual RSystem.RSingle Roffset
		{
			get
			{
				if(r_offset == null)
				{
					r_offset = new(this, "offset");
					r_offset.SetBelong(this.instance);
				}
				return r_offset;
			}
		}

		/// <summary>
		/// System.Int32 controlCount
		/// </summary>
		protected RSystem.RInt32 r_controlCount;
		public virtual RSystem.RInt32 RcontrolCount
		{
			get
			{
				if(r_controlCount == null)
				{
					r_controlCount = new(this, "controlCount");
					r_controlCount.SetBelong(this.instance);
				}
				return r_controlCount;
			}
		}

		/// <summary>
		/// Boolean Set(UnityEditor.SerializedProperty, Single, Single)
		/// </summary>
		protected RMethod r_Set_SerializedProperty_Single_Single;
		public virtual RMethod RSet_SerializedProperty_Single_Single
		{
			get
			{
				if(r_Set_SerializedProperty_Single_Single == null)
				{
					r_Set_SerializedProperty_Single_Single = new(this, "Set", 0, typeof(UnityEditor.SerializedProperty), typeof(System.Single), typeof(System.Single));
					r_Set_SerializedProperty_Single_Single.SetBelong(this.instance);
				}
				return r_Set_SerializedProperty_Single_Single;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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
            var ___result = RSet_SerializedProperty_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}