using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpower : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject obj;
    public GameObject tableObject;
    public GameObject chairObject;
    public GameObject couchObject;
    private PlacementIndicatorManager placementIndicatorManager;


    // Start is called before the first frame update
    void Start()
    {
        placementIndicatorManager = FindObjectOfType<PlacementIndicatorManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began)
        // {
        //     GameObject obj = Instantiate(gameObject, placementIndicatorManager.transform.position, placementIndicatorManager.transform.rotation);
        // }
    }

    public void SpawnObject(string objectName) {
        switch (objectName) {
            case "table":
                gameObject=tableObject;
                obj = Instantiate(tableObject, placementIndicatorManager.transform.position, placementIndicatorManager.transform.rotation);
                break;
            case "chair":
                gameObject=chairObject;
                obj = Instantiate(chairObject, placementIndicatorManager.transform.position, placementIndicatorManager.transform.rotation);
                break;
            case "couch":
                gameObject=couchObject;
                obj = Instantiate(couchObject, placementIndicatorManager.transform.position, placementIndicatorManager.transform.rotation);
                break;
        }
    }

    public void RotateRight() {
        if (obj != null){
           obj.transform.Rotate(Vector3.up, 30f); 
        }
        
    }
    
    public void RotateLeft() {
        if (obj != null){
            obj.transform.Rotate(Vector3.up, -30f);
        }
        
    }
    
    public void ScaleUp() {
        if (obj != null){
            obj.transform.localScale *= 2;
            // obj.transform.localScale += new Vector3(100f, 100f, 100f);
        }
        
    }
    
    public void ScaleDown() {
        if (obj != null){
            obj.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
        
        // gameObject.transform.localScale = new Vector3(Mathf.Clamp(objectToManipulate.transform.localScale.x, 0.1f, 10f), Mathf.Clamp(objectToManipulate.transform.localScale.y, 0.1f, 10f), Mathf.Clamp(objectToManipulate.transform.localScale.z, 0.1f, 10f));
    }

    public void Delete() {
        if (obj != null){
            Destroy(obj);
        }
        
    }

}
