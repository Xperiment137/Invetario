using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

    public class MetodosItem : MonoBehaviour
    {
        public Collider colider;
        public string mensaje = "Pulsa E para cogerlo";
        public bool activo = false;
        public GUIStyle font;
        public GUISkin diseño;
        public bool destruido = false;
        public Item aux;
        public int id = 0;


        void Start()
        {

            colider = GetComponent<Collider>();
            aux = new Item();
            aux.name = name;
            aux.img = "barril1";
            aux.id = id;
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                colider.isTrigger = true;

            }
            else
            {
                colider.isTrigger = false;

            }
            

        }
        void OnGUI()
        {

            if (activo)
            {



                GUI.Label(new Rect(Screen.width / 2 - 100, 50, 200, 30), mensaje, font);
            }

        }

        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.tag == "Player")
            {
                destruido = true;
            string json = JsonUtility.ToJson(aux);
            PlayerPrefs.SetString("Datos", json);
            PlayerPrefs.Save();
            Destroy(gameObject);

            }

        }
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                activo = true;
            }



        }
        void OnCollisionExit(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                activo = false;
            }
        }
            
        }
     
    



