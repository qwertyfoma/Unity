using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public GameObject panel;

    public bool wincond = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player") == true)
        {
            wincond = true;
            panel.SetActive(true);
            Time.timeScale = 0.2f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
