
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ITransform
	/// </summary>
    public partial class RITransform : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.ITransform);
            }
        }

        public RITransform() : base("UnityEngine.UIElements.ITransform")
        {
        }

        public RITransform(System.Object instance) : base("UnityEngine.UIElements.ITransform")
		{
            SetInstance(instance);
		}

        public RITransform(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RITransform(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion rotation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RQuaternion r_Protation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RQuaternion RProtation
		{
			get
			{
				if(r_Protation == null)
				{
					r_Protation = new(this, "rotation", -1);
				}
				return r_Protation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pscale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPscale
		{
			get
			{
				if(r_Pscale == null)
				{
					r_Pscale = new(this, "scale", -1);
				}
				return r_Pscale;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 matrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_Pmatrix;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPmatrix
		{
			get
			{
				if(r_Pmatrix == null)
				{
					r_Pmatrix = new(this, "matrix", -1);
				}
				return r_Pmatrix;
			}
		}


    }
}
