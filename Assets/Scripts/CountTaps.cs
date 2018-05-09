using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CountTaps : MonoBehaviour {

    private static CountTaps _instance;
    public int counter = 0;
    public Text timerLabel;
    private float time;
    private bool flag = true;
    // Update is called once per frame
    //Begin New
    private void Start()
    {
        flag = true;
    }
    void Awake()
    {
        //if we don't have an [_instance] set yet
        if (!_instance)
            _instance = this;
        //otherwise, if we do, kill this thing
        else
            Destroy(this.gameObject);


        DontDestroyOnLoad(this.gameObject);
    }
    //End New
    void Update () {
        if(counter == 1 && flag == true)
        {
            time = Time.time;
            var minutes = Mathf.Floor(time / 60);
            var seconds = time % 60;//Use the euclidean division for the seconds.
            var fraction = (time * 100) % 100;
            //timerLabel.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
            Debug.Log(string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction));
            flag = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            counter++;
            time = Time.time;
            var minutes = Mathf.Floor(time / 60);
            var seconds = time % 60;//Use the euclidean division for the seconds.
            var fraction = (time * 100) % 100;
            Debug.Log(string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction));
        }
            
	}
    //public void ButtonClick()
    //{
    //    counter++;
    //}
}
