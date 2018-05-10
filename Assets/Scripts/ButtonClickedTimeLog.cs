using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonClickedTimeLog : MonoBehaviour
{
    public Transform TheCamera;
    private float time;
    public int counter = 0;
    public bool flag = false;
    public void buttonClicked()
    {
        if (flag == false)
        {
            time = Time.time;
            var minutes = Mathf.Floor(time / 60);
            var seconds = time % 60;//Use the euclidean division for the seconds.
            var fraction = (time * 1000) % 1000;
            counter++;
            ////timerLabel.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
            //Debug.Log(string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction));
            //Debug.Log("Counter: " + counter + "time" + time);
            CheckAccuracy checkAccuracy = TheCamera.gameObject.GetComponent<CheckAccuracy>();
            checkAccuracy.tappedNoteSequence += " - "+ (Mathf.Round((time) * 1000f) / 1000f).ToString();
        }
        else
        {
            counter = 0;
            flag = false;
        }
    }
}
