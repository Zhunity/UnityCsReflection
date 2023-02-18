
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.UndoRedoInfo
	/// </summary>
    public partial class RUndoRedoInfo : RMember //
    {

		/// <summary>
		/// System.String undoName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FundoName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFundoName
		{
			get
			{
				if(r_FundoName == null)
				{
					r_FundoName = new(this, "undoName");
					r_FundoName.SetBelong(this.GetValue());
				}
				return r_FundoName;
			}
		}

		/// <summary>
		/// System.Int32 undoGroup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FundoGroup;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFundoGroup
		{
			get
			{
				if(r_FundoGroup == null)
				{
					r_FundoGroup = new(this, "undoGroup");
					r_FundoGroup.SetBelong(this.GetValue());
				}
				return r_FundoGroup;
			}
		}

		/// <summary>
		/// System.Int32 m_IsRedo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_IsRedo;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_IsRedo
		{
			get
			{
				if(r_Fm_IsRedo == null)
				{
					r_Fm_IsRedo = new(this, "m_IsRedo");
					r_Fm_IsRedo.SetBelong(this.GetValue());
				}
				return r_Fm_IsRedo;
			}
		}

		/// <summary>
		/// Boolean isRedo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisRedo;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisRedo
		{
			get
			{
				if(r_PisRedo == null)
				{
					r_PisRedo = new(this, "isRedo", -1);
					r_PisRedo.SetBelong(this.GetValue());
				}
				return r_PisRedo;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RUndoRedoInfo() : base("UnityEditor.UndoRedoInfo")
        {
        }

        public RUndoRedoInfo(System.Object instance) : base("UnityEditor.UndoRedoInfo")
		{
            SetInstance(instance);
		}

        public RUndoRedoInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUndoRedoInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
