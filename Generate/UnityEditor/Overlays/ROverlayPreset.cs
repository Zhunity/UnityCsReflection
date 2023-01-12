using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
	/// UnityEditor.Overlays.OverlayPreset
	/// </summary>
    public partial class ROverlayPreset : RMember //
    {

		/// <summary>
		/// System.String m_RawWindowType
		/// </summary>
		protected RSystem.RString r_Fm_RawWindowType;
		public virtual RSystem.RString RFm_RawWindowType
		{
			get
			{
				if(r_Fm_RawWindowType == null)
				{
					r_Fm_RawWindowType = new(this, "m_RawWindowType");
					r_Fm_RawWindowType.SetBelong(this.instance);
				}
				return r_Fm_RawWindowType;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SaveData[] m_SaveData
		/// </summary>
		protected RFieldArray<RUnityEditor.ROverlays.RSaveData> r_Fm_SaveData;
		public virtual RFieldArray<RUnityEditor.ROverlays.RSaveData> RFm_SaveData
		{
			get
			{
				if(r_Fm_SaveData == null)
				{
					r_Fm_SaveData = new(this, "m_SaveData");
					r_Fm_SaveData.SetBelong(this.instance);
				}
				return r_Fm_SaveData;
			}
		}

		/// <summary>
		/// System.Type m_TargetType
		/// </summary>
		protected RSystem.RType r_Fm_TargetType;
		public virtual RSystem.RType RFm_TargetType
		{
			get
			{
				if(r_Fm_TargetType == null)
				{
					r_Fm_TargetType = new(this, "m_TargetType");
					r_Fm_TargetType.SetBelong(this.instance);
				}
				return r_Fm_TargetType;
			}
		}

		/// <summary>
		/// System.Type targetWindowType
		/// </summary>
		protected RSystem.RType r_PtargetWindowType;
		public virtual RSystem.RType RPtargetWindowType
		{
			get
			{
				if(r_PtargetWindowType == null)
				{
					r_PtargetWindowType = new(this, "targetWindowType", -1);
					r_PtargetWindowType.SetBelong(this.instance);
				}
				return r_PtargetWindowType;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SaveData[] saveData
		/// </summary>
		protected RPropertyArray<RUnityEditor.ROverlays.RSaveData> r_PsaveData;
		public virtual RPropertyArray<RUnityEditor.ROverlays.RSaveData> RPsaveData
		{
			get
			{
				if(r_PsaveData == null)
				{
					r_PsaveData = new(this, "saveData", -1);
					r_PsaveData.SetBelong(this.instance);
				}
				return r_PsaveData;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_Pname;
		public virtual RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RUnityEngine.RHideFlags r_PhideFlags;
		public virtual RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_MOnEnable;
		public virtual RMethod RMOnEnable
		{
			get
			{
				if(r_MOnEnable == null)
				{
					r_MOnEnable = new(this, "OnEnable", 0);
					r_MOnEnable.SetBelong(this.instance);
				}
				return r_MOnEnable;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_MOnBeforeSerialize.SetBelong(this.instance);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_MOnAfterDeserialize.SetBelong(this.instance);
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// Boolean CanApplyToWindow(System.Type)
		/// </summary>
		protected RMethod r_MCanApplyToWindow_Type;
		public virtual RMethod RMCanApplyToWindow_Type
		{
			get
			{
				if(r_MCanApplyToWindow_Type == null)
				{
					r_MCanApplyToWindow_Type = new(this, "CanApplyToWindow", 0, typeof(System.Type));
					r_MCanApplyToWindow_Type.SetBelong(this.instance);
				}
				return r_MCanApplyToWindow_Type;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
					r_MSetDirty.SetBelong(this.instance);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
					r_MGetInstanceID.SetBelong(this.instance);
				}
				return r_MGetInstanceID;
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


        public ROverlayPreset() : base("UnityEditor.Overlays.OverlayPreset")
        {
        }

        public ROverlayPreset(System.Object instance) : base("UnityEditor.Overlays.OverlayPreset")
		{
            SetInstance(instance);
		}

        public ROverlayPreset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public ROverlayPreset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanApplyToWindow(System.Type @windowType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowType};
            var ___result = RMCanApplyToWindow_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
