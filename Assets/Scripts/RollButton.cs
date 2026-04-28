using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
class Item
{
    public GameObject itemPrefab;
    public float itemRarity;
}

public class RollButton : MonoBehaviour
{
   [SerializeField] GameObject baseUIButtons; 
    [SerializeField] GameObject baseUICollectionBox; //Variable for the ui we want to hide while showing the rolling UI.
    [SerializeField] GameObject vignette; //Variable for some vignette.
    [SerializeField] GameObject guassianBlur; //Variable for the guassian blur.
    [SerializeField] GameObject rollingUI; //The rolling UI.

    [SerializeField] List<Item> items = new List<Item>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void startRolling()
    {
        StartCoroutine(letsGoGambling());
    }

    IEnumerator letsGoGambling()
    {
        baseUIButtons.SetActive(false);
        baseUICollectionBox.SetActive(false);
        rollingUI.SetActive(true);
        vignette.SetActive(true);
        guassianBlur.SetActive(true);
        yield return new WaitForSeconds(3);
        baseUIButtons.SetActive(true);
        baseUICollectionBox.SetActive(true);
        rollingUI.SetActive(false);
        vignette.SetActive(false);
        guassianBlur.SetActive(false);
        for (int i = 0; i < 1; i++)
        {
            int rarityRoll = UnityEngine.Random.Range(0, 100);
            int index = -1;
            for (int j = items.Count -1; j > 0; j--)
            {
                if (rarityRoll <= items[j].itemRarity)
                {
                    index = j;
                    break;
                }
            }
            if (index != -1)
            {
                Instantiate(items[index].itemPrefab, baseUICollectionBox.transform);
                items.RemoveAt(index);
            }
                    //int randomIndex = UnityEngine.Random.Range(0, items.Count);
            
        }
    }


}
