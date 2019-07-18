using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Inventario : MonoBehaviour
{
    public MetodosItem aux;
    public Item[] inventario;
    public Item aux2;
    int i = 0;

    void Start()
    {
        MetodosItem aux = new MetodosItem();
        inventario = new Item[10];
       
        
       
    }


    void Update()
    {


        if (Input.GetKey(KeyCode.T))
        {

            string json = PlayerPrefs.GetString("Datos");
            if (!string.IsNullOrEmpty(json))
            {
                aux2 = JsonUtility.FromJson<Item>(json);
            }
            inventario[0] = aux2;
            Mostrar();

        }
    }
        public void Mostrar()
        {

            
          
            Debug.Log( inventario[0].name);
            Debug.Log(inventario[0].id);
            Debug.Log(inventario[0].img);
        

        }

   
}
   
