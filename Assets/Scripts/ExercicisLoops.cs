using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicisLoops : MonoBehaviour
{
    [SerializeField] private int[] intarray;
    private int whileindex;
    private int resultado = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        /* EXERCICI 1
        for(int i = 1;  i <= 100; i++) 
        {
        Debug.Log(i);
        }
        
        whileindex = 1;
        while(whileindex <=100)
        {
            Debug.Log(whileindex);
            whileindex++;
        }
        */


        //EXERCICI 2
        //for (int i = 0; i <= 100; i++)
        //{
        //    Debug.Log(i);
        //    i++;
        //}

        //whileindex = 0;
        //while (whileindex <= 100)
        //{
        //    Debug.Log(whileindex++);
        //    whileindex++;
        //}


        // EXERCICI 3
        //for (int i = 1; i <= 100; i++)
        //{
        //    Debug.Log(i);
        //    i++;
        //}

        //whileindex = 1;
        //while (whileindex <= 100)
        //{
        //    Debug.Log(whileindex++);
        //    whileindex++;
        //}


        // EXERCICI 4
        //foreach (int number in intarray)
        //{
        //    resultado = resultado + number;
        //   Debug.Log(resultado);

        //}


        //EXERCICI 8
        //for (int i = 1; i <= 20; i++)
        //{
        //    Debug.Log(11 * i);
        //}

        //EXERCICI 9
        for (int i =1; i<=20; i++)
        {
            for (int a = 1; a <= 10; a++)
            {
                Debug.Log(a);
                a++;
            }
            
        }


    }



}
