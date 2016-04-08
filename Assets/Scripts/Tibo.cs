using UnityEngine;
using System.Collections;

public class Tibo : MonoBehaviour
{
    public bool freezeRotation = true;
    public Vector2 speed = new Vector2(5,5);

    void Update()
    {
        var player = GameObject.Find("Player");
        Vector3 ppos = (player.transform.position).normalized;
        Vector3 mp = Camera.main.ScreenToWorldPoint(transform.position);
        Vector2 Sens = new Vector2(ppos.x-mp.x,ppos.y-mp.y).normalized;
        Vector2 BougeSonGrosCul = new Vector2(ppos.x * speed.x,ppos.y*speed.y);
        GetComponent<Rigidbody2D>().velocity = BougeSonGrosCul;
        Debug.Log(ppos);
    }
}
