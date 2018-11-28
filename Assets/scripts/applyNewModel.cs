using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyNewModel : MonoBehaviour {

    public GameObject mainModel;
    internal Color col;
	
	// Update is called once per frame
	void Update () {

        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, fwd, out hit, 50))
        {
            col = hit.transform.gameObject.GetComponent<Renderer>().material.color;
            mainModel.GetComponent<Renderer>().material.color = col;
        }
    }
}

