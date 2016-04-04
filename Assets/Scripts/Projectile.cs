using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    GameObject BulletTrailPrefab;                                     // j'ai putin de galéré pour enfin trouver un code qui marche à peu près
    void Start()
    {
        BulletTrailPrefab = Resources.Load("bullet") as GameObject;  // Bizarrement il faut créer un dossier resources pour qu'il le trouve,
                                                                     // si on laisse dans "prefabs" il ne trouve pas. 
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))                           
        {
            GameObject bullet = Instantiate(BulletTrailPrefab) as GameObject;
            Vector2 mp = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            bullet.transform.position = transform.position;             // Je ne savais pas trop quoi mettre à la suite du =
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();        // C'est ça qui va permettre à la torche de voler 
            rb.velocity = new Vector2(10, 10);                          // là il tire en haut et à droite (coordonnées).
        }
    }
}
