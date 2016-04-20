using UnityEngine;
using System.Collections;

public class LOISO : MonoBehaviour
{
    
    public bool freezeRotation = true;
    public int yspeed = 5;
    public int speed = 5;
    public Vector2 direction = new Vector2(1, 0);
    GameObject bear;

    void Update(){
        bear = Resources.Load("Teddy") as GameObject;       // on le transformera en mrd de pigeon
        var canard = gameObject.transform.position;
        var player = GameObject.Find("Player");
        Vector2 ppos = player.transform.position;
        if (canard.y <= 1.6)
        {
                Jump();
        }
        if ((canard.x - ppos.x) < 0.1 && (canard.x - ppos.x) > 0){
            GameObject mrd = Instantiate(bear) as GameObject;
            mrd.transform.position = transform.position;
        }
    }
    void Jump()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x * -speed, yspeed * 1);
    }
}

