using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{

    [SerializeField] private int[] intarray;
    private int whileindex;

    // Start is called before the first frame update
    void Start()
    {
        /*Bucle que mostra els numeros del 1 al 10
        for(int i = 1;  i <= 10; i++) 
       {
           Debug.Log(message: $"{i}");
       }
*/

        /*recorrer tots es elements d un array
        for(int i = 0; i <intarray.Length; i++) 
        {
            Debug.Log(message: $"{intarray[i]}");
        }
*/
       /* Romprer ho
        for(int i = 0; i <intarray.Length; i++) 
        {
            Debug.Log(message: $"{intarray[i]}");

            if (intarray[i] < 0)
            {
                break;
            }
        }
        */
/*
        foreach(int number in intarray)
        {
            Debug.Log(message: $"{number}");
        }
*/

        /*whileindex = 1;
        while (whileindex<= 10)
        {
            Debug.Log($"whileindex = {whileindex}");
            whileindex++;
        }
        */




    }


}
