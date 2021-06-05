using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tratta : MonoBehaviour
{
    private int numVagoni;
    private string colore; 
    private Citta cittaPartenza;
    private Citta cittaArrivo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setNumVagoni (int vagoni){
        this.numVagoni = vagoni;
    }

    public void setColore (string colore){
        this.colore = colore;
    }

    public void setCittaPartenza (Citta partenza){
        this.cittaPartenza = partenza;
    }

    public void setCittaArrivo (Citta arrivo){
        this.cittaArrivo = arrivo;
    }

    public string getColore (){
        return colore;
    }

    
    public int getNumVagoni (){
        return numVagoni;
    }
    public Citta getCittaPartenza (){
        return cittaPartenza;
    }
    public Citta getCittaArrivo (){
        return cittaArrivo;
    }
}
