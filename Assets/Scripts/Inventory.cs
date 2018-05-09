using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour, IHasChanged
{
    [SerializeField] Transform slots;
    [SerializeField] Text inventoryText;
    public float[] noteSequence= new float[20];

    public void HasChanged()
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.Append(" - ");
        int i = 0;
        foreach (Transform slotTransform in slots)
        {
            GameObject item = slotTransform.GetComponent<Slot>().Item;
            if (item)
            {
                builder.Append(item.gameObject.GetComponent<noteValue>().noteDuration);
                //Debug.Log("hey" + item.gameObject.GetComponent<noteValue>().noteDuration);
                builder.Append(" - ");
                noteSequence[i] = item.gameObject.GetComponent<noteValue>().noteDuration;
                i++;
            }
        }
        inventoryText.text = builder.ToString();
        Debug.Log(noteSequence);
    }

    // Use this for initialization
    void Start()
    {
        HasChanged();
    }

  
}
namespace UnityEngine.EventSystems
{
    public interface IHasChanged: IEventSystemHandler
    {
        void HasChanged();
    }
}
