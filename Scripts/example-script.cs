using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example-script : MonoBehaviour
{
    public GameObject objectEnable;


    public void OnTriggerEnter()
    {

        new WaitForSeconds(1);
        objectEnable.SetActive(true);
    }


    public void OnTriggerExit()
    {
        new WaitForSeconds(1);
        objectEnable.SetActive(true);
    }


}