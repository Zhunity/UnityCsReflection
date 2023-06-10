
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.VisualState
	/// </summary>
    public partial class RVisualState : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.VisualState");
            }
        }

        public RVisualState() : base("UnityEditor.PackageManager.UI.Internal.VisualState")
        {
        }

        public RVisualState(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.VisualState")
		{
            SetInstance(instance);
		}

        public RVisualState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String packageUniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpackageUniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpackageUniqueId
		{
			get
			{
				if(r_FpackageUniqueId == null)
				{
					r_FpackageUniqueId = new(this, "packageUniqueId");
				}
				return r_FpackageUniqueId;
			}
		}

		/// <summary>
		/// System.String groupName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FgroupName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFgroupName
		{
			get
			{
				if(r_FgroupName == null)
				{
					r_FgroupName = new(this, "groupName");
				}
				return r_FgroupName;
			}
		}

		/// <summary>
		/// System.Boolean visible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fvisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFvisible
		{
			get
			{
				if(r_Fvisible == null)
				{
					r_Fvisible = new(this, "visible");
				}
				return r_Fvisible;
			}
		}

		/// <summary>
		/// System.Boolean lockedByDefault
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FlockedByDefault;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFlockedByDefault
		{
			get
			{
				if(r_FlockedByDefault == null)
				{
					r_FlockedByDefault = new(this, "lockedByDefault");
				}
				return r_FlockedByDefault;
			}
		}

		/// <summary>
		/// System.Boolean userUnlocked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FuserUnlocked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFuserUnlocked
		{
			get
			{
				if(r_FuserUnlocked == null)
				{
					r_FuserUnlocked = new(this, "userUnlocked");
				}
				return r_FuserUnlocked;
			}
		}

		/// <summary>
		/// Boolean isLocked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisLocked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisLocked
		{
			get
			{
				if(r_PisLocked == null)
				{
					r_PisLocked = new(this, "isLocked", -1);
				}
				return r_PisLocked;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEditor.PackageManager.UI.Internal.VisualState)
		/// </summary>
		protected RMethod r_MEquals_VisualState;
		public virtual RMethod RMEquals_VisualState
		{
			get
			{
				if(r_MEquals_VisualState == null)
				{
					r_MEquals_VisualState = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.VisualState"));
				}
				return r_MEquals_VisualState;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.VisualState Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
				}
				return r_MClone;
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


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_VisualState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
