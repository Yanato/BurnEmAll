using UnityEngine;
using System.Collections;

public class Disparation : MonoBehaviour
{                                       // à attacher sur "bullet" de "Resources"
    public int damage = 1;              // Rip Tiborc
    public bool isEnemyShot = false;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "bullet(Clone)")
        {
            Destroy(gameObject, 5);
        }
    }
}