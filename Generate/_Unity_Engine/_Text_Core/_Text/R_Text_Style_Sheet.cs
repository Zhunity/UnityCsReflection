
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextCore.Text.TextStyleSheet
	/// </summary>
    public partial class RTextStyleSheet : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.Text.TextStyleSheet);
            }
        }

        public RTextStyleSheet() : base("UnityEngine.TextCore.Text.TextStyleSheet")
        {
        }

        public RTextStyleSheet(System.Object instance) : base("UnityEngine.TextCore.Text.TextStyleSheet")
		{
            SetInstance(instance);
		}

        public RTextStyleSheet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextStyleSheet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.TextStyle] m_StyleList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyle> r_Fm_StyleList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyle> RFm_StyleList
		{
			get
			{
				if(r_Fm_StyleList == null)
				{
					r_Fm_StyleList = new(this, "m_StyleList");
				}
				return r_Fm_StyleList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEngine.TextCore.Text.TextStyle] m_StyleLookupDictionary
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyle> r_Fm_StyleLookupDictionary;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyle> RFm_StyleLookupDictionary
		{
			get
			{
				if(r_Fm_StyleLookupDictionary == null)
				{
					r_Fm_StyleLookupDictionary = new(this, "m_StyleLookupDictionary");
				}
				return r_Fm_StyleLookupDictionary;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.TextStyle] styles
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyle> r_Pstyles;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextStyle> RPstyles
		{
			get
			{
				if(r_Pstyles == null)
				{
					r_Pstyles = new(this, "styles", -1);
				}
				return r_Pstyles;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyle GetStyle(Int32)
		/// </summary>
		protected RMethod r_MGetStyle_Int32;
		public virtual RMethod RMGetStyle_Int32
		{
			get
			{
				if(r_MGetStyle_Int32 == null)
				{
					r_MGetStyle_Int32 = new(this, "GetStyle", 0, typeof(System.Int32));
				}
				return r_MGetStyle_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyle GetStyle(System.String)
		/// </summary>
		protected RMethod r_MGetStyle_String;
		public virtual RMethod RMGetStyle_String
		{
			get
			{
				if(r_MGetStyle_String == null)
				{
					r_MGetStyle_String = new(this, "GetStyle", 0, typeof(System.String));
				}
				return r_MGetStyle_String;
			}
		}

		/// <summary>
		/// Void RefreshStyles()
		/// </summary>
		protected RMethod r_MRefreshStyles;
		public virtual RMethod RMRefreshStyles
		{
			get
			{
				if(r_MRefreshStyles == null)
				{
					r_MRefreshStyles = new(this, "RefreshStyles", 0);
				}
				return r_MRefreshStyles;
			}
		}

		/// <summary>
		/// Void LoadStyleDictionaryInternal()
		/// </summary>
		protected RMethod r_MLoadStyleDictionaryInternal;
		public virtual RMethod RMLoadStyleDictionaryInternal
		{
			get
			{
				if(r_MLoadStyleDictionaryInternal == null)
				{
					r_MLoadStyleDictionaryInternal = new(this, "LoadStyleDictionaryInternal", 0);
				}
				return r_MLoadStyleDictionaryInternal;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
				}
				return r_MGetInstanceID;
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


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.TextCore.Text.TextStyle GetStyle(System.Int32 @hashCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashCode};
            var ___result = RMGetStyle_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.TextCore.Text.TextStyle>(___result);
        }


        public virtual UnityEngine.TextCore.Text.TextStyle GetStyle(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetStyle_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.TextCore.Text.TextStyle>(___result);
        }


        public virtual void RefreshStyles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshStyles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadStyleDictionaryInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLoadStyleDictionaryInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
