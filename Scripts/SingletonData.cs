using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonData : MonoBehaviour
{
    
    public static SingletonData instance;

    void Awake(){
        if(instance == null){
            DontDestroyOnLoad(gameObject);
            instance = this;
        } else {
            if(instance != this){
                Destroy(gameObject);
            }
        }
    }
    
    public float mood = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
