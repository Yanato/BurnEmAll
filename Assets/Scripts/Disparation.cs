using UnityEngine;
using System.Collections;

public class Disparation : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "bullet(Clone)")
        {
            Destroy(gameObject, 5f);
        }
    }
}