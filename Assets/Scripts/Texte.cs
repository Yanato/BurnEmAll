using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Texte : MonoBehaviour {
    int n = 0;
    string message;
    Text texte;
    // Use this for initialization
    void Start() {
        texte = GetComponent<Text>();
        message = texte.text;
    }

    void Update()
    {
    if(Input.GetMouseButtonDown(0)) {
            n = n+1;
            Debug.Log(n);
               switch(n) {
                case 1:
                    texte.text = "Mais il serait possible \n que vous non plus vous \n ne saviez pas quoi ajouter ";
                    break;
                case 2:
                    texte.text = "J'ai donc une question d'une \n importance capitale à vous poser";
                    break;
                case 3:
                    texte.text = "Seriez vous gay ou homosexuel ? \n \n Oui         Non";
                    break;
                case 4:
                    texte.text = "Vous avez cliqué sur Oui, \n vous pouvez sortir de l'ombre \n et non vous n'avez pas missclick";
                    break;
                case 5:
                    texte.text = "Ne dites pas que ce script \n est merdique \n parce que vous êtes homo";
                    break;
                case 6:
                    texte.text = "Bon ok, ce script est pourri et \n ne sert à rien (pour le moment) mais...";
                    break;
                case 7:
                    texte.text = "Ah, \n GAAAAAAAAAYYYYYYY";
                    texte.fontSize = 45;
                    break;
                case 8:
                    Application.LoadLevel("level1");
                    break;
            }
    }
    }
}
