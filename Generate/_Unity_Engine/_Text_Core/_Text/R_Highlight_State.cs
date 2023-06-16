
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextCore.Text.HighlightState
	/// </summary>
    public partial class RHighlightState : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.TextCore.Text.HighlightState");
            }
        }

        public RHighlightState() : base("UnityEngine.TextCore.Text.HighlightState")
        {
        }

        public RHighlightState(System.Object instance) : base("UnityEngine.TextCore.Text.HighlightState")
		{
            SetInstance(instance);
		}

        public RHighlightState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHighlightState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Color32 color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_Fcolor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
				}
				return r_Fcolor;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Offset padding
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset r_Fpadding;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset RFpadding
		{
			get
			{
				if(r_Fpadding == null)
				{
					r_Fpadding = new(this, "padding");
				}
				return r_Fpadding;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.Text.HighlightState, UnityEngine.TextCore.Text.HighlightState)
		/// </summary>
		protected static RMethod r_Mop_Equality_HighlightState_HighlightState;
		public static RMethod RMop_Equality_HighlightState_HighlightState
		{
			get
			{
				if(r_Mop_Equality_HighlightState_HighlightState == null)
				{
					r_Mop_Equality_HighlightState_HighlightState = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"),  ReflectionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"));
				}
				return r_Mop_Equality_HighlightState_HighlightState;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.Text.HighlightState, UnityEngine.TextCore.Text.HighlightState)
		/// </summary>
		protected static RMethod r_Mop_Inequality_HighlightState_HighlightState;
		public static RMethod RMop_Inequality_HighlightState_HighlightState
		{
			get
			{
				if(r_Mop_Inequality_HighlightState_HighlightState == null)
				{
					r_Mop_Inequality_HighlightState_HighlightState = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"),  ReflectionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"));
				}
				return r_Mop_Inequality_HighlightState_HighlightState;
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
		/// Boolean Equals(UnityEngine.TextCore.Text.HighlightState)
		/// </summary>
		protected RMethod r_MEquals_HighlightState;
		public virtual RMethod RMEquals_HighlightState
		{
			get
			{
				if(r_MEquals_HighlightState == null)
				{
					r_MEquals_HighlightState = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"));
				}
				return r_MEquals_HighlightState;
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


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RHighlightState @lhs, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RHighlightState @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_HighlightState_HighlightState.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RHighlightState @lhs, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RHighlightState @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_HighlightState_HighlightState.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RHighlightState @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_HighlightState.Invoke(___genericsType, ___parameters);

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
