using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
    private string colore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setColor(string colore) {
        this.colore = colore;
    }

    public string getColor(){
        return colore;
    }

}
