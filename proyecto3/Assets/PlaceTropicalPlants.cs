
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class PlaceTropicalPlants : MonoBehaviour
{
    public GameObject[] tropicalPlantPrefabs;
    private ARRaycastManager raycastManager;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPos = Input.GetTouch(0).position;
            if (raycastManager.Raycast(touchPos, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose pose = hits[0].pose;
                int idx = Random.Range(0, tropicalPlantPrefabs.Length);
                GameObject go = Instantiate(tropicalPlantPrefabs[idx], pose.position, Quaternion.Euler(0, Random.Range(0,360), 0));
                go.transform.localScale = Vector3.one * Random.Range(0.8f, 1.2f);
                go.tag = "Plant";

                go.AddComponent<PlantInfo>();
                go.GetComponent<PlantInfo>().plantName = "Palmera tropical";
                go.GetComponent<PlantInfo>().description = "Planta alta con hojas grandes ideal para sombra.";

                go.AddComponent<PlantInfo>();
                go.GetComponent<PlantInfo>().plantName = "Bambú de la suerte";
                go.GetComponent<PlantInfo>().description = "Planta a.";

                go.AddComponent<PlantInfo>();
                go.GetComponent<PlantInfo>().plantName = "tropical";
                go.GetComponent<PlantInfo>().description = "Planta ";

            }
        }
    }
}
