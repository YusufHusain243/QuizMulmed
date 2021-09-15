using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text data1, data2, operatorSymbol, skor, skorEndGame;
    public InputField answer;
    private int randData1, randData2, randMathSymbol, maxQuestions, scored;

    public GameObject endGame;

    void Start()
    {
        randomSoal();
        maxQuestions = 1;
    }

    public void randomSoal()
    {
        if(maxQuestions < 10)
        {
            randData1 = Random.Range(0, 11);
            randData2 = Random.Range(0, 11);
            randMathSymbol = Random.Range(0, 4);

            data1.text = randData1.ToString();
            data2.text = randData2.ToString();

            if (randMathSymbol == 0)
            {
                operatorSymbol.text = "+";
            }
            else if (randMathSymbol == 1)
            {
                operatorSymbol.text = "-";
            }
            else if (randMathSymbol == 2)
            {
                operatorSymbol.text = "x";
            }
            else if (randMathSymbol == 3)
            {
                operatorSymbol.text = "/";
            }
        }
        else
        {
            endGame.SetActive(true);
            skorEndGame.text = "Skor : " + scored.ToString();
        }
        
    }

    public void Jawab()
    {
        string jawabanText = answer.text;
        string skorText = skor.text;

        int.TryParse(skorText, out scored);

        int jawaban;
        int.TryParse(jawabanText, out jawaban);

        if (randMathSymbol == 0)
        {
            int hasil = randData1 + randData2;
            if(jawaban == hasil)
            {
                scored += 100;
                skor.text = scored.ToString();
            }
        }
        else if (randMathSymbol == 1)
        {
            int hasil = randData1 - randData2;
            if (jawaban == hasil)
            {
                scored += 100;
                skor.text = scored.ToString();
            }
        }
        else if (randMathSymbol == 2)
        {
            int hasil = randData1 * randData2;
            if (jawaban == hasil)
            {
                scored += 100;
                skor.text = scored.ToString();
            }
        }
        else if (randMathSymbol == 3)
        {
            int hasil = randData1 / randData2;
            if (jawaban == hasil)
            {
                scored += 100;
                skor.text = scored.ToString();
            }
        }

        randomSoal();
        answer.text = "";
        maxQuestions += 1;
    }
}
