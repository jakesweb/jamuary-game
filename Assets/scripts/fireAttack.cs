using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireAttack : MonoBehaviour {

    public GameObject firePrefab;

    private GameObject _fireInstance;
    private Vector2 parentTransform;

    // Update is called once per frame
    void Update ()
    {
	    if (Input.GetButtonDown("Fire1"))
        { 
            _fireInstance = Instantiate(firePrefab, transform.parent);
            _fireInstance.transform.parent = transform;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            GameObject.Destroy(_fireInstance);
        }
	}
}
