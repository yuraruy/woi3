﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Topic == Тема
public class AnswerContent : MonoBehaviour
{
    //Objects templates for filling
    public GameObject[] EventObjects;
    //Names, dates, contacts, places, topics input; Names - 0 Dates - 1 Contacts - 2 Places - 3 Topics - 4
    public Text[] InputAnswerQuestion;
    private void Awake()
    {
        PlayerPrefs.SetInt("AnswerNumber", 0);
    }

    /*int Index = PlayerPrefs.GetInt("ScrollNumber");
    string ObjectName = EventObjects[Index].name;
    Debug.Log("/Canvas/Scroll View/Viewport/Content/" + ObjectName + "/Name");
    Text Name = GameObject.Find("/Canvas/Scroll View/Viewport/Content/" + ObjectName + "/Name").GetComponent<Text>();
    //Debug.Log("/Canvas/ScrollView/Viewport/Content/" + ObjectName + "/Name");*/

    void OnMouseUp()
    {
        int Index = PlayerPrefs.GetInt("AnswerNumber");
        Debug.Log(Index);
        string ObjectName = EventObjects[Index].name;

        Text Name = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Name").GetComponent<Text>();

        Text Date = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Date").GetComponent<Text>();

        Text Contacts = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Contacts").GetComponent<Text>();

        Text Question = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Question").GetComponent<Text>();

        if (Name == null)
        {
            Debug.Log("bad");
        }
        else
        {
            Debug.Log("ok");
        }
        Name.text = InputAnswerQuestion[0].text;
        Date.text = InputAnswerQuestion[1].text;
        Contacts.text = InputAnswerQuestion[2].text;
        Question.text = InputAnswerQuestion[2].text;

        PlayerPrefs.SetInt("AnswerNumber", PlayerPrefs.GetInt("AnswerNumber") + 1);
        Debug.Log(PlayerPrefs.GetInt("AnswerNumber"));
    }
}