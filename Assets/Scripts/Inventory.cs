using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour, IHasChanged
{
    [SerializeField] Transform slots;
    public Transform TheCamera;
    //[SerializeField] Text inventoryText;
    

    public void HasChanged()
    {
        List<noteValue> noteSequence = new List<noteValue>();
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.Append(" - ");
        foreach (Transform slotTransform in slots)
        {
            GameObject item = slotTransform.GetComponent<Slot>().Item;
            if (item)
            {
                builder.Append(item.gameObject.GetComponent<noteValue>().noteDuration);
                builder.Append(" - ");
                noteSequence.Add(item.gameObject.GetComponent<noteValue>());
                
            }
        }
        //inventoryText.text = builder.ToString();
        CheckAccuracy checkAccuracy = TheCamera.gameObject.GetComponent<CheckAccuracy>();
        checkAccuracy.producedNoteSequence = builder.ToString();
        
        
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
