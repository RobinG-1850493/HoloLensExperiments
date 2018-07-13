using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTarget : MonoBehaviour {

    public GameObject underworld;
    public GameObject objectToHide;

    void OnCollisionEnter(Collision collision)
    {
        objectToHide.SetActive(false);
        underworld.SetActive(true);

        SpatialMapping.Instance.MappingEnabled = false;
    }
}
