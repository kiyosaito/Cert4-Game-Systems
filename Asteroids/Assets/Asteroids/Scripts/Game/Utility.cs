using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility {
    public static Bounds GetBounds(this Camera cam, float padding = 1f) {

        float camHeight, camWidth;
        Vector3 camPos = cam.transform.position;
        camHeight = 2f * cam.orthographicSize;
        camWidth = camHeight * cam.aspect;
        camHeight += padding;
        camWidth += padding;
        return new Bounds(camPos, new Vector3(camWidth, camHeight, 100));
    }
    
}
