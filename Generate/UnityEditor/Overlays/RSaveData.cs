using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
	/// UnityEditor.Overlays.SaveData
	/// </summary>
    public partial class RSaveData : RMember //
    {

		/// <summary>
		/// System.Int32 k_InvalidIndex
		/// </summary>
		protected static RField r_k_InvalidIndex;
		public static RField Rk_InvalidIndex
		{
			get
			{
				if(r_k_InvalidIndex == null)
				{
					r_k_InvalidIndex = new( ReflectionUtils.GetType("UnityEditor.Overlays.SaveData"), "k_InvalidIndex");
					r_k_InvalidIndex.SetBelong(null);
				}
				return r_k_InvalidIndex;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition dockPosition
		/// </summary>
		protected RField r_dockPosition;
		public virtual RField RdockPosition
		{
			get
			{
				if(r_dockPosition == null)
				{
					r_dockPosition = new(this, "dockPosition");
					r_dockPosition.SetBelong(this.instance);
				}
				return r_dockPosition;
			}
		}

		/// <summary>
		/// System.String containerId
		/// </summary>
		protected RField r_containerId;
		public virtual RField RcontainerId
		{
			get
			{
				if(r_containerId == null)
				{
					r_containerId = new(this, "containerId");
					r_containerId.SetBelong(this.instance);
				}
				return r_containerId;
			}
		}

		/// <summary>
		/// System.Boolean floating
		/// </summary>
		protected RField r_floating;
		public virtual RField Rfloating
		{
			get
			{
				if(r_floating == null)
				{
					r_floating = new(this, "floating");
					r_floating.SetBelong(this.instance);
				}
				return r_floating;
			}
		}

		/// <summary>
		/// System.Boolean collapsed
		/// </summary>
		protected RField r_collapsed;
		public virtual RField Rcollapsed
		{
			get
			{
				if(r_collapsed == null)
				{
					r_collapsed = new(this, "collapsed");
					r_collapsed.SetBelong(this.instance);
				}
				return r_collapsed;
			}
		}

		/// <summary>
		/// System.Boolean displayed
		/// </summary>
		protected RField r_displayed;
		public virtual RField Rdisplayed
		{
			get
			{
				if(r_displayed == null)
				{
					r_displayed = new(this, "displayed");
					r_displayed.SetBelong(this.instance);
				}
				return r_displayed;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 snapOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_snapOffset;
		public virtual RUnityEngine.RVector2 RsnapOffset
		{
			get
			{
				if(r_snapOffset == null)
				{
					r_snapOffset = new(this, "snapOffset");
					r_snapOffset.SetBelong(this.instance);
				}
				return r_snapOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 snapOffsetDelta
		/// </summary>
		protected RUnityEngine.RVector2 r_snapOffsetDelta;
		public virtual RUnityEngine.RVector2 RsnapOffsetDelta
		{
			get
			{
				if(r_snapOffsetDelta == null)
				{
					r_snapOffsetDelta = new(this, "snapOffsetDelta");
					r_snapOffsetDelta.SetBelong(this.instance);
				}
				return r_snapOffsetDelta;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SnapCorner snapCorner
		/// </summary>
		protected RField r_snapCorner;
		public virtual RField RsnapCorner
		{
			get
			{
				if(r_snapCorner == null)
				{
					r_snapCorner = new(this, "snapCorner");
					r_snapCorner.SetBelong(this.instance);
				}
				return r_snapCorner;
			}
		}

		/// <summary>
		/// System.String id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected RField r_index;
		public virtual RField Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout layout
		/// </summary>
		protected RField r_layout;
		public virtual RField Rlayout
		{
			get
			{
				if(r_layout == null)
				{
					r_layout = new(this, "layout");
					r_layout.SetBelong(this.instance);
				}
				return r_layout;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 size
		/// </summary>
		protected RUnityEngine.RVector2 r_size;
		public virtual RUnityEngine.RVector2 Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size");
					r_size.SetBelong(this.instance);
				}
				return r_size;
			}
		}

		/// <summary>
		/// System.Boolean sizeOverriden
		/// </summary>
		protected RField r_sizeOverriden;
		public virtual RField RsizeOverriden
		{
			get
			{
				if(r_sizeOverriden == null)
				{
					r_sizeOverriden = new(this, "sizeOverriden");
					r_sizeOverriden.SetBelong(this.instance);
				}
				return r_sizeOverriden;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEditor.Overlays.SaveData)
		/// </summary>
		protected RMethod r_Equals_SaveData;
		public virtual RMethod REquals_SaveData
		{
			get
			{
				if(r_Equals_SaveData == null)
				{
					r_Equals_SaveData = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData"));
					r_Equals_SaveData.SetBelong(this.instance);
				}
				return r_Equals_SaveData;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
