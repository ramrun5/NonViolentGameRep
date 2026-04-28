using UnityEngine;

public class CollectionBoxShowHide : MonoBehaviour
{
    [SerializeField] private GameObject cBox; //The collection box.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showHideCBox()
    {
        if (cBox.activeSelf == true)
        {
            cBox.SetActive(false);
        }
        else
        {
            cBox.SetActive(true);
        }

    }
}
