using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisAndThat : MonoBehaviour
{
    [SerializeField] GameObject blueCube, redCube, door;

    bool isRedCubeDetected, isBlueCubeDeteced, areBothCubesDetected;

    // DIRECTIONS: This script is missing a crucial "if statement" in the Update() method
    // None of the existing code needs to change, but something must be added...

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (areBothCubesDetected)
        {
            door.GetComponent<MoveToLocation>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == blueCube)
        {
            isBlueCubeDeteced = true;
        }

        if (other.gameObject == redCube)
        {
            isRedCubeDetected = true;
        }
    }
}
