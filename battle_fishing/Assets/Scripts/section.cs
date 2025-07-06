using UnityEngine;

public class section : MonoBehaviour
{

    public GameObject basic_tile;

    public int width;


    void Awake(){

        for(int i = 0; i < width; i++){

            make_tile(i);
        }

    }

    


    // Update is called once per frame
    void Update()
    {
        
    }


    void make_tile(int xpos){
        Instantiate(basic_tile, new Vector2(xpos * 16, 0), Quaternion.identity);
    }
}
