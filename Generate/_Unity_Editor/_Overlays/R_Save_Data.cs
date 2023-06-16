
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.Overlays.SaveData
	/// </summary>
    public partial class RSaveData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData");
            }
        }

        public RSaveData() : base("UnityEditor.Overlays.SaveData")
        {
        }

        public RSaveData(System.Object instance) : base("UnityEditor.Overlays.SaveData")
		{
            SetInstance(instance);
		}

        public RSaveData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSaveData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 k_InvalidIndex
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_InvalidIndex;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_InvalidIndex
		{
			get
			{
				if(r_Fk_InvalidIndex == null)
				{
					r_Fk_InvalidIndex = new(Type, "k_InvalidIndex");
				}
				return r_Fk_InvalidIndex;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition dockPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockPosition r_FdockPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockPosition RFdockPosition
		{
			get
			{
				if(r_FdockPosition == null)
				{
					r_FdockPosition = new(this, "dockPosition");
				}
				return r_FdockPosition;
			}
		}

		/// <summary>
		/// System.String containerId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FcontainerId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFcontainerId
		{
			get
			{
				if(r_FcontainerId == null)
				{
					r_FcontainerId = new(this, "containerId");
				}
				return r_FcontainerId;
			}
		}

		/// <summary>
		/// System.Boolean floating
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Ffloating;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFfloating
		{
			get
			{
				if(r_Ffloating == null)
				{
					r_Ffloating = new(this, "floating");
				}
				return r_Ffloating;
			}
		}

		/// <summary>
		/// System.Boolean collapsed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fcollapsed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFcollapsed
		{
			get
			{
				if(r_Fcollapsed == null)
				{
					r_Fcollapsed = new(this, "collapsed");
				}
				return r_Fcollapsed;
			}
		}

		/// <summary>
		/// System.Boolean displayed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fdisplayed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFdisplayed
		{
			get
			{
				if(r_Fdisplayed == null)
				{
					r_Fdisplayed = new(this, "displayed");
				}
				return r_Fdisplayed;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 snapOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FsnapOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFsnapOffset
		{
			get
			{
				if(r_FsnapOffset == null)
				{
					r_FsnapOffset = new(this, "snapOffset");
				}
				return r_FsnapOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 snapOffsetDelta
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FsnapOffsetDelta;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFsnapOffsetDelta
		{
			get
			{
				if(r_FsnapOffsetDelta == null)
				{
					r_FsnapOffsetDelta = new(this, "snapOffsetDelta");
				}
				return r_FsnapOffsetDelta;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SnapCorner snapCorner
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSnapCorner r_FsnapCorner;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSnapCorner RFsnapCorner
		{
			get
			{
				if(r_FsnapCorner == null)
				{
					r_FsnapCorner = new(this, "snapCorner");
				}
				return r_FsnapCorner;
			}
		}

		/// <summary>
		/// System.String id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fid;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFid
		{
			get
			{
				if(r_Fid == null)
				{
					r_Fid = new(this, "id");
				}
				return r_Fid;
			}
		}

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Findex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFindex
		{
			get
			{
				if(r_Findex == null)
				{
					r_Findex = new(this, "index");
				}
				return r_Findex;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout layout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout r_Flayout;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout RFlayout
		{
			get
			{
				if(r_Flayout == null)
				{
					r_Flayout = new(this, "layout");
				}
				return r_Flayout;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 size
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fsize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFsize
		{
			get
			{
				if(r_Fsize == null)
				{
					r_Fsize = new(this, "size");
				}
				return r_Fsize;
			}
		}

		/// <summary>
		/// System.Boolean sizeOverriden
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FsizeOverriden;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFsizeOverriden
		{
			get
			{
				if(r_FsizeOverriden == null)
				{
					r_FsizeOverriden = new(this, "sizeOverriden");
				}
				return r_FsizeOverriden;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEditor.Overlays.SaveData)
		/// </summary>
		protected RMethod r_MEquals_SaveData;
		public virtual RMethod RMEquals_SaveData
		{
			get
			{
				if(r_MEquals_SaveData == null)
				{
					r_MEquals_SaveData = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData"));
				}
				return r_MEquals_SaveData;
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


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_SaveData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
