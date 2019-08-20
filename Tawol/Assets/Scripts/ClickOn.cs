using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{

    [SerializeField]
    private Material black;
    [SerializeField]
    private Material white;

    private MeshRenderer myRend;

    // Start is called before the first frame update
    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
    }

    public void ClickMe()
    {
        if (myRend.material.name == "White (Instance)")
        {
            myRend.material = black;
            Debug.Log("Change to Black");
        }
        else
        {
            myRend.material = white;
            Debug.Log("Change to White");
        }
    }
}
