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
    private void Awake()
    {
        PlayerPrefs.SetInt("ScrollNumber", 0);
    }

        /*int Index = PlayerPrefs.GetInt("ScrollNumber");
        string ObjectName = EventObjects[Index].name;
        Debug.Log("/Canvas/Scroll View/Viewport/Content/" + ObjectName + "/Name");
        Text Name = GameObject.Find("/Canvas/Scroll View/Viewport/Content/" + ObjectName + "/Name").GetComponent<Text>();
        //Debug.Log("/Canvas/ScrollView/Viewport/Content/" + ObjectName + "/Name");*/

    void OnMouseUp()
    {
        Debug.Log("PPOO");
        int Index = PlayerPrefs.GetInt("ScrollNumber");
        string ObjectName = EventObjects[Index].name;

        Text Name = GameObject.Find("/Canvas/Scroll View/Viewport/Content/"+ObjectName+"/Name").GetComponent<Text>();

        Text Date = GameObject.Find("/Canvas/Scroll View/Viewport/Content/" + ObjectName + "/Date").GetComponent<Text>();

        Text Topic = GameObject.Find("/Canvas/Scroll View/Viewport/Content/" + ObjectName + "/Topic").GetComponent<Text>();

        Text Place = GameObject.Find("/Canvas/Scroll View/Viewport/Content/" + ObjectName + "/Place").GetComponent<Text>();

        Text Contacts = GameObject.Find("/Canvas/Scroll View/Viewport/Content/" + ObjectName + "/Contacts").GetComponent<Text>();
        if (Name == null)
        {
            Debug.Log("bad");
        }
        else
        {
            Debug.Log("ok");
        }
        Name.text = Input[0].text;
        Date.text = Input[1].text;
        Topic.text = Input[2].text;
        Place.text = Input[3].text;
        Contacts.text = Input[4].text;

        PlayerPrefs.SetInt("ScrollNumber", PlayerPrefs.GetInt("ScrollNumber")+1);
        Debug.Log(PlayerPrefs.GetInt("ScrollNumber"));
    }
}