using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Physics;
using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeGazeManager : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        // MixedRealityToolkit.InputSystem.EyeGazeProvider.GazePointer.;
        MixedRealityToolkit.InputSystem.EyeGazeProvider.IsEyeTrackingEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CoreServices.InputSystem.EyeGazeProvider.HitInfo.raycastValid)
            target.transform.position = CoreServices.InputSystem.EyeGazeProvider.HitPosition;
        //target.transform.position = CoreServices.InputSystem.EyeGazeProvider.GazeOrigin + (CoreServices.InputSystem.EyeGazeProvider.GazeDirection.normalized*(CoreServices.InputSystem.EyeGazeProvider.HitPosition.magnitude));
        
        /*
        foreach (var source in CoreServices.InputSystem.DetectedInputSources) {
            // Ignore anything that is not a hand because we want articulated hands
            if (source.SourceType == Microsoft.MixedReality.Toolkit.Input.InputSourceType.Hand) {
                foreach (var p in source.Pointers) {
                    if (p is IMixedRealityNearPointer) {
                        // Ignore near pointers, we only want the rays
                        continue;
                    }
                    if (p.Result != null) {
                        var startPoint = p.Position;
                        var endPoint = p.Result.Details.Point;
                        var hitObject = p.Result.Details.Object;
                        if (hitObject) {
                             var sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                             sphere.transform.localScale = Vector3.one * 0.01f;
                            //target.transform.position = endPoint;
                            sphere.transform.position = endPoint;
                        }
                    }

                }
            }
        }
        */
        //Microsoft.MixedReality.Toolkit.Input.IPointerResult Result;
        // Debug.Log(Result.CurrentPointerTarget.transform.position);
        // RaycastHit hit;

        SolverHandler solver = new SolverHandler();
      //  Debug.Log("TransformTarget : " + solver.TransformTarget.name);
        //Vector3 origin = solver.;
       // Vector3 endpoint = solver.GoalPosition;
       // RayStep ray = new RayStep();
      //  ray.UpdateRayStep(ref origin, ref endpoint);
        // MixedRealityRaycaster.RaycastSimplePhysicsStep(rayStep, maxRaycastDistance, magneticSurfaces, false, out result);
        //CoreServices.InputSystem.EyeGazeProvider.GazeOrigin +
      //  Debug.Log(" HitPos" + CoreServices.InputSystem.EyeGazeProvider.HitPosition);
     //   Debug.Log(" GazeOrigin" + CoreServices.InputSystem.EyeGazeProvider.GazeOrigin);
    }
}
