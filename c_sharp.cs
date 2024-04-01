using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_sharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        private int myAge = 16;

        float averageScore = 92.5f;

        string myName = "Shane";

        string favoriteColor = "Cyan";

        public string name = "string";
    }

    // Update is called once per frame
    void Awake()
    {
        if (favoriteColor == "Cyan" && myName == "Shane" ){
            Debug.Log("This is Shane.");


        }
        else{
            Debug.Log("This is not Shane.");

        }
    
    }
    void Start(){
        string[] game = {"It's a fighting game", "It's a card game", "It's a multiplayer game"};

        for(int index = 0; index<game.Length;i++){
            Debug.Log(game[index]);
        }
    }

    void Element(){
        string[] game = {"It's a fighting game", "It's a card game", "It's a multiplayer game"};

        for(int index = 0; index<game.Length;i++){
            Debug.Log(game[index]);
    }
}
