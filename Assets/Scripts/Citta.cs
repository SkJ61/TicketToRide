using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Citta : MonoBehaviour
{
    private string nome;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setNome(string nome){
        this.nome = nome;
    }
    public string getNome(){
        return nome;
    }
}
