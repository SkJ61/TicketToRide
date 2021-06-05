using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mappa : MonoBehaviour
{
    private List<Citta> citta;
    private List<Tratta> tratte;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setListaCitta (List<Citta> citta){
        this.citta = citta;
    }

    public List<Citta> getListaCitta(){
        return citta;
    }

    public void setListaTratta (List<Tratta> tratte){
        this.tratte = tratte;
    }

    public List<Tratta> getListaTratte(){
        return tratte;
    }
}
