using UnityEngine;

public class Spawn_Script : MonoBehaviour
{
    public GameObject Box_Cover_1;
    public GameObject Box_Cover_2;
    public GameObject Box_Cover_3;

    public GameObject Spawner_1;
    public GameObject Spawner_2;
    public GameObject Spawner_3;
    public GameObject Spawner_4;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count > 10)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    private void OnMouseDown()
    {
        if (GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count > 10 && Box_Cover_1.gameObject.activeInHierarchy && Box_Cover_1 == gameObject) // if we have 10 souls and cover 1 is active
        {
            GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count -= 10;
            Box_Cover_1.gameObject.SetActive(false);
            Spawner_1.SetActive(false);
            Spawner_2.SetActive(true);
            GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Spawn_Pos = Spawner_2.transform.position;
        }

        else if (GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count > 10 && Box_Cover_2.gameObject.activeInHierarchy && Box_Cover_2 == gameObject && Box_Cover_1.gameObject.activeInHierarchy == false)
        {
            GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count -= 10;
            Box_Cover_2.gameObject.SetActive(false);
            Spawner_2.SetActive(false);
            Spawner_3.SetActive(true);
            GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Spawn_Pos = Spawner_3.transform.position;
        }

        else if (GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count > 10 && Box_Cover_3.gameObject.activeInHierarchy && Box_Cover_3 == gameObject && Box_Cover_2.gameObject.activeInHierarchy == false) // if the object we click is this
        {
            GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Soul_count -= 10;
            Box_Cover_3.gameObject.SetActive(false);
            Spawner_3.SetActive(false);
            Spawner_4.SetActive(true);
            GameObject.Find("Game Controller").GetComponent<Game_Controller_Script>().Spawn_Pos = Spawner_4.transform.position;
        }

    }
}
