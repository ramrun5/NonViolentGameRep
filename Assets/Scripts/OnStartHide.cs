using UnityEngine;

public class OnStartHide : MonoBehaviour
{
    //Objects to hide.
    [SerializeField] GameObject object1;
    [SerializeField] GameObject object2;
    [SerializeField] GameObject object3;
    [SerializeField] GameObject object4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object1.SetActive(false);
        object2.SetActive(false);
        object3.SetActive(false);
        object4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}