// using System.Collections;
// using System.Collections.Generic;
// // using UnityEngine;

// // public class incision : MonoBehaviour
// // {
// //     // Start is called before the first frame update
// //     void Start()
// //     {
        
// //     }

// //     // Update is called once per frame
// //     void Update()
// //     {
        
// //     }
// // }

// using UnityEngine;

// public class FleshLayerManager : MonoBehaviour
// {
//     // Array of GameObjects representing different layers of flesh
//     public GameObject[] fleshLayers;

//     // Reference to the scalpel GameObject
//     public GameObject scalpel;

//     // Current active layer index
//     private int currentLayerIndex = 0;

//     void Start()
//     {
//         // Ensure the first layer is active at the start
//         if (fleshLayers.Length > 0)
//         {
//             for (int i = 1; i < fleshLayers.Length; i++)
//             {
//                 fleshLayers[i].SetActive(false);
//             }
//             fleshLayers[0].SetActive(true);
//         }
//         else
//         {
//             Debug.LogError("No flesh layers assigned in the FleshLayerManager script.");
//         }

//         // Ensure the scalpel has a collider for collision detection
//         if (scalpel == null || scalpel.GetComponent<Collider>() == null)
//         {
//             Debug.LogError("Scalpel is not assigned or does not have a Collider component.");
//         }
//     }

//     void OnCollisionEnter(Collision collision)
//     {
//         // Check if the collision is with the scalpel
//         if (collision.gameObject == scalpel)
//         {
//             // Turn off the current layer
//             fleshLayers[currentLayerIndex].SetActive(false);

//             // Move to the next layer
//             currentLayerIndex++;

//             // Check if we've gone past the last layer
//             if (currentLayerIndex < fleshLayers.Length)
//             {
//                 // Turn on the next layer
//                 fleshLayers[currentLayerIndex].SetActive(true);
//                 Debug.Log("Turned on layer " + currentLayerIndex);
//             }
//             else
//             {
//                 // If we've gone past the last layer, reset or handle the end condition
//                 Debug.Log("All layers have been cycled through.");
//                 // Optionally, you could reset to the first layer or end the simulation here
//                 // currentLayerIndex = 0; // Uncomment to reset to the first layer
//             }
//         }
//     }
// }

// using UnityEngine;

// public class ScalpelCollision : MonoBehaviour
// {
//     void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.CompareTag("flesh"))
//         {
//             // Disable the SphereCollider when triggered
//             SphereCollider sphereCollider = other.gameObject.GetComponent<SphereCollider>();
//             if (sphereCollider != null)
//             {
//                 sphereCollider.enabled = false; // Disable the collider
//                 Debug.Log("SphereCollider removed via trigger!");
//             }
//         }
//     }
// }

// using UnityEngine;

// public class ScalpelCollision : MonoBehaviour
// {
//     void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.CompareTag("flesh"))
//         {
//             // Make the object invisible
//             Debug.Log("FLES!!");
//             MeshRenderer meshRenderer = other.gameObject.GetComponent<MeshRenderer>();
//             if (meshRenderer != null)
//             {
//                 meshRenderer.enabled = false; // Hide the object
//                 Debug.Log("Layer1 is now invisible!");
//             }
//         }
//     }
// }


// using UnityEngine;

// public class ScalpelCollision : MonoBehaviour
// {
//     public string hiddenLayerName = "Hidden"; // Set this to the name of your hidden layer

//     void OnTriggerEnter(Collider other)
//     {
//         Debug.Log("Trigger detected with: " + other.gameObject.name);

//         if (other.gameObject.CompareTag("layer1"))
//         {
//             Debug.Log("Layer1 detected! Changing its layer.");

//             // Get the hidden layer index
//             int hiddenLayer = LayerMask.NameToLayer(hiddenLayerName);
//             if (hiddenLayer == -1)
//             {
//                 Debug.LogError("Layer '" + hiddenLayerName + "' does not exist! Create it in Unity.");
//                 return;
//             }

//             // Change the object's layer
//             other.gameObject.layer = hiddenLayer;
//             Debug.Log("Layer1 is now on the '" + hiddenLayerName + "' layer and hidden.");
//         }
//     }
// }

using UnityEngine;

public class ScalpelCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("layer1"))
        {
            Debug.Log("Layer1 detected! Disabling the GameObject.");
            other.gameObject.SetActive(false); // Completely disable the object
        }

        if (other.gameObject.CompareTag("layer2"))
        {
            Debug.Log("Layer2 detected! Disabling the GameObject.");
            other.gameObject.SetActive(false); // Completely disable the object
        }

        if (other.gameObject.CompareTag("layer3"))
        {
            Debug.Log("Layer3 detected! Disabling the GameObject.");
            other.gameObject.SetActive(false); // Completely disable the object
        }
    }
}