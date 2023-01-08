using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.ConvertMeshJobData
	/// </summary>
    public partial class RConvertMeshJobData : RMember //
    {

		/// <summary>
		/// System.IntPtr vertSrc
		/// </summary>
		protected RField r_vertSrc;
		public virtual RField RvertSrc
		{
			get
			{
				if(r_vertSrc == null)
				{
					r_vertSrc = new(this, "vertSrc");
					r_vertSrc.SetBelong(this.instance);
				}
				return r_vertSrc;
			}
		}

		/// <summary>
		/// System.IntPtr vertDst
		/// </summary>
		protected RField r_vertDst;
		public virtual RField RvertDst
		{
			get
			{
				if(r_vertDst == null)
				{
					r_vertDst = new(this, "vertDst");
					r_vertDst.SetBelong(this.instance);
				}
				return r_vertDst;
			}
		}

		/// <summary>
		/// System.Int32 vertCount
		/// </summary>
		protected RField r_vertCount;
		public virtual RField RvertCount
		{
			get
			{
				if(r_vertCount == null)
				{
					r_vertCount = new(this, "vertCount");
					r_vertCount.SetBelong(this.instance);
				}
				return r_vertCount;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 transform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_transform;
		public virtual RUnityEngine.RMatrix4x4 Rtransform
		{
			get
			{
				if(r_transform == null)
				{
					r_transform = new(this, "transform");
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// System.Int32 transformUVs
		/// </summary>
		protected RField r_transformUVs;
		public virtual RField RtransformUVs
		{
			get
			{
				if(r_transformUVs == null)
				{
					r_transformUVs = new(this, "transformUVs");
					r_transformUVs.SetBelong(this.instance);
				}
				return r_transformUVs;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 xformClipPages
		/// </summary>
		protected RUnityEngine.RColor32 r_xformClipPages;
		public virtual RUnityEngine.RColor32 RxformClipPages
		{
			get
			{
				if(r_xformClipPages == null)
				{
					r_xformClipPages = new(this, "xformClipPages");
					r_xformClipPages.SetBelong(this.instance);
				}
				return r_xformClipPages;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 ids
		/// </summary>
		protected RUnityEngine.RColor32 r_ids;
		public virtual RUnityEngine.RColor32 Rids
		{
			get
			{
				if(r_ids == null)
				{
					r_ids = new(this, "ids");
					r_ids.SetBelong(this.instance);
				}
				return r_ids;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 addFlags
		/// </summary>
		protected RUnityEngine.RColor32 r_addFlags;
		public virtual RUnityEngine.RColor32 RaddFlags
		{
			get
			{
				if(r_addFlags == null)
				{
					r_addFlags = new(this, "addFlags");
					r_addFlags.SetBelong(this.instance);
				}
				return r_addFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 opacityPage
		/// </summary>
		protected RUnityEngine.RColor32 r_opacityPage;
		public virtual RUnityEngine.RColor32 RopacityPage
		{
			get
			{
				if(r_opacityPage == null)
				{
					r_opacityPage = new(this, "opacityPage");
					r_opacityPage.SetBelong(this.instance);
				}
				return r_opacityPage;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 textCoreSettingsPage
		/// </summary>
		protected RUnityEngine.RColor32 r_textCoreSettingsPage;
		public virtual RUnityEngine.RColor32 RtextCoreSettingsPage
		{
			get
			{
				if(r_textCoreSettingsPage == null)
				{
					r_textCoreSettingsPage = new(this, "textCoreSettingsPage");
					r_textCoreSettingsPage.SetBelong(this.instance);
				}
				return r_textCoreSettingsPage;
			}
		}

		/// <summary>
		/// System.Int32 isText
		/// </summary>
		protected RField r_isText;
		public virtual RField RisText
		{
			get
			{
				if(r_isText == null)
				{
					r_isText = new(this, "isText");
					r_isText.SetBelong(this.instance);
				}
				return r_isText;
			}
		}

		/// <summary>
		/// System.Single textureId
		/// </summary>
		protected RField r_textureId;
		public virtual RField RtextureId
		{
			get
			{
				if(r_textureId == null)
				{
					r_textureId = new(this, "textureId");
					r_textureId.SetBelong(this.instance);
				}
				return r_textureId;
			}
		}

		/// <summary>
		/// System.IntPtr indexSrc
		/// </summary>
		protected RField r_indexSrc;
		public virtual RField RindexSrc
		{
			get
			{
				if(r_indexSrc == null)
				{
					r_indexSrc = new(this, "indexSrc");
					r_indexSrc.SetBelong(this.instance);
				}
				return r_indexSrc;
			}
		}

		/// <summary>
		/// System.IntPtr indexDst
		/// </summary>
		protected RField r_indexDst;
		public virtual RField RindexDst
		{
			get
			{
				if(r_indexDst == null)
				{
					r_indexDst = new(this, "indexDst");
					r_indexDst.SetBelong(this.instance);
				}
				return r_indexDst;
			}
		}

		/// <summary>
		/// System.Int32 indexCount
		/// </summary>
		protected RField r_indexCount;
		public virtual RField RindexCount
		{
			get
			{
				if(r_indexCount == null)
				{
					r_indexCount = new(this, "indexCount");
					r_indexCount.SetBelong(this.instance);
				}
				return r_indexCount;
			}
		}

		/// <summary>
		/// System.Int32 indexOffset
		/// </summary>
		protected RField r_indexOffset;
		public virtual RField RindexOffset
		{
			get
			{
				if(r_indexOffset == null)
				{
					r_indexOffset = new(this, "indexOffset");
					r_indexOffset.SetBelong(this.instance);
				}
				return r_indexOffset;
			}
		}

		/// <summary>
		/// System.Int32 flipIndices
		/// </summary>
		protected RField r_flipIndices;
		public virtual RField RflipIndices
		{
			get
			{
				if(r_flipIndices == null)
				{
					r_flipIndices = new(this, "flipIndices");
					r_flipIndices.SetBelong(this.instance);
				}
				return r_flipIndices;
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


        public RConvertMeshJobData() : base("UnityEngine.UIElements.UIR.ConvertMeshJobData")
        {
        }

        public RConvertMeshJobData(System.Object instance) : base("UnityEngine.UIElements.UIR.ConvertMeshJobData")
		{
            SetInstance(instance);
		}

        public RConvertMeshJobData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConvertMeshJobData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
