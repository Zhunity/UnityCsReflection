
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.RectOffset
	/// </summary>
    public partial class RRectOffset : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
					r_Fm_Ptr.SetBelong(this.instance);
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// System.Object m_SourceStyle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_Fm_SourceStyle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RFm_SourceStyle
		{
			get
			{
				if(r_Fm_SourceStyle == null)
				{
					r_Fm_SourceStyle = new(this, "m_SourceStyle");
					r_Fm_SourceStyle.SetBelong(this.instance);
				}
				return r_Fm_SourceStyle;
			}
		}

		/// <summary>
		/// Int32 left
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Pleft;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(this, "left", -1);
					r_Pleft.SetBelong(this.instance);
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// Int32 right
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Pright;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(this, "right", -1);
					r_Pright.SetBelong(this.instance);
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// Int32 top
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ptop;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPtop
		{
			get
			{
				if(r_Ptop == null)
				{
					r_Ptop = new(this, "top", -1);
					r_Ptop.SetBelong(this.instance);
				}
				return r_Ptop;
			}
		}

		/// <summary>
		/// Int32 bottom
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Pbottom;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPbottom
		{
			get
			{
				if(r_Pbottom == null)
				{
					r_Pbottom = new(this, "bottom", -1);
					r_Pbottom.SetBelong(this.instance);
				}
				return r_Pbottom;
			}
		}

		/// <summary>
		/// Int32 horizontal
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Phorizontal;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPhorizontal
		{
			get
			{
				if(r_Phorizontal == null)
				{
					r_Phorizontal = new(this, "horizontal", -1);
					r_Phorizontal.SetBelong(this.instance);
				}
				return r_Phorizontal;
			}
		}

		/// <summary>
		/// Int32 vertical
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Pvertical;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPvertical
		{
			get
			{
				if(r_Pvertical == null)
				{
					r_Pvertical = new(this, "vertical", -1);
					r_Pvertical.SetBelong(this.instance);
				}
				return r_Pvertical;
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
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
					r_MToString_String.SetBelong(this.instance);
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Void Destroy()
		/// </summary>
		protected RMethod r_MDestroy;
		public virtual RMethod RMDestroy
		{
			get
			{
				if(r_MDestroy == null)
				{
					r_MDestroy = new(this, "Destroy", 0);
					r_MDestroy.SetBelong(this.instance);
				}
				return r_MDestroy;
			}
		}

		/// <summary>
		/// IntPtr InternalCreate()
		/// </summary>
		protected static RMethod r_MInternalCreate;
		public static RMethod RMInternalCreate
		{
			get
			{
				if(r_MInternalCreate == null)
				{
					r_MInternalCreate = new(typeof(UnityEngine.RectOffset), "InternalCreate", 0);
					r_MInternalCreate.SetBelong(null);
				}
				return r_MInternalCreate;
			}
		}

		/// <summary>
		/// Void InternalDestroy(IntPtr)
		/// </summary>
		protected static RMethod r_MInternalDestroy_IntPtr;
		public static RMethod RMInternalDestroy_IntPtr
		{
			get
			{
				if(r_MInternalDestroy_IntPtr == null)
				{
					r_MInternalDestroy_IntPtr = new(typeof(UnityEngine.RectOffset), "InternalDestroy", 0, typeof(System.IntPtr));
					r_MInternalDestroy_IntPtr.SetBelong(null);
				}
				return r_MInternalDestroy_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rect Add(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MAdd_Rect;
		public virtual RMethod RMAdd_Rect
		{
			get
			{
				if(r_MAdd_Rect == null)
				{
					r_MAdd_Rect = new(this, "Add", 0, typeof(UnityEngine.Rect));
					r_MAdd_Rect.SetBelong(this.instance);
				}
				return r_MAdd_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect Remove(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MRemove_Rect;
		public virtual RMethod RMRemove_Rect
		{
			get
			{
				if(r_MRemove_Rect == null)
				{
					r_MRemove_Rect = new(this, "Remove", 0, typeof(UnityEngine.Rect));
					r_MRemove_Rect.SetBelong(this.instance);
				}
				return r_MRemove_Rect;
			}
		}

		/// <summary>
		/// Void Add_Injected(UnityEngine.Rect ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MAdd_Injected_Ref_Rect_Out_Rect;
		public virtual RMethod RMAdd_Injected_Ref_Rect_Out_Rect
		{
			get
			{
				if(r_MAdd_Injected_Ref_Rect_Out_Rect == null)
				{
					r_MAdd_Injected_Ref_Rect_Out_Rect = new(this, "Add_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_MAdd_Injected_Ref_Rect_Out_Rect.SetBelong(this.instance);
				}
				return r_MAdd_Injected_Ref_Rect_Out_Rect;
			}
		}

		/// <summary>
		/// Void Remove_Injected(UnityEngine.Rect ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MRemove_Injected_Ref_Rect_Out_Rect;
		public virtual RMethod RMRemove_Injected_Ref_Rect_Out_Rect
		{
			get
			{
				if(r_MRemove_Injected_Ref_Rect_Out_Rect == null)
				{
					r_MRemove_Injected_Ref_Rect_Out_Rect = new(this, "Remove_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_MRemove_Injected_Ref_Rect_Out_Rect.SetBelong(this.instance);
				}
				return r_MRemove_Injected_Ref_Rect_Out_Rect;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public RRectOffset() : base("UnityEngine.RectOffset")
        {
        }

        public RRectOffset(System.Object instance) : base("UnityEngine.RectOffset")
		{
            SetInstance(instance);
		}

        public RRectOffset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRectOffset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Destroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr InternalCreate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalCreate.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void InternalDestroy(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMInternalDestroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect Add(UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RMAdd_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Rect Remove(UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RMRemove_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Add_Injected(ref UnityEngine.Rect @rect, out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @ret};
            var ___result = RMAdd_Injected_Ref_Rect_Out_Rect.Invoke(___genericsType, ___parameters);
			@rect = (UnityEngine.Rect)___parameters[0];
			@ret = (UnityEngine.Rect)___parameters[1];

            
        }


        public virtual void Remove_Injected(ref UnityEngine.Rect @rect, out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @ret};
            var ___result = RMRemove_Injected_Ref_Rect_Out_Rect.Invoke(___genericsType, ___parameters);
			@rect = (UnityEngine.Rect)___parameters[0];
			@ret = (UnityEngine.Rect)___parameters[1];

            
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
