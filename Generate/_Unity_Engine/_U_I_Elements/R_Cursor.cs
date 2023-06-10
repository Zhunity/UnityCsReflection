
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Cursor
	/// </summary>
    public partial class RCursor : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Cursor);
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


		/// <summary>
		/// UnityEngine.Texture2D <texture>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_F__0__texture__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RF__0__texture__1__k__BackingField
		{
			get
			{
				if(r_F__0__texture__1__k__BackingField == null)
				{
					r_F__0__texture__1__k__BackingField = new(this, "<texture>k__BackingField");
				}
				return r_F__0__texture__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <hotspot>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_F__0__hotspot__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RF__0__hotspot__1__k__BackingField
		{
			get
			{
				if(r_F__0__hotspot__1__k__BackingField == null)
				{
					r_F__0__hotspot__1__k__BackingField = new(this, "<hotspot>k__BackingField");
				}
				return r_F__0__hotspot__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <defaultCursorId>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__defaultCursorId__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__defaultCursorId__1__k__BackingField
		{
			get
			{
				if(r_F__0__defaultCursorId__1__k__BackingField == null)
				{
					r_F__0__defaultCursorId__1__k__BackingField = new(this, "<defaultCursorId>k__BackingField");
				}
				return r_F__0__defaultCursorId__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Ptexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPtexture
		{
			get
			{
				if(r_Ptexture == null)
				{
					r_Ptexture = new(this, "texture", -1);
				}
				return r_Ptexture;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 hotspot
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Photspot;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPhotspot
		{
			get
			{
				if(r_Photspot == null)
				{
					r_Photspot = new(this, "hotspot", -1);
				}
				return r_Photspot;
			}
		}

		/// <summary>
		/// Int32 defaultCursorId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PdefaultCursorId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdefaultCursorId
		{
			get
			{
				if(r_PdefaultCursorId == null)
				{
					r_PdefaultCursorId = new(this, "defaultCursorId", -1);
				}
				return r_PdefaultCursorId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] allowedAssetTypes
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RType> r_PallowedAssetTypes;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RType> RPallowedAssetTypes
		{
			get
			{
				if(r_PallowedAssetTypes == null)
				{
					r_PallowedAssetTypes = new(typeof(UnityEngine.UIElements.Cursor), "allowedAssetTypes", -1);
				}
				return r_PallowedAssetTypes;
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
		/// Boolean Equals(UnityEngine.UIElements.Cursor)
		/// </summary>
		protected RMethod r_MEquals_Cursor;
		public virtual RMethod RMEquals_Cursor
		{
			get
			{
				if(r_MEquals_Cursor == null)
				{
					r_MEquals_Cursor = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Cursor));
				}
				return r_MEquals_Cursor;
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
		/// Boolean op_Equality(UnityEngine.UIElements.Cursor, UnityEngine.UIElements.Cursor)
		/// </summary>
		protected static RMethod r_Mop_Equality_Cursor_Cursor;
		public static RMethod RMop_Equality_Cursor_Cursor
		{
			get
			{
				if(r_Mop_Equality_Cursor_Cursor == null)
				{
					r_Mop_Equality_Cursor_Cursor = new(typeof(UnityEngine.UIElements.Cursor), "op_Equality", 0, typeof(UnityEngine.UIElements.Cursor), typeof(UnityEngine.UIElements.Cursor));
				}
				return r_Mop_Equality_Cursor_Cursor;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Cursor, UnityEngine.UIElements.Cursor)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Cursor_Cursor;
		public static RMethod RMop_Inequality_Cursor_Cursor
		{
			get
			{
				if(r_Mop_Inequality_Cursor_Cursor == null)
				{
					r_Mop_Inequality_Cursor_Cursor = new(typeof(UnityEngine.UIElements.Cursor), "op_Inequality", 0, typeof(UnityEngine.UIElements.Cursor), typeof(UnityEngine.UIElements.Cursor));
				}
				return r_Mop_Inequality_Cursor_Cursor;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Cursor @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Cursor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Cursor @style1, UnityEngine.UIElements.Cursor @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = RMop_Equality_Cursor_Cursor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Cursor @style1, UnityEngine.UIElements.Cursor @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = RMop_Inequality_Cursor_Cursor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
