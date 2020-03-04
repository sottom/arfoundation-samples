using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ShowSkeleton : MonoBehaviour
{
    // don't need to do both of these
    public HumanBodyTracker humanBodyTracker;
    public ARHumanBodyManager humanBodyManager;

    public void ShowBody(){
        humanBodyManager.humanBodyPose3DEstimationEnabled = true;
        humanBodyTracker.enabled = true;
    }
}
