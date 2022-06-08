// Juarez Ramirez Leonardo Alonso 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// este codigo se agrega para que se pueda poner el texto sin que te de fallos y pueda modificarse en escena 
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
   
   //Se le da autorizacion de que se pueda utilizar el codigo para el texto 
   public TextMeshProUGUI texto;
   
   //Esta parte se le da autorizacion para poner la acion de acelerador o freno para ponerlo despues en el codigo y no tenga problemas 
   public int acelerador;

   public string freno;


    // Start is called before the first frame update
    void Start()
    {
        texto.text="Acelera";
    }


// esta parte del codigo sirve para designar cada tecla para que pueda hacer una accion la cual esta como acelerador, freno y cada ves que se precione el texto cambiara a 200
// si lo mantienes pulsado se manendra activo en 200, pero al dejar de precionarlo volvera a 0, basicamente como si fuera un velocimetro, la accion tostring sirve para volver a
// designar la variable para que no tenga fallos
    // Update is called once per frame
    void Update()
    {
        //este codigo sirve para asignar una tacla para una accion 
        if (Input.GetKey(KeyCode.W))
        {
            //Esta parte del codio sirve para que en el texto acelere de 0 a 200 y si lo mantienes precionado se queda en 200
            acelerador++;
            if(acelerador >= 200){
                acelerador=200;
                texto.text = acelerador.ToString();
            }
           
        }
        //esta parte del codigo sirve para que se vuela al valor normal cuando se deje de precionar la tecla con la que se acelera y pueda volver al valor normal 
        if (Input.GetKeyUp(KeyCode.W))
        {
            texto.text=freno;
        }
         
          //esta parte sirve par aasignar la variable tostring como si fuera una puesta de texto normal 
          //texto.text= acelerador.ToString();
    }
}
