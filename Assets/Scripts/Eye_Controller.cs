using UnityEngine;
using System.Collections;
public class Eye_Controller : MonoBehaviour
{
    private bool Is_Active;
    private bool Is_Ready_To_Fire;
    public GameObject Shot;
    public GameObject Lazer;

    public int Eye_Cooldown;
    public int Level;

    public Sprite State_Cooldown;
    public Sprite State_1;
    public Sprite State_2;
    public Sprite State_3;
    public Sprite State_4;



    private void OnMouseDown()
    {
        if (GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count > 0 && gameObject.GetComponent<SpriteRenderer>().enabled == false)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            Is_Active = true;
            Is_Ready_To_Fire = true;
            GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count--;
            return;
        }

        if(gameObject.GetComponent<SpriteRenderer>().enabled == true)
        {
            if (Is_Ready_To_Fire)
            {
                Instantiate(Shot, gameObject.transform.position, gameObject.transform.rotation);
                StartCoroutine(Cooldown_Shot());
            }
        }

    }

    void Start()
    {
        Is_Active = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && Is_Ready_To_Fire)  // upgrade function
        {
            // Convert mouse screen position to a world point
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                if(hit.collider.gameObject.GetComponent<Eye_Controller>().Level == 1 && GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count > 1)
                {
                    GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count -= 2;
                    Level = 2;
                    gameObject.GetComponent<SpriteRenderer>().sprite = State_2;
                }

                else if(hit.collider.gameObject.GetComponent<Eye_Controller>().Level == 2 && GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count > 2)
                {
                    GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count -= 3;
                    Level = 3;
                    gameObject.GetComponent<SpriteRenderer>().sprite = State_3;
                }

                else if (hit.collider.gameObject.GetComponent<Eye_Controller>().Level == 3 && GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count > 4)
                {
                    GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count -= 5;
                    Level = 4;
                    gameObject.GetComponent<SpriteRenderer>().sprite = State_4;
                }
            }
        }

      

    }

    private IEnumerator Cooldown_Shot()
    {
        Is_Ready_To_Fire = false;
        Sprite temp = gameObject.GetComponent<SpriteRenderer>().sprite;
        gameObject.GetComponent<SpriteRenderer>().sprite = State_Cooldown;
        yield return new WaitForSeconds(Eye_Cooldown);
        gameObject.GetComponent<SpriteRenderer>().sprite = temp;
        Is_Ready_To_Fire = true;

    }

   

}
