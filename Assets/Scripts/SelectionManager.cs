using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectionManager : MonoBehaviour
{
    public GameObject objectInfo;
    private TextMeshProUGUI objectInfoText;

    void Start()
    {
        objectInfoText = objectInfo.GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            var objects = hit.transform;
            if (objects.GetComponent<InterectableObject>())
            {
                objectInfoText.text = objects.GetComponent<InterectableObject>().GetItemName();
                objectInfo.SetActive(true);
            }
            else
            {
                objectInfo.SetActive(false);
            }
        }
    }
}
