
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.LocalBuilder
	/// </summary>
    public partial class RLocalBuilder : RMember //
    {

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
					r_Fname.SetBelong(this.instance);
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator ilgen
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILGenerator r_Filgen;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILGenerator RFilgen
		{
			get
			{
				if(r_Filgen == null)
				{
					r_Filgen = new(this, "ilgen");
					r_Filgen.SetBelong(this.instance);
				}
				return r_Filgen;
			}
		}

		/// <summary>
		/// System.Int32 startOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FstartOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFstartOffset
		{
			get
			{
				if(r_FstartOffset == null)
				{
					r_FstartOffset = new(this, "startOffset");
					r_FstartOffset.SetBelong(this.instance);
				}
				return r_FstartOffset;
			}
		}

		/// <summary>
		/// System.Int32 endOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FendOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFendOffset
		{
			get
			{
				if(r_FendOffset == null)
				{
					r_FendOffset = new(this, "endOffset");
					r_FendOffset.SetBelong(this.instance);
				}
				return r_FendOffset;
			}
		}

		/// <summary>
		/// System.Type type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_Ftype;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
					r_Ftype.SetBelong(this.instance);
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.Boolean is_pinned
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fis_pinned;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFis_pinned
		{
			get
			{
				if(r_Fis_pinned == null)
				{
					r_Fis_pinned = new(this, "is_pinned");
					r_Fis_pinned.SetBelong(this.instance);
				}
				return r_Fis_pinned;
			}
		}

		/// <summary>
		/// System.UInt16 position
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt16 r_Fposition;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt16 RFposition
		{
			get
			{
				if(r_Fposition == null)
				{
					r_Fposition = new(this, "position");
					r_Fposition.SetBelong(this.instance);
				}
				return r_Fposition;
			}
		}

		/// <summary>
		/// System.Type LocalType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PLocalType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPLocalType
		{
			get
			{
				if(r_PLocalType == null)
				{
					r_PLocalType = new(this, "LocalType", -1);
					r_PLocalType.SetBelong(this.instance);
				}
				return r_PLocalType;
			}
		}

		/// <summary>
		/// Boolean IsPinned
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsPinned;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsPinned
		{
			get
			{
				if(r_PIsPinned == null)
				{
					r_PIsPinned = new(this, "IsPinned", -1);
					r_PIsPinned.SetBelong(this.instance);
				}
				return r_PIsPinned;
			}
		}

		/// <summary>
		/// Int32 LocalIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PLocalIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPLocalIndex
		{
			get
			{
				if(r_PLocalIndex == null)
				{
					r_PLocalIndex = new(this, "LocalIndex", -1);
					r_PLocalIndex.SetBelong(this.instance);
				}
				return r_PLocalIndex;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// Int32 StartOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PStartOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPStartOffset
		{
			get
			{
				if(r_PStartOffset == null)
				{
					r_PStartOffset = new(this, "StartOffset", -1);
					r_PStartOffset.SetBelong(this.instance);
				}
				return r_PStartOffset;
			}
		}

		/// <summary>
		/// Int32 EndOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PEndOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPEndOffset
		{
			get
			{
				if(r_PEndOffset == null)
				{
					r_PEndOffset = new(this, "EndOffset", -1);
					r_PEndOffset.SetBelong(this.instance);
				}
				return r_PEndOffset;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._LocalBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._LocalBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._LocalBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._LocalBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._LocalBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._LocalBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._LocalBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._LocalBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void SetLocalSymInfo(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetLocalSymInfo_String_Int32_Int32;
		public virtual RMethod RMSetLocalSymInfo_String_Int32_Int32
		{
			get
			{
				if(r_MSetLocalSymInfo_String_Int32_Int32 == null)
				{
					r_MSetLocalSymInfo_String_Int32_Int32 = new(this, "SetLocalSymInfo", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MSetLocalSymInfo_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetLocalSymInfo_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetLocalSymInfo(System.String)
		/// </summary>
		protected RMethod r_MSetLocalSymInfo_String;
		public virtual RMethod RMSetLocalSymInfo_String
		{
			get
			{
				if(r_MSetLocalSymInfo_String == null)
				{
					r_MSetLocalSymInfo_String = new(this, "SetLocalSymInfo", 0, typeof(System.String));
					r_MSetLocalSymInfo_String.SetBelong(this.instance);
				}
				return r_MSetLocalSymInfo_String;
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


        public RLocalBuilder() : base("System.Reflection.Emit.LocalBuilder")
        {
        }

        public RLocalBuilder(System.Object instance) : base("System.Reflection.Emit.LocalBuilder")
		{
            SetInstance(instance);
		}

        public RLocalBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLocalBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___LocalBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___LocalBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLocalSymInfo(System.String @name, System.Int32 @startOffset, System.Int32 @endOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @startOffset, @endOffset};
            var ___result = RMSetLocalSymInfo_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLocalSymInfo(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMSetLocalSymInfo_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
