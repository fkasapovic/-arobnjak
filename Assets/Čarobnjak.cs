using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Čarobnjak : MonoBehaviour
{
    //Use this for initialization
    int max;
    int min;
    int pokusaj;
    int maxBrojPokusaj = 10;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1001;
        min = 1;
        SljedeciPokusaj();
    }

    public void pokusajNize()
    {
        max = pokusaj;
        SljedeciPokusaj();
    }

    public void pokusajVise()
    {
        min = pokusaj;
        SljedeciPokusaj();
    }

    void SljedeciPokusaj()
    {
        pokusaj = Random.Range(min, max + 1);
        text.text = pokusaj.ToString();
        maxBrojPokusaj = maxBrojPokusaj - 1;
        if ( maxBrojPokusaj <=0)
        {
            Application.LoadLevel("Win");
        }
    }
}
