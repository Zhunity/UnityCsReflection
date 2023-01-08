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
		protected RField r_m_RawWindowType;
		public virtual RField Rm_RawWindowType
		{
			get
			{
				if(r_m_RawWindowType == null)
				{
					r_m_RawWindowType = new(this, "m_RawWindowType");
					r_m_RawWindowType.SetBelong(this.instance);
				}
				return r_m_RawWindowType;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SaveData[] m_SaveData
		/// </summary>
		protected RFieldArray<RUnityEditor.ROverlays.RSaveData> r_m_SaveData;
		public virtual RFieldArray<RUnityEditor.ROverlays.RSaveData> Rm_SaveData
		{
			get
			{
				if(r_m_SaveData == null)
				{
					r_m_SaveData = new(this, "m_SaveData");
					r_m_SaveData.SetBelong(this.instance);
				}
				return r_m_SaveData;
			}
		}

		/// <summary>
		/// System.Type m_TargetType
		/// </summary>
		protected RSystem.RType r_m_TargetType;
		public virtual RSystem.RType Rm_TargetType
		{
			get
			{
				if(r_m_TargetType == null)
				{
					r_m_TargetType = new(this, "m_TargetType");
					r_m_TargetType.SetBelong(this.instance);
				}
				return r_m_TargetType;
			}
		}

		/// <summary>
		/// System.Type targetWindowType
		/// </summary>
		protected RSystem.RType r_targetWindowType;
		public virtual RSystem.RType RtargetWindowType
		{
			get
			{
				if(r_targetWindowType == null)
				{
					r_targetWindowType = new(this, "targetWindowType", -1);
					r_targetWindowType.SetBelong(this.instance);
				}
				return r_targetWindowType;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SaveData[] saveData
		/// </summary>
		protected RPropertyArray<RUnityEditor.ROverlays.RSaveData> r_saveData;
		public virtual RPropertyArray<RUnityEditor.ROverlays.RSaveData> RsaveData
		{
			get
			{
				if(r_saveData == null)
				{
					r_saveData = new(this, "saveData", -1);
					r_saveData.SetBelong(this.instance);
				}
				return r_saveData;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_OnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_OnEnable == null)
				{
					r_OnEnable = new(this, "OnEnable", 0);
					r_OnEnable.SetBelong(this.instance);
				}
				return r_OnEnable;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_OnBeforeSerialize;
		public virtual RMethod ROnBeforeSerialize
		{
			get
			{
				if(r_OnBeforeSerialize == null)
				{
					r_OnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_OnBeforeSerialize.SetBelong(this.instance);
				}
				return r_OnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_OnAfterDeserialize;
		public virtual RMethod ROnAfterDeserialize
		{
			get
			{
				if(r_OnAfterDeserialize == null)
				{
					r_OnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_OnAfterDeserialize.SetBelong(this.instance);
				}
				return r_OnAfterDeserialize;
			}
		}

		/// <summary>
		/// Boolean CanApplyToWindow(System.Type)
		/// </summary>
		protected RMethod r_CanApplyToWindow_Type;
		public virtual RMethod RCanApplyToWindow_Type
		{
			get
			{
				if(r_CanApplyToWindow_Type == null)
				{
					r_CanApplyToWindow_Type = new(this, "CanApplyToWindow", 0, typeof(System.Type));
					r_CanApplyToWindow_Type.SetBelong(this.instance);
				}
				return r_CanApplyToWindow_Type;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_SetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_SetDirty == null)
				{
					r_SetDirty = new(this, "SetDirty", 0);
					r_SetDirty.SetBelong(this.instance);
				}
				return r_SetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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
            var ___result = ROnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanApplyToWindow(System.Type @windowType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowType};
            var ___result = RCanApplyToWindow_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
