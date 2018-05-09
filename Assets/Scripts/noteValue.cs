using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class noteValue : MonoBehaviour
{
    public Transform TheCamera;
    public double valueOfNote;
    public double noteDuration;
    // Use this for initialization
    void Start()
    {
        Metronome metronome = TheCamera.gameObject.GetComponent<Metronome>();
        noteDuration = valueOfNote * (60 / metronome.bpm);
    }

    // Update is called once per frame
    void Update()
    {
        Metronome metronome = TheCamera.gameObject.GetComponent<Metronome>();
        noteDuration = valueOfNote * 60 / metronome.bpm;
        Debug.Log("note Duration" +valueOfNote+" " + noteDuration);
    }
}
