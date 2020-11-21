using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public bool isOpen;
    public GameObject uiObject;
    private Vector3 v;

    void Start()
    {
        uiObject.SetActive(false);
    }

    public void OpenChest(){
        
        if(!isOpen){
            isOpen = true;
            
            Debug.Log("Hairpin collected.");
            // Open dialogue box
            v.x = 600;
            v.y = 740;
            v.z = 0;
            uiObject.transform.TransformPoint(v);
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec(){
        yield return new WaitForSeconds(3);
        Destroy(uiObject);
        Destroy(gameObject);
    }
    
}
