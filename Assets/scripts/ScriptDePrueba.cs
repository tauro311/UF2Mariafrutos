using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDePrueba : MonoBehaviour
{

    public int vidasPersonaje = 5;
    public float numeroDecimal = 4.5f;
    public string nombrePersonaje = "Pepo";
    private bool interrruptor = false;
    public int vidasPersonaje2 = 3;
    
    // Start is called before the first frame update
    void Start()
    {
      vidasPersonaje = 10; 
      numeroDecimal = 3.14f;
      nombrePersonaje = "Mario";
      interrruptor = true;

      int suma = vidasPersonaje + vidasPersonaje2;
      Debug.Log(suma);
      string sumaTexto = nombrePersonaje + "Hola";
      Debug.Log(sumaTexto);

      Debug.Log(nombrePersonaje);
      Debug.Log(vidasPersonaje);
      Debug.Log(numeroDecimal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
