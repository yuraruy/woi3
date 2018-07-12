using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Topic == Тема
public class ScrollContent : MonoBehaviour {
    //Objects templates for filling
    public GameObject[] EventObjects;
    //Names, dates, contacts, places, topics input; Names - 0 Dates - 1 Contacts - 2 Places - 3 Topics - 4
    public Text[] Input;

    void OnMouseUp()
    {
        int Index = PlayerPrefs.GetInt("ScrollNumber");
        string ObjectName = EventObjects[Index].name;

        Text Name = GameObject.Find("Canvas/ScrollView/Viewport/Content/"+ObjectName+"Name").GetComponent<Text>();

        Text Date = GameObject.Find("Canvas/ScrollView/Viewport/Content/" + ObjectName + "Date").GetComponent<Text>();

        Text Topic = GameObject.Find("Canvas/ScrollView/Viewport/Content/" + ObjectName + "Topic").GetComponent<Text>();

        Text Place = GameObject.Find("Canvas/ScrollView/Viewport/Content/" + ObjectName + "Place").GetComponent<Text>();

        Text Contacts = GameObject.Find("Canvas/ScrollView/Viewport/Content/" + ObjectName + "Contacts").GetComponent<Text>();

        Name.text = Input[0].text;
        Date.text = Input[1].text;
        Topic.text = Input[2].text;
        Place.text = Input[3].text;
        Contacts.text = Input[4].text;

        PlayerPrefs.SetInt("ScrollNumber", PlayerPrefs.GetInt("ScrollNumber")+1);
    }
}
/*if (name != null)
        {
            Debug.Log("OK");
        }*/