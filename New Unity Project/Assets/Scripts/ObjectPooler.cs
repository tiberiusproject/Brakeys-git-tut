using System.Collections;
using System.Collections.Generic;//for using dictionaries
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    //defines what pools to have in inspector
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Pool> pools;

    //created a new empty dictionary
    public Dictionary<string, Queue<GameObject>> poolDictionary;
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>(); 
    }

}
