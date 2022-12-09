using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSMFrame.REditor.RRefleaction
{
    public partial class RATestGenericMethod : RMember
    {

		/// <summary>
		/// System.Int32
		/// </summary>
		protected static RField r_qeqwe;
		public static RField qeqwe
		{
			get
			{
				if(r_qeqwe == null)
				{
					r_qeqwe = new RField( ReleactionUtils.GetType("SMFrame.Editor.Refleaction.ATestGenericMethod"), "qeqwe");
					r_qeqwe.SetBelong(null);
				}
				return r_qeqwe;
			}
		}

		/// <summary>
		/// System.String
		/// </summary>
		protected RField r_sdfsdf;
		public virtual RField sdfsdf
		{
			get
			{
				if(r_sdfsdf == null)
				{
					r_sdfsdf = new RField(this, "sdfsdf");
					r_sdfsdf.SetBelong(this.instance);
				}
				return r_sdfsdf;
			}
		}

		/// <summary>
		/// Single N[T](Int32, T ByRef, Single ByRef, Int64 ByRef, Boolean[][][])
		/// </summary>
		protected static RMethod r_RN_GT_Int32_Out_T_Ref_Single_In_Int64_BooleanArrayArrayArray;
		public static RMethod RN_GT_Int32_Out_T_Ref_Single_In_Int64_BooleanArrayArrayArray
		{
			get
			{
				if(r_RN_GT_Int32_Out_T_Ref_Single_In_Int64_BooleanArrayArrayArray == null)
				{
					r_RN_GT_Int32_Out_T_Ref_Single_In_Int64_BooleanArrayArrayArray = new RMethod( ReleactionUtils.GetType("SMFrame.Editor.Refleaction.ATestGenericMethod"), "N", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeByRefType(), typeof(System.Single).MakeByRefType(), typeof(System.Int64).MakeByRefType(), typeof(System.Boolean).MakeArrayType().MakeArrayType().MakeArrayType());
					r_RN_GT_Int32_Out_T_Ref_Single_In_Int64_BooleanArrayArrayArray.SetBelong(null);
				}
				return r_RN_GT_Int32_Out_T_Ref_Single_In_Int64_BooleanArrayArrayArray;
			}
		}

		/// <summary>
		/// Void N()
		/// </summary>
		protected RMethod r_RN;
		public virtual RMethod RN
		{
			get
			{
				if(r_RN == null)
				{
					r_RN = new RMethod(this, "N", 0);
					r_RN.SetBelong(this.instance);
				}
				return r_RN;
			}
		}

		/// <summary>
		/// System.String N[T](T[])
		/// </summary>
		protected RMethod r_RN_GT_TArray;
		public virtual RMethod RN_GT_TArray
		{
			get
			{
				if(r_RN_GT_TArray == null)
				{
					r_RN_GT_TArray = new RMethod(this, "N", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_RN_GT_TArray.SetBelong(this.instance);
				}
				return r_RN_GT_TArray;
			}
		}

		/// <summary>
		/// Int32 N(System.String[] ByRef)
		/// </summary>
		protected RMethod r_RN_Ref_StringArray;
		public virtual RMethod RN_Ref_StringArray
		{
			get
			{
				if(r_RN_Ref_StringArray == null)
				{
					r_RN_Ref_StringArray = new RMethod(this, "N", 0, typeof(System.String).MakeArrayType().MakeByRefType());
					r_RN_Ref_StringArray.SetBelong(this.instance);
				}
				return r_RN_Ref_StringArray;
			}
		}

		/// <summary>
		/// Void N[a,b,c,d,e,f,g](System.Collections.Generic.Dictionary`2[a,System.Int32], b[], System.Collections.Generic.HashSet`1[System.Collections.Generic.Dictionary`2[e,c[]]])
		/// </summary>
		protected RMethod r_RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_a_Int32_p__bArray_HashSet_d_Dictionary_d_e_cArray_p__p_;
		public virtual RMethod RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_a_Int32_p__bArray_HashSet_d_Dictionary_d_e_cArray_p__p_
		{
			get
			{
				if(r_RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_a_Int32_p__bArray_HashSet_d_Dictionary_d_e_cArray_p__p_ == null)
				{
					r_RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_a_Int32_p__bArray_HashSet_d_Dictionary_d_e_cArray_p__p_ = new RMethod(this, "N", 7, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.Int32)), Type.MakeGenericMethodParameter(1).MakeArrayType(), typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(Type.MakeGenericMethodParameter(4), Type.MakeGenericMethodParameter(2).MakeArrayType())));
					r_RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_a_Int32_p__bArray_HashSet_d_Dictionary_d_e_cArray_p__p_.SetBelong(this.instance);
				}
				return r_RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_a_Int32_p__bArray_HashSet_d_Dictionary_d_e_cArray_p__p_;
			}
		}

		/// <summary>
		/// System.String N[T,U](T, U)
		/// </summary>
		protected RMethod r_RN_GT_GU_T_U;
		public virtual RMethod RN_GT_GU_T_U
		{
			get
			{
				if(r_RN_GT_GU_T_U == null)
				{
					r_RN_GT_GU_T_U = new RMethod(this, "N", 2, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
					r_RN_GT_GU_T_U.SetBelong(this.instance);
				}
				return r_RN_GT_GU_T_U;
			}
		}

		/// <summary>
		/// System.String N(Boolean ByRef)
		/// </summary>
		protected RMethod r_RN_Out_Boolean;
		public virtual RMethod RN_Out_Boolean
		{
			get
			{
				if(r_RN_Out_Boolean == null)
				{
					r_RN_Out_Boolean = new RMethod(this, "N", 0, typeof(System.Boolean).MakeByRefType());
					r_RN_Out_Boolean.SetBelong(this.instance);
				}
				return r_RN_Out_Boolean;
			}
		}

		/// <summary>
		/// System.String N(Int32 ByRef)
		/// </summary>
		protected RMethod r_RN_Ref_Int32;
		public virtual RMethod RN_Ref_Int32
		{
			get
			{
				if(r_RN_Ref_Int32 == null)
				{
					r_RN_Ref_Int32 = new RMethod(this, "N", 0, typeof(System.Int32).MakeByRefType());
					r_RN_Ref_Int32.SetBelong(this.instance);
				}
				return r_RN_Ref_Int32;
			}
		}

		/// <summary>
		/// System.String N(Boolean)
		/// </summary>
		protected RMethod r_RN_Boolean;
		public virtual RMethod RN_Boolean
		{
			get
			{
				if(r_RN_Boolean == null)
				{
					r_RN_Boolean = new RMethod(this, "N", 0, typeof(System.Boolean));
					r_RN_Boolean.SetBelong(this.instance);
				}
				return r_RN_Boolean;
			}
		}

		/// <summary>
		/// System.String N(Boolean[][][][])
		/// </summary>
		protected RMethod r_RN_BooleanArrayArrayArrayArray;
		public virtual RMethod RN_BooleanArrayArrayArrayArray
		{
			get
			{
				if(r_RN_BooleanArrayArrayArrayArray == null)
				{
					r_RN_BooleanArrayArrayArrayArray = new RMethod(this, "N", 0, typeof(System.Boolean).MakeArrayType().MakeArrayType().MakeArrayType().MakeArrayType());
					r_RN_BooleanArrayArrayArrayArray.SetBelong(this.instance);
				}
				return r_RN_BooleanArrayArrayArrayArray;
			}
		}

		/// <summary>
		/// System.String N(System.Collections.Generic.Dictionary`2[System.Int32[],System.Collections.Generic.List`1[System.String[][]]][][] ByRef)
		/// </summary>
		protected RMethod r_RN_In_Dictionary_d_Int32Array_List_d_StringArrayArray_p__p_ArrayArray;
		public virtual RMethod RN_In_Dictionary_d_Int32Array_List_d_StringArrayArray_p__p_ArrayArray
		{
			get
			{
				if(r_RN_In_Dictionary_d_Int32Array_List_d_StringArrayArray_p__p_ArrayArray == null)
				{
					r_RN_In_Dictionary_d_Int32Array_List_d_StringArrayArray_p__p_ArrayArray = new RMethod(this, "N", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32).MakeArrayType(), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String).MakeArrayType().MakeArrayType())).MakeArrayType().MakeArrayType().MakeByRefType());
					r_RN_In_Dictionary_d_Int32Array_List_d_StringArrayArray_p__p_ArrayArray.SetBelong(this.instance);
				}
				return r_RN_In_Dictionary_d_Int32Array_List_d_StringArrayArray_p__p_ArrayArray;
			}
		}

		/// <summary>
		/// Int32 N[T,U,A,z](System.Collections.Generic.Dictionary`2[T,U], A, Single)
		/// </summary>
		protected RMethod r_RN_GT_GU_GA_Gz_Dictionary_d_T_U_p__A_Single;
		public virtual RMethod RN_GT_GU_GA_Gz_Dictionary_d_T_U_p__A_Single
		{
			get
			{
				if(r_RN_GT_GU_GA_Gz_Dictionary_d_T_U_p__A_Single == null)
				{
					r_RN_GT_GU_GA_Gz_Dictionary_d_T_U_p__A_Single = new RMethod(this, "N", 4, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(2), typeof(System.Single));
					r_RN_GT_GU_GA_Gz_Dictionary_d_T_U_p__A_Single.SetBelong(this.instance);
				}
				return r_RN_GT_GU_GA_Gz_Dictionary_d_T_U_p__A_Single;
			}
		}

		/// <summary>
		/// System.String N(System.Collections.Generic.List`1[System.Int32] ByRef)
		/// </summary>
		protected RMethod r_RN_Ref_List_d_Int32_p_;
		public virtual RMethod RN_Ref_List_d_Int32_p_
		{
			get
			{
				if(r_RN_Ref_List_d_Int32_p_ == null)
				{
					r_RN_Ref_List_d_Int32_p_ = new RMethod(this, "N", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)).MakeByRefType());
					r_RN_Ref_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_RN_Ref_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new RMethod(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new RMethod(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new RMethod(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new RMethod(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new RMethod(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new RMethod(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}


        public RATestGenericMethod() : base("SMFrame.Editor.Refleaction.ATestGenericMethod")
        {
        }

        public RATestGenericMethod(System.Object instance) : base("SMFrame.Editor.Refleaction.ATestGenericMethod")
		{
            SetInstance(instance);
		}

        public RATestGenericMethod(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

        public static System.Single N<T>(System.Int32  @e, out T  @a, ref System.Single  @b, in System.Int64  @c, System.Boolean[][][]  @d)
        {
			a = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@e, @a, @b, @c, @d};
            var ___result = RN_GT_Int32_Out_T_Ref_Single_In_Int64_BooleanArrayArrayArray.Invoke(___genericsType, ___parameters);
			a = (T)___parameters[1];
			b = (System.Single)___parameters[2];

            return (System.Single)___result;
        }


        public virtual void N()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RN.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String N<T>(T[]  @a)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@a};
            var ___result = RN_GT_TArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 N(ref System.String[]  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RN_Ref_StringArray.Invoke(___genericsType, ___parameters);
			s = (System.String[])___parameters[0];

            return (System.Int32)___result;
        }


        public virtual void N<a, b, c, d, e, f, g>(System.Collections.Generic.Dictionary<a, System.Int32>  @s, b[]  @asdf, System.Collections.Generic.HashSet<System.Collections.Generic.Dictionary<e, c[]>>  @wer)
        {

            var ___genericsType = new Type[] {typeof(a), typeof(b), typeof(c), typeof(d), typeof(e), typeof(f), typeof(g)};
            var ___parameters = new object[]{@s, @asdf, @wer};
            var ___result = RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_a_Int32_p__bArray_HashSet_d_Dictionary_d_e_cArray_p__p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String N<T, U>(T  @a, U  @b)
        {

            var ___genericsType = new Type[] {typeof(T), typeof(U)};
            var ___parameters = new object[]{@a, @b};
            var ___result = RN_GT_GU_T_U.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String N(out System.Boolean  @a)
        {
			a = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_Out_Boolean.Invoke(___genericsType, ___parameters);
			a = (System.Boolean)___parameters[0];

            return (System.String)___result;
        }


        public virtual System.String N(ref System.Int32  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_Ref_Int32.Invoke(___genericsType, ___parameters);
			a = (System.Int32)___parameters[0];

            return (System.String)___result;
        }


        public virtual System.String N(System.Boolean  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String N(System.Boolean[][][][]  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_BooleanArrayArrayArrayArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String N(in System.Collections.Generic.Dictionary<System.Int32[], System.Collections.Generic.List<System.String[][]>>[][]  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_In_Dictionary_d_Int32Array_List_d_StringArrayArray_p__p_ArrayArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 N<T, U, A, z>(System.Collections.Generic.Dictionary<T, U>  @www, A  @fff, System.Single  @e)
        {

            var ___genericsType = new Type[] {typeof(T), typeof(U), typeof(A), typeof(z)};
            var ___parameters = new object[]{@www, @fff, @e};
            var ___result = RN_GT_GU_GA_Gz_Dictionary_d_T_U_p__A_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String N(ref System.Collections.Generic.List<System.Int32>  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_Ref_List_d_Int32_p_.Invoke(___genericsType, ___parameters);
			a = (System.Collections.Generic.List<System.Int32>)___parameters[0];

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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
