using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckAccuracy : MonoBehaviour
{
    public string producedNoteSequence;
    public string tappedNoteSequence;
    public Text accuracyText;
    public void measureTheAccuracy()
    {
        string[] pns = producedNoteSequence.Split(new char[] { '-', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
        string[] tns = tappedNoteSequence.Split(new char[]{'-', ' '}, System.StringSplitOptions.RemoveEmptyEntries);
        float[] pnsDouble = new float[pns.Length-1];
        float[] tnsDouble = new float[tns.Length];
        //Debug.Log("---" + pns.ToString());
        for (int i = 0 ; i < pnsDouble.Length; i++)
        {
            pnsDouble[i] = float.Parse(pns[i]);
        }
        for (int i = 0; i < tnsDouble.Length-1; i++)
        {
            tnsDouble[i] = float.Parse(tns[i+1])- float.Parse(tns[i]);
        }
        float[] accuracy = new float[pns.Length-1];
        float sum = 0;
        for (int j = 0; j < accuracy.Length; j++)
        {
            accuracy[j] = ( pnsDouble[j] - Mathf.Abs(tnsDouble[j] - pnsDouble[j])) / pnsDouble[j] *100;
            sum += accuracy[j];
        }
        float calculatedAccuracy = Mathf.Round((sum / pnsDouble.Length) * 10f) /10f;
        accuracyText.text = calculatedAccuracy.ToString() + "%";

        //producedNoteSequence = null;
        tappedNoteSequence = null; 
    }
}
