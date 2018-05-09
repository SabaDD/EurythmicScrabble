using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class setBPM : MonoBehaviour
{
    public GameObject inputField;
    // Use this for initialization

    // Update is called once per frame
    public void changeTheBPM()
    {
        GetComponent<Metronome>().bpm = float.Parse(inputField.GetComponent<InputField>().text);
    }
}
