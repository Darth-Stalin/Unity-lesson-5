using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;
    

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int[] array = SetArray(50);
        WriteArray(array);
        Sort(array);
        WriteArray(array);
    }

    private int[] SetArray(int length)

        {
            int[] arr = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(-100, 101);
            }
            return arr;
        }

    private void WriteArray(int[] arr)
    {
        foreach (int a in arr)
        {
            Debug.Log(a);
        }
    }

   private void Sort(int[] arr)
   {
        int min;
        int temp;
        for (int i = 0; i < arr.Length; i++)
        {
            min = i;

            for (int j = i +1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }

            temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
   } 
}
