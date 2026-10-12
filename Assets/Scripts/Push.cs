using UnityEngine;
using System.Collections;
using TMPro;
public class Push : MonoBehaviour
{
    public string Move_Direction;
    public float Move_Speed = 500f;
    public float Health = 99;
    public GameObject Soul_Furnace;

    public TextMeshProUGUI Soul_Counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (gameObject.CompareTag("enemy1"))
        {
            Health = 2;
            Move_Speed = .3f;
        }
        else if (gameObject.CompareTag("enemy2"))
        {
            Health = 5;
            Move_Speed = .1f;
        }
        else if (gameObject.CompareTag("enemy3"))
        {
            Health = 15;
            Move_Speed = .05f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count += 1;
            Destroy(gameObject);
        }



    }
 
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("right"))
        {
            Move_Direction = "right";
            Vector2 tmp = new Vector2(1, 0);
            gameObject.transform.Translate(tmp * Move_Speed *  Time.deltaTime);
        }

        if (collision.gameObject.CompareTag("left"))
        {
            Move_Direction = "left";
            Vector2 tmp = new Vector2(-1, 0);
            gameObject.transform.Translate(tmp * Move_Speed * Time.deltaTime);
        }

        if (collision.gameObject.CompareTag("up"))
        {
            Move_Direction = "up";
            Vector2 tmp = new Vector2(0, 1);
            gameObject.transform.Translate(tmp * Move_Speed * Time.deltaTime);
        }

        if (collision.gameObject.CompareTag("down"))
        {
            Move_Direction = "down";
            Vector2 tmp = new Vector2(0, -1);
            gameObject.transform.Translate(tmp * Move_Speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("furnace")) 
        {
            GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count -= 1;
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("shot"))
        {
            Health -= 1;
        }
    }


}
