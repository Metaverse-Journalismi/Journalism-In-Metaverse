using UnityEngine;

public class InfoScreenScript : MonoBehaviour
{

    public GameObject infoScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (infoScreen != null)
            infoScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if (infoScreen != null)
                infoScreen.SetActive(!infoScreen.activeSelf);
        }
    }
}
