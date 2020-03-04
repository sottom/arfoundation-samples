using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ShowSkeleton : MonoBehaviour
{
    // don't need to do both of these
    public GameObject humanBodyTracking;

    public void ShowBody(){
        // humanBodyManager.humanBodyPose3DEstimationEnabled = true;
        humanBodyTracking.SetActive(true);
    }
}
