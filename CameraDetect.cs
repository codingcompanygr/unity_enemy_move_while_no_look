using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetect : MonoBehaviour
{
    Camera camera;

    MeshRenderer renderer;

    Plane[] cameraFrustum;

    Collider collider;

    public Enemy enemy;

    void Start()
    {
        camera = Camera.main;
        renderer = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        var bounds = collider.bounds;
        cameraFrustum = GeometryUtility.CalculateFrustumPlanes(camera);
        if (GeometryUtility.TestPlanesAABB(cameraFrustum, bounds))
        {
            enemy.CanMove = false;
        }
        else
        {
            enemy.CanMove = true;
        }
    }
}
