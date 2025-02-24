using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    public GrapplingGun Grappling;

    private Quaternion desiredRotation;
    private float rotationSpeed = 5f;

    private void Update()
    {
        if (!Grappling.IsGrappling())
        {
            desiredRotation = transform.parent.rotation;
        }
        else
        {
            desiredRotation = Quaternion.LookRotation(Grappling.GetGrapplePoints() - transform.position);
        }
        //transform.rotation 
    }
    
}
