using UnityEngine;

public class Grappling : MonoBehaviour
{
    [Header("References")]
  //  private PlayerMovementGrappling pm;
    public Transform cam;
    public Transform gunTip;
    public LayerMask whatIsGrappleable;
    public LineRenderer lr;

    [Header("Grappling")]
    public float maxGrappleDistance;
    public float grappleDelayTime;

    private Vector3 grapplePoint;

    [Header("cooldown")]
    public float grapplingCd;
    public float grapplingCdTimer;

    [Header("Input")]
    public KeyCode grapplingKey = KeyCode.Mouse1;

    private bool grappling;

    private void Start()
    {
    //    pm = GetComponent<PlayerMovementGrappling>();

    }
    private void Update()
    {
        if(Input.GetKeyDown(grapplingKey)) StartGrapple();

        if (grapplingCdTimer > 0) { 
        grapplingCdTimer -= Time.deltaTime;
        }
    }
    private void LateUpdate()
    {
        if (grappling) 
        { 
        lr.SetPosition(0, gunTip.position);
        }
    }


    private void StartGrapple()
    {
        if (grapplingCdTimer > 0)
        {
            return;
     }
        grappling = true;

        RaycastHit hit;
        if (Physics.Raycast(cam.position, cam.forward, out hit, maxGrappleDistance, whatIsGrappleable))
        {
            grapplePoint = hit.point;
            Invoke(nameof(ExecuteGrapple), grappleDelayTime);
        }
        else { 
        grapplePoint = cam.position + cam.forward * maxGrappleDistance;

            Invoke(nameof(ExecuteGrapple), grappleDelayTime);
        }

        lr.enabled = true;
        lr.SetPosition(1, grapplePoint);
    }
    private void ExecuteGrapple() 
    { 
    
    }
    private void stopGrapple()
    {
        grappling = false;

        grapplingCdTimer = grapplingCd;
        lr.enabled = false; 
    }
}
