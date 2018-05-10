using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class noteValue : MonoBehaviour
{
    public Transform TheCamera;
    public float valueOfNote;
    public float noteDuration;
    // Use this for initialization
    void Start()
    {
        Metronome metronome = TheCamera.gameObject.GetComponent<Metronome>();
        noteDuration = Mathf.Round((valueOfNote * 60 / metronome.bpm) * 1000f) / 1000f;
    }

    // Update is called once per frame
    void Update()
    {
        Metronome metronome = TheCamera.gameObject.GetComponent<Metronome>();
        noteDuration = Mathf.Round((valueOfNote * 60 / metronome.bpm) *1000f) / 1000f;
    }
}
