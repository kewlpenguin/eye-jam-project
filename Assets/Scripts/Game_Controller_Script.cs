using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class Game_Controller_Script : MonoBehaviour
{

    public int Soul_count;

    public TextMeshProUGUI Soul_Count_Text;
    public GameObject Spawn_Point_1;
    public GameObject Spawn_Point_2;
    public GameObject Spawn_Point_3;
    public GameObject Spawn_Point_4;

    public Vector2 Spawn_Pos;


    public GameObject Enemy_1;
    public GameObject Enemy_2;
    public GameObject Enemy_3;


    public GameObject Soul_Furnace;

    private GameObject Eye_Prefab;

    public bool End_Started;

    void Start()
    {
        Spawn_Pos = Spawn_Point_1.transform.position;
        Soul_count = 5;
        StartCoroutine(Spawn_Coroutine());
        End_Started = false;


    }



    void Update()
    {
        if (Spawn_Point_4.gameObject.activeInHierarchy && End_Started == false)
        {
            End_Started = true;
            StartCoroutine(Spawn_Super_Coroutine());
        }


        Soul_Count_Text.text = Soul_count.ToString();


    }


    private IEnumerator Spawn_Coroutine()
    {
        yield return new WaitForSeconds(5);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(15);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(10);
        Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(5);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(5);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(5);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(15);
        Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(1);
        Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(1);
        Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(1);
        Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(1);
        Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(30);
         Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(30);
        Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(20);
        Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(20);
        Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(.5f);
        Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
        yield return new WaitForSeconds(30);
        for(int i = 0; i < 9999; i++)
        {
            yield return new WaitForSeconds(10);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
        }














    }




    private IEnumerator Spawn_Super_Coroutine()
    {
        for (int i = 0; i < 9999; i++)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_3, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.2f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_1, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);
            Instantiate(Enemy_2, Spawn_Pos, gameObject.transform.rotation);
            yield return new WaitForSeconds(.05f);

        }

    }









    }
