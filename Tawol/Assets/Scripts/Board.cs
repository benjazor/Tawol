using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Pawn []Grid;
    public GameObject cube;
    public Material black;
    public Material white;

    void BuildBoard()
    {
        for (int i = 0; i < 64; i++)
        {
            GameObject t_cube = Instantiate(cube);
            t_cube.transform.position = new Vector3(i/8, 0, i%8);
            if (i / 8 % 2 == 0)
            {
                t_cube.GetComponent<MeshRenderer>().material = (i % 2 == 0 ? white : black);
            }
            else
            {
                t_cube.GetComponent<MeshRenderer>().material = (i % 2 == 0 ? black : white);
            }



        }
    }

    void BuildBoard2()
    {
        for (int i = 0; i < 64; i++)
        {
            GameObject t_cube = Instantiate(cube);
            t_cube.transform.position = new Vector3(i/8, 0, i%8);

            t_cube.GetComponent<MeshRenderer>().material = (i / 8 % 2 == 0 ? i % 2 == 0 : i % 2 != 0) ? white : black;


        }
    }

    // Start is called before the first frame update
    void Start()
    {
        BuildBoard2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
