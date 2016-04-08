using UnityEngine;
using System.Collections;

public class projectileCAC : MonoBehaviour
{

    public GameObject fire;
    private Renderer FirePoint;


    void Start()
    {
        fire.SetActive(false);
        FirePoint = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire2") && FirePoint.enabled)
        {
            fire.SetActive(true);
        }
        else {
            fire.SetActive(false);
        }


    }
}

