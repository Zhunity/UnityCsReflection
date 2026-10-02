
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation
{public partial class RUIRStylePainter
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+TempDataAlloc`1
	/// </summary>
    public partial class RTempDataAlloc<T> : RMember // where T : struct
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+TempDataAlloc`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RTempDataAlloc() : base("UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+TempDataAlloc`1")
        {
        }

        public RTempDataAlloc(System.Object instance) : base("UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+TempDataAlloc`1")
		{
            SetInstance(instance);
		}

        public RTempDataAlloc(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTempDataAlloc(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 maxPoolElemCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FmaxPoolElemCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmaxPoolElemCount
		{
			get
			{
				if(r_FmaxPoolElemCount == null)
				{
					r_FmaxPoolElemCount = new(this, "maxPoolElemCount");
				}
				return r_FmaxPoolElemCount;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] pool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RField> r_Fpool;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RField> RFpool
		{
			get
			{
				if(r_Fpool == null)
				{
					r_Fpool = new(this, "pool");
				}
				return r_Fpool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[Unity.Collections.NativeArray`1[T]] excess
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RField>> r_Fexcess;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RField>> RFexcess
		{
			get
			{
				if(r_Fexcess == null)
				{
					r_Fexcess = new(this, "excess");
				}
				return r_Fexcess;
			}
		}

		/// <summary>
		/// System.UInt32 takenFromPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FtakenFromPool;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFtakenFromPool
		{
			get
			{
				if(r_FtakenFromPool == null)
				{
					r_FtakenFromPool = new(this, "takenFromPool");
				}
				return r_FtakenFromPool;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[T] Alloc(UInt32)
		/// </summary>
		protected RMethod r_MAlloc_UInt32;
		public virtual RMethod RMAlloc_UInt32
		{
			get
			{
				if(r_MAlloc_UInt32 == null)
				{
					r_MAlloc_UInt32 = new(this, "Alloc", 0, typeof(System.UInt32));
				}
				return r_MAlloc_UInt32;
			}
		}

		/// <summary>
		/// Void SessionDone()
		/// </summary>
		protected RMethod r_MSessionDone;
		public virtual RMethod RMSessionDone
		{
			get
			{
				if(r_MSessionDone == null)
				{
					r_MSessionDone = new(this, "SessionDone", 0);
				}
				return r_MSessionDone;
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


		public virtual void Dispose()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMDispose.Invoke(___genericsType, ___parameters);
		}


		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType> Alloc(System.UInt32 @count)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@count};
			var ___result = RMAlloc_UInt32.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RType>>(___result);
		}


		public virtual void SessionDone()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMSessionDone.Invoke(___genericsType, ___parameters);
		}


		public virtual System.Boolean Equals(System.Object @obj)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@obj};
			var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual System.Int32 GetHashCode()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Int32>(___result);
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
}