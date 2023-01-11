using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextStyleSheet
	/// </summary>
    public partial class RTextStyleSheet : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.TextStyle] m_StyleList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RTextStyle> r_m_StyleList;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RTextStyle> Rm_StyleList
		{
			get
			{
				if(r_m_StyleList == null)
				{
					r_m_StyleList = new(this, "m_StyleList");
					r_m_StyleList.SetBelong(this.instance);
				}
				return r_m_StyleList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEngine.TextCore.Text.TextStyle] m_StyleLookupDictionary
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RInt32, RUnityEngine.RTextCore.RText.RTextStyle> r_m_StyleLookupDictionary;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RInt32, RUnityEngine.RTextCore.RText.RTextStyle> Rm_StyleLookupDictionary
		{
			get
			{
				if(r_m_StyleLookupDictionary == null)
				{
					r_m_StyleLookupDictionary = new(this, "m_StyleLookupDictionary");
					r_m_StyleLookupDictionary.SetBelong(this.instance);
				}
				return r_m_StyleLookupDictionary;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.TextStyle] styles
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RTextStyle> r_styles;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RTextStyle> Rstyles
		{
			get
			{
				if(r_styles == null)
				{
					r_styles = new(this, "styles", -1);
					r_styles.SetBelong(this.instance);
				}
				return r_styles;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_name;
		public virtual RSystem.RString Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyle GetStyle(Int32)
		/// </summary>
		protected RMethod r_GetStyle_Int32;
		public virtual RMethod RGetStyle_Int32
		{
			get
			{
				if(r_GetStyle_Int32 == null)
				{
					r_GetStyle_Int32 = new(this, "GetStyle", 0, typeof(System.Int32));
					r_GetStyle_Int32.SetBelong(this.instance);
				}
				return r_GetStyle_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyle GetStyle(System.String)
		/// </summary>
		protected RMethod r_GetStyle_String;
		public virtual RMethod RGetStyle_String
		{
			get
			{
				if(r_GetStyle_String == null)
				{
					r_GetStyle_String = new(this, "GetStyle", 0, typeof(System.String));
					r_GetStyle_String.SetBelong(this.instance);
				}
				return r_GetStyle_String;
			}
		}

		/// <summary>
		/// Void RefreshStyles()
		/// </summary>
		protected RMethod r_RefreshStyles;
		public virtual RMethod RRefreshStyles
		{
			get
			{
				if(r_RefreshStyles == null)
				{
					r_RefreshStyles = new(this, "RefreshStyles", 0);
					r_RefreshStyles.SetBelong(this.instance);
				}
				return r_RefreshStyles;
			}
		}

		/// <summary>
		/// Void LoadStyleDictionaryInternal()
		/// </summary>
		protected RMethod r_LoadStyleDictionaryInternal;
		public virtual RMethod RLoadStyleDictionaryInternal
		{
			get
			{
				if(r_LoadStyleDictionaryInternal == null)
				{
					r_LoadStyleDictionaryInternal = new(this, "LoadStyleDictionaryInternal", 0);
					r_LoadStyleDictionaryInternal.SetBelong(this.instance);
				}
				return r_LoadStyleDictionaryInternal;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_SetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_SetDirty == null)
				{
					r_SetDirty = new(this, "SetDirty", 0);
					r_SetDirty.SetBelong(this.instance);
				}
				return r_SetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.TextCore.Text.TextStyle GetStyle(System.Int32 @hashCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashCode};
            var ___result = RGetStyle_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.TextStyle)___result;
        }


        public virtual UnityEngine.TextCore.Text.TextStyle GetStyle(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetStyle_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.Text.TextStyle)___result;
        }


        public virtual void RefreshStyles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRefreshStyles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadStyleDictionaryInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadStyleDictionaryInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

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
