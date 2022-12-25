using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ITransform
	/// </summary>
    public partial class RITransform : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected RUnityEngine.RVector3 r_position;
		public virtual RUnityEngine.RVector3 Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position", -1);
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion rotation
		/// </summary>
		protected RUnityEngine.RQuaternion r_rotation;
		public virtual RUnityEngine.RQuaternion Rrotation
		{
			get
			{
				if(r_rotation == null)
				{
					r_rotation = new(this, "rotation", -1);
					r_rotation.SetBelong(this.instance);
				}
				return r_rotation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 scale
		/// </summary>
		protected RUnityEngine.RVector3 r_scale;
		public virtual RUnityEngine.RVector3 Rscale
		{
			get
			{
				if(r_scale == null)
				{
					r_scale = new(this, "scale", -1);
					r_scale.SetBelong(this.instance);
				}
				return r_scale;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 matrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_matrix;
		public virtual RUnityEngine.RMatrix4x4 Rmatrix
		{
			get
			{
				if(r_matrix == null)
				{
					r_matrix = new(this, "matrix", -1);
					r_matrix.SetBelong(this.instance);
				}
				return r_matrix;
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

    }
}
