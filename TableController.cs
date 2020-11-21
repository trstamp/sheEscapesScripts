using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    public bool isOpen;
    public GameObject uiObject;
    private Vector3 v;

    void Start()
    {
        uiObject.SetActive(false);
    }

    public void checkUnderTable(){

        if(!isOpen){
            isOpen = true;
            
            Debug.Log("Hairpin 2 collected.");
            // Open dialogue box
            v.x = 740;
            v.y = 600;
            v.z = 0;
            uiObject.transform.position = v;
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    
    IEnumerator WaitForSec(){
            yield return new WaitForSeconds(3);
            Destroy(uiObject);
    }
    
}
