using UnityEngine;

public class InterectableObject : MonoBehaviour
{
    public string itemName;
    public string GetItemName()
    {
        return itemName;
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
