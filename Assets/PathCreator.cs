using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCreator : MonoBehaviour {

    public Transform pathPoint;
    //Transform firstPoint;
    List<Transform> path = new List<Transform>();
    LineRenderer lineRenderer;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update () {
        RaycastHit hit;
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        Terrain terrain = GetComponent<Terrain>();
        if (Input.GetButtonUp("LMB"))
        {
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000))
            {
                Vector3 pos = new Vector3(hit.point.x, hit.point.y + 0.5f, hit.point.z);
                if (path.Count != 0)
                {
                    lineRenderer.SetPosition(path.Count, pos);
                    path.Add(Instantiate(pathPoint, pos, Quaternion.identity));
                }
            }
        }
        if (Input.GetButtonDown("LMB"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000))
            {
                Vector3 pos = new Vector3(hit.point.x, hit.point.y + 0.5f, hit.point.z);
                if (path.Count == 0)
                {
                    lineRenderer.positionCount = lineRenderer.positionCount + 2;
                    lineRenderer.SetPosition(0, pos);
                    path.Add(Instantiate(pathPoint, pos, Quaternion.identity));
                }
                else
                {
                    lineRenderer.positionCount = lineRenderer.positionCount + 1;
                    lineRenderer.SetPosition(path.Count, pos);
                }
            }
        }
        if (Input.GetButton("LMB"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000))
            {
                Vector3 pos = new Vector3(hit.point.x, hit.point.y + 0.5f, hit.point.z);
                lineRenderer.SetPosition(path.Count, pos);
                
            }
        }
    }
}
