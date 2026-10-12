using UnityEngine;
using System.Collections;
public class Shot_Controller : MonoBehaviour
{
    private float Delay = .5f;
    public bool Can_Be_Destroyed = false;
    public float Move_Speed = 500f;
    public float Move_Speed_Delay = .05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Delay_Destroy_On_Wall());
        StartCoroutine(Move_Shot());
    }

    // Update is called once per frame
    void Update()
    {
     
    }


    private IEnumerator Delay_Destroy_On_Wall()
    {
        yield return new WaitForSeconds(Delay);
        Can_Be_Destroyed = true;
    }

    private IEnumerator Move_Shot()
    {
        for (int I = 0; I < 19999; I++)
        {
            gameObject.transform.Translate(Vector2.down * Move_Speed);
            yield return new WaitForSeconds(Move_Speed_Delay); 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Can_Be_Destroyed == true && collision.gameObject.CompareTag("Wall")) 
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("enemy1") || collision.gameObject.CompareTag("enemy2") || collision.gameObject.CompareTag("enemy3"))
        Destroy(gameObject);
    }
}
