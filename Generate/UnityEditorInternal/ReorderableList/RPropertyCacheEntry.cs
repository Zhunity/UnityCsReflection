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
		protected RField r_height;
		public virtual RField Rheight
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
		protected RField r_offset;
		public virtual RField Roffset
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
		protected RField r_controlCount;
		public virtual RField RcontrolCount
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
		protected RMethod r_RSet_SerializedProperty_Single_Single;
		public virtual RMethod RSet_SerializedProperty_Single_Single
		{
			get
			{
				if(r_RSet_SerializedProperty_Single_Single == null)
				{
					r_RSet_SerializedProperty_Single_Single = new(this, "Set", 0, typeof(UnityEditor.SerializedProperty), typeof(System.Single), typeof(System.Single));
					r_RSet_SerializedProperty_Single_Single.SetBelong(this.instance);
				}
				return r_RSet_SerializedProperty_Single_Single;
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

        public virtual System.Boolean Set(UnityEditor.SerializedProperty  @property, System.Single  @height, System.Single  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @height, @offset};
            var ___result = RSet_SerializedProperty_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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