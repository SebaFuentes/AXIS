using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    public int score2;
    private List<Transform> highscoreEntryTransformList;

    private void Awake()
    {
        GameObject player = GameObject.Find("NaveJugador");
        if (player != null)
        {
            score2 = player.GetComponent<MovimientoJugador>().score;
        }

        entryContainer = transform.Find("HighScoreEntryContainer");
        entryTemplate = transform.Find("HighScoreEntryContainer");
        entryTemplate.gameObject.SetActive(false);

        
       /* highscoreEntryList = new List<HighscoreEntry>()
        {
            new HighscoreEntry {score = 0, name = ""};
            //10 veces por los 10 puestos
        };*/

       string jsonString = PlayerPrefs.GetString("highscoreTable");
       Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
            {
                if (highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
                {
                    HighscoreEntry tmp = highscores.highscoreEntryList[i];
                    highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                    highscores.highscoreEntryList[j] = tmp;
                }
            }
        }

        highscoreEntryTransformList = new List<Transform>();
        foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
        {
            CreateHighscoreEntryTransform(highscoreEntry,entryContainer,highscoreEntryTransformList);
        }

        /*Highscores highscores = new Highscores {highscoreEntryList = highscoreEntryList};
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable",json);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("highscoreTable"));*/
    }

    /*float templateHeight = 20f;
    for (int i = 0; i < 10; i++)
    {
        Transform entryTransform = Instantiate(entryTemplate, entryContainer);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
        entryTransform.gameObject.SetActive(true);

        int rank = i + 1;
        string rankString;
        switch (rank)
        {
            default: rankString = rank + "TH";break;
            case 1:
                rankString = "1ST"; break;
            case 2:
                rankString = "2ND"; break;
            case 3:
                rankString = "3RD"; break;
        }
        entryTransform.Find("posText").GetComponent<Text>().text = rankString;
        entryTransform.Find("scoreText").GetComponent<Text>().text = score2.ToString();
        entryTransform.Find("nameText").GetComponent<Text>().text = "");  //ASIGNAR VARIABLE DE NOMBRE EN LUGAR
    }*/

        private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container,List<Transform> transformList)
        {
            float templateHeight = 30f;
            
            Transform entryTransform = Instantiate(entryTemplate, container);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
            entryTransform.gameObject.SetActive(true);

            int rank = transformList.Count + 1;
            string rankString;
            switch (rank)
            {
                default: rankString = rank + "TH";break;
                case 1:
                    rankString = "1ST"; break;
                case 2:
                    rankString = "2ND"; break;
                case 3:
                    rankString = "3RD"; break;
            }

            score2 = highscoreEntry.score; //ver si es score de HighscoreEntry o score2
            name = highscoreEntry.name; //ver si es name de HighscoreEntry o name
            
            entryTransform.Find("posText").GetComponent<Text>().text = rankString;
            entryTransform.Find("scoreText").GetComponent<Text>().text = score2.ToString();
            entryTransform.Find("nameText").GetComponent<Text>().text = ""; //ASIGNAR VARIABLE DE NOMBRE EN LUGAR
            transformList.Add(entryTransform);
        }

        private void AddHighscoreEntry(int score, string name)//TENDRÉ QUE DEJAR VARIABLE NAME COMO NAME
        {
            HighscoreEntry highscoreEntry = new HighscoreEntry {score = score, name = name};
            
            string jsonString = PlayerPrefs.GetString("highscoreTable");
            Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
            
            highscores.highscoreEntryList.Add(highscoreEntry);

            string json = JsonUtility.ToJson(highscores);
            PlayerPrefs.SetString("highscoreTable",json);
            PlayerPrefs.Save();
        }
        
    private class Highscores
    {
        public List<HighscoreEntry> highscoreEntryList;
    }

        [System.Serializable]
    private class HighscoreEntry
    {
        public int score;
        public string name;
    }
    
}
