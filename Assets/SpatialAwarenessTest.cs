using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SpatialAwarenessHandler = Microsoft.MixedReality.Toolkit.SpatialAwareness.IMixedRealitySpatialAwarenessObservationHandler<Microsoft.MixedReality.Toolkit.SpatialAwareness.SpatialAwarenessPlanarObject>;
public class SpatialAwarenessTest : MonoBehaviour, SpatialAwarenessHandler { 
    // Start is called before the first frame update
    void Start()
    {
        var spatialAwarenessService = CoreServices.SpatialAwarenessSystem;
        var dataProviderAccess = spatialAwarenessService as IMixedRealityDataProviderAccess;
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();
        

        //var meshObserverName = "Spatial Object Mesh Observer";
        var spatialObjectMeshObserver = dataProviderAccess.GetDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

       observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;
        
        // Resume Mesh Observation from all Observers
        CoreServices.SpatialAwarenessSystem.ResumeObservers();
        
        // Loop through all known Meshes
        /*
        foreach (SpatialAwarenessMeshObject meshObject in observer.Meshes.Values) {
            Mesh mesh = meshObject.Filter.mesh;
            // Do something with the Mesh object
            GameObject tmp = new GameObject(meshObject.Filter.name);
            tmp.AddComponent<MeshFilter>();
            tmp.GetComponent<MeshFilter>().mesh = mesh;
            tmp.AddComponent<MeshRenderer>();

            GameObject tt = Instantiate(tmp);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable() {
        // Register component to listen for Mesh Observation events, typically done in OnEnable()
        CoreServices.SpatialAwarenessSystem.RegisterHandler<SpatialAwarenessHandler>(this);
    }

    private void OnDisable() {
        // Unregister component from Mesh Observation events, typically done in OnDisable()
        CoreServices.SpatialAwarenessSystem.UnregisterHandler<SpatialAwarenessHandler>(this);
    }

    public virtual void OnObservationAdded(MixedRealitySpatialAwarenessEventData<SpatialAwarenessPlanarObject> eventData) {
        // Do stuff
        /*
        Mesh mesh = eventData.SpatialObject.Filter.mesh;
        // Do something with the Mesh object
        GameObject tmp = new GameObject(eventData.SpatialObject.Filter.name);
        tmp.AddComponent<MeshFilter>();
        tmp.GetComponent<MeshFilter>().mesh = mesh;
        tmp.AddComponent<MeshRenderer>();

        GameObject tt = Instantiate(tmp);
        */
    }

    public virtual void OnObservationUpdated(MixedRealitySpatialAwarenessEventData<SpatialAwarenessPlanarObject> eventData) {
        
        // Do stuff
        Mesh mesh = eventData.SpatialObject.Filter.mesh;
        // Do something with the Mesh object
        GameObject tmp = new GameObject("Planar Obj!!");
        tmp.AddComponent<MeshFilter>();
        tmp.GetComponent<MeshFilter>().mesh = mesh;
        tmp.AddComponent<MeshRenderer>();

        GameObject tt = Instantiate(tmp);
        Debug.Log(eventData.SpatialObject.GameObject.name+ " / "  + eventData.SpatialObject.GameObject.layer);
       
    }

    public virtual void OnObservationRemoved(MixedRealitySpatialAwarenessEventData<SpatialAwarenessPlanarObject> eventData) {
        // Do stuff
    }
}
