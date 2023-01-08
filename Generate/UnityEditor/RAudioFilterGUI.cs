using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.AudioFilterGUI
	/// </summary>
    public partial class RAudioFilterGUI : RMember //
    {

		/// <summary>
		/// UnityEditor.EditorGUI+VUMeter+SmoothingData[] dataOut
		/// </summary>
		protected RFieldArray<RUnityEditor.REditorGUI.RVUMeter.RSmoothingData> r_dataOut;
		public virtual RFieldArray<RUnityEditor.REditorGUI.RVUMeter.RSmoothingData> RdataOut
		{
			get
			{
				if(r_dataOut == null)
				{
					r_dataOut = new(this, "dataOut");
					r_dataOut.SetBelong(this.instance);
				}
				return r_dataOut;
			}
		}

		/// <summary>
		/// Void DrawAudioFilterGUI(UnityEngine.MonoBehaviour)
		/// </summary>
		protected RMethod r_DrawAudioFilterGUI_MonoBehaviour;
		public virtual RMethod RDrawAudioFilterGUI_MonoBehaviour
		{
			get
			{
				if(r_DrawAudioFilterGUI_MonoBehaviour == null)
				{
					r_DrawAudioFilterGUI_MonoBehaviour = new(this, "DrawAudioFilterGUI", 0, typeof(UnityEngine.MonoBehaviour));
					r_DrawAudioFilterGUI_MonoBehaviour.SetBelong(this.instance);
				}
				return r_DrawAudioFilterGUI_MonoBehaviour;
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


        public RAudioFilterGUI() : base("UnityEditor.AudioFilterGUI")
        {
        }

        public RAudioFilterGUI(System.Object instance) : base("UnityEditor.AudioFilterGUI")
		{
            SetInstance(instance);
		}

        public RAudioFilterGUI(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAudioFilterGUI(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void DrawAudioFilterGUI(UnityEngine.MonoBehaviour @behaviour)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@behaviour};
            var ___result = RDrawAudioFilterGUI_MonoBehaviour.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
