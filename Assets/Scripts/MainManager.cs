using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public GameObject normalPlayer;
    public GameObject firePlayer;
    // Start is called before the first frame update
    void Awake()
    {
        DataManager.Instance.LoadDataFromFile();

        if (DataManager.Instance._classType == "normal")
            Instantiate(normalPlayer, transform.position, normalPlayer.transform.rotation);

        if (DataManager.Instance._classType == "fire")
            Instantiate(firePlayer, transform.position, normalPlayer.transform.rotation);
    }

}
