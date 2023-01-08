using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Cursor
	/// </summary>
    public partial class RCursor : RMember //
    {

		/// <summary>
		/// UnityEngine.Texture2D <texture>k__BackingField
		/// </summary>
		protected RUnityEngine.RTexture2D r___0__texture__1__k__BackingField;
		public virtual RUnityEngine.RTexture2D R__0__texture__1__k__BackingField
		{
			get
			{
				if(r___0__texture__1__k__BackingField == null)
				{
					r___0__texture__1__k__BackingField = new(this, "<texture>k__BackingField");
					r___0__texture__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__texture__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <hotspot>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___0__hotspot__1__k__BackingField;
		public virtual RUnityEngine.RVector2 R__0__hotspot__1__k__BackingField
		{
			get
			{
				if(r___0__hotspot__1__k__BackingField == null)
				{
					r___0__hotspot__1__k__BackingField = new(this, "<hotspot>k__BackingField");
					r___0__hotspot__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__hotspot__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <defaultCursorId>k__BackingField
		/// </summary>
		protected RField r___0__defaultCursorId__1__k__BackingField;
		public virtual RField R__0__defaultCursorId__1__k__BackingField
		{
			get
			{
				if(r___0__defaultCursorId__1__k__BackingField == null)
				{
					r___0__defaultCursorId__1__k__BackingField = new(this, "<defaultCursorId>k__BackingField");
					r___0__defaultCursorId__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__defaultCursorId__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected RUnityEngine.RTexture2D r_texture;
		public virtual RUnityEngine.RTexture2D Rtexture
		{
			get
			{
				if(r_texture == null)
				{
					r_texture = new(this, "texture", -1);
					r_texture.SetBelong(this.instance);
				}
				return r_texture;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 hotspot
		/// </summary>
		protected RUnityEngine.RVector2 r_hotspot;
		public virtual RUnityEngine.RVector2 Rhotspot
		{
			get
			{
				if(r_hotspot == null)
				{
					r_hotspot = new(this, "hotspot", -1);
					r_hotspot.SetBelong(this.instance);
				}
				return r_hotspot;
			}
		}

		/// <summary>
		/// Int32 defaultCursorId
		/// </summary>
		protected RProperty r_defaultCursorId;
		public virtual RProperty RdefaultCursorId
		{
			get
			{
				if(r_defaultCursorId == null)
				{
					r_defaultCursorId = new(this, "defaultCursorId", -1);
					r_defaultCursorId.SetBelong(this.instance);
				}
				return r_defaultCursorId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] allowedAssetTypes
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> r_allowedAssetTypes;
		public static RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> RallowedAssetTypes
		{
			get
			{
				if(r_allowedAssetTypes == null)
				{
					r_allowedAssetTypes = new(typeof(UnityEngine.UIElements.Cursor), "allowedAssetTypes", -1);
					r_allowedAssetTypes.SetBelong(null);
				}
				return r_allowedAssetTypes;
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
		/// Boolean Equals(UnityEngine.UIElements.Cursor)
		/// </summary>
		protected RMethod r_Equals_Cursor;
		public virtual RMethod REquals_Cursor
		{
			get
			{
				if(r_Equals_Cursor == null)
				{
					r_Equals_Cursor = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Cursor));
					r_Equals_Cursor.SetBelong(this.instance);
				}
				return r_Equals_Cursor;
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
		/// Boolean op_Equality(UnityEngine.UIElements.Cursor, UnityEngine.UIElements.Cursor)
		/// </summary>
		protected static RMethod r_op_Equality_Cursor_Cursor;
		public static RMethod Rop_Equality_Cursor_Cursor
		{
			get
			{
				if(r_op_Equality_Cursor_Cursor == null)
				{
					r_op_Equality_Cursor_Cursor = new(typeof(UnityEngine.UIElements.Cursor), "op_Equality", 0, typeof(UnityEngine.UIElements.Cursor), typeof(UnityEngine.UIElements.Cursor));
					r_op_Equality_Cursor_Cursor.SetBelong(null);
				}
				return r_op_Equality_Cursor_Cursor;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Cursor, UnityEngine.UIElements.Cursor)
		/// </summary>
		protected static RMethod r_op_Inequality_Cursor_Cursor;
		public static RMethod Rop_Inequality_Cursor_Cursor
		{
			get
			{
				if(r_op_Inequality_Cursor_Cursor == null)
				{
					r_op_Inequality_Cursor_Cursor = new(typeof(UnityEngine.UIElements.Cursor), "op_Inequality", 0, typeof(UnityEngine.UIElements.Cursor), typeof(UnityEngine.UIElements.Cursor));
					r_op_Inequality_Cursor_Cursor.SetBelong(null);
				}
				return r_op_Inequality_Cursor_Cursor;
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


        public RCursor() : base("UnityEngine.UIElements.Cursor")
        {
        }

        public RCursor(System.Object instance) : base("UnityEngine.UIElements.Cursor")
		{
            SetInstance(instance);
		}

        public RCursor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCursor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Cursor  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Cursor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Cursor  @style1, UnityEngine.UIElements.Cursor  @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = Rop_Equality_Cursor_Cursor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Cursor  @style1, UnityEngine.UIElements.Cursor  @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = Rop_Inequality_Cursor_Cursor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
