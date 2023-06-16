
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.UIElements.SerializableJsonDictionary
	/// </summary>
    public partial class RSerializableJsonDictionary : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.UIElements.SerializableJsonDictionary");
            }
        }

        public RSerializableJsonDictionary() : base("UnityEditor.UIElements.SerializableJsonDictionary")
        {
        }

        public RSerializableJsonDictionary(System.Object instance) : base("UnityEditor.UIElements.SerializableJsonDictionary")
		{
            SetInstance(instance);
		}

        public RSerializableJsonDictionary(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSerializableJsonDictionary(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_Keys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Keys;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_Keys
		{
			get
			{
				if(r_Fm_Keys == null)
				{
					r_Fm_Keys = new(this, "m_Keys");
				}
				return r_Fm_Keys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Values;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_Values
		{
			get
			{
				if(r_Fm_Values == null)
				{
					r_Fm_Values = new(this, "m_Values");
				}
				return r_Fm_Values;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] m_Dict
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RObject> r_Fm_Dict;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RObject> RFm_Dict
		{
			get
			{
				if(r_Fm_Dict == null)
				{
					r_Fm_Dict = new(this, "m_Dict");
				}
				return r_Fm_Dict;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void Set[T](System.String, T)
		/// </summary>
		protected RMethod r_MSet_GT_String_T;
		public virtual RMethod RMSet_GT_String_T
		{
			get
			{
				if(r_MSet_GT_String_T == null)
				{
					r_MSet_GT_String_T = new(this, "Set", 1, typeof(System.String), Type.MakeGenericMethodParameter(0));
				}
				return r_MSet_GT_String_T;
			}
		}

		/// <summary>
		/// T Get[T](System.String)
		/// </summary>
		protected RMethod r_MGet_GT_String;
		public virtual RMethod RMGet_GT_String
		{
			get
			{
				if(r_MGet_GT_String == null)
				{
					r_MGet_GT_String = new(this, "Get", 1, typeof(System.String));
				}
				return r_MGet_GT_String;
			}
		}

		/// <summary>
		/// T GetScriptable[T](System.String)
		/// </summary>
		protected RMethod r_MGetScriptable_GT_String;
		public virtual RMethod RMGetScriptable_GT_String
		{
			get
			{
				if(r_MGetScriptable_GT_String == null)
				{
					r_MGetScriptable_GT_String = new(this, "GetScriptable", 1, typeof(System.String));
				}
				return r_MGetScriptable_GT_String;
			}
		}

		/// <summary>
		/// Void Overwrite(System.Object, System.String)
		/// </summary>
		protected RMethod r_MOverwrite_Object_String;
		public virtual RMethod RMOverwrite_Object_String
		{
			get
			{
				if(r_MOverwrite_Object_String == null)
				{
					r_MOverwrite_Object_String = new(this, "Overwrite", 0, typeof(System.Object), typeof(System.String));
				}
				return r_MOverwrite_Object_String;
			}
		}

		/// <summary>
		/// Boolean ContainsKey(System.String)
		/// </summary>
		protected RMethod r_MContainsKey_String;
		public virtual RMethod RMContainsKey_String
		{
			get
			{
				if(r_MContainsKey_String == null)
				{
					r_MContainsKey_String = new(this, "ContainsKey", 0, typeof(System.String));
				}
				return r_MContainsKey_String;
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
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// System.String <OnAfterDeserialize>b__9_0(Int32)
		/// </summary>
		protected RMethod r_M__0__OnAfterDeserialize__1__b__9_0_Int32;
		public virtual RMethod RM__0__OnAfterDeserialize__1__b__9_0_Int32
		{
			get
			{
				if(r_M__0__OnAfterDeserialize__1__b__9_0_Int32 == null)
				{
					r_M__0__OnAfterDeserialize__1__b__9_0_Int32 = new(this, "<OnAfterDeserialize>b__9_0", 0, typeof(System.Int32));
				}
				return r_M__0__OnAfterDeserialize__1__b__9_0_Int32;
			}
		}

		/// <summary>
		/// System.Object <OnAfterDeserialize>b__9_1(Int32)
		/// </summary>
		protected RMethod r_M__0__OnAfterDeserialize__1__b__9_1_Int32;
		public virtual RMethod RM__0__OnAfterDeserialize__1__b__9_1_Int32
		{
			get
			{
				if(r_M__0__OnAfterDeserialize__1__b__9_1_Int32 == null)
				{
					r_M__0__OnAfterDeserialize__1__b__9_1_Int32 = new(this, "<OnAfterDeserialize>b__9_1", 0, typeof(System.Int32));
				}
				return r_M__0__OnAfterDeserialize__1__b__9_1_Int32;
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


        public virtual void Set<T>(System.String @key, T @value) where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMSet_GT_String_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T Get<T>(System.String @key) where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@key};
            var ___result = RMGet_GT_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual T GetScriptable<T>(System.String @key) where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@key};
            var ___result = RMGetScriptable_GT_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual void Overwrite(System.Object @obj, System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @key};
            var ___result = RMOverwrite_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsKey(System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMContainsKey_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual System.String __0__OnAfterDeserialize__1__b__9_0(System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RM__0__OnAfterDeserialize__1__b__9_0_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Object __0__OnAfterDeserialize__1__b__9_1(System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RM__0__OnAfterDeserialize__1__b__9_1_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

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
