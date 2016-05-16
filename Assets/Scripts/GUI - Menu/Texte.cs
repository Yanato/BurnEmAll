using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Texte : MonoBehaviour {
	int n = 0;
	public AudioClip Burnem;

	Text texte;
	// Use this for initialization
	void Start() {
		texte = GetComponent<Text>();
		//     string message; et message = texte.text;
		if (MainMenu.isFrench) {
			texte.text = "Il n'y a pas si longtemps que ça,\n  un homme se réveilla en pleine nature.";
		} else {
			texte.text = "Not a long time ago,\n a man woke up surrounded by nature.";
		}
			
	}

	void Update()
	{
		if (MainMenu.isFrench) {
			
			if (Input.GetMouseButtonDown (0)) {
				n = n + 1;
				switch (n) {
				case 1:
					texte.text = "Il ne savait pas ce qu'il faisait là.\n  Étrangement, il était nu… \nmais ça c'est une autre histoire.";
					break;
				case 2:
					texte.text = "Alors qu'il se réveillait,\n il entendit des voix sans savoir d’où elles provenaient.\n Ces voix tantôt douces, tantôt violentes,\n  l'incitaient à faire du mal à tout ce qui se trouvait autour.";
					break;
				case 4:
					texte.text = "Il trouva une torche face à lui.\nLa flamme lui parla, le réchauffa, le réconforta\n  mais l’entraîna par la même occasion\n dans la folie et dans la déchéance de son âme.";
					break;
				case 5:
					texte.text = "La nature lui sembla alors hostile :\n - Les lapins eurent tout à coup les yeux luisants. \n - Il pouvait voir des visages sur les fleurs.\n - Les canards avaient un comportement étrange. \n\n  TOUS CES ANIMAUX VOULAIENT SA MORT !";
					break;

				case 7:
					texte.text = "Il avait sombré dans la folie ! \n Mais ne l'était-il pas déjà avant ? \n \n Tout ce qu'il savait,\n c'est que la réponse se tenait entre ses mains. ";
					burnemSound ();

					break;
				case 8:
					texte.text = "Il comprit vite que le feu était\n l'unique solution à tout ses problèmes.\n \n Toutes les voix se mirent à\nmurmurer, parler, crier, hurler la même chose... ";
					break;			
				case 9:
					texte.text = "BURN 'EM ALL.";
					texte.fontSize = 45;
					break;
				case 10:
					MainMenu.isIntro = false;
					MainMenu.DisableContinue = false;
					SceneManager.LoadScene ("Level1");
					HealthBar.cur_health = 100;
					HealthBar.life = 3;
					continueMenu.isTuto = true;

					break;
				}
			}
		} else {
			if (Input.GetMouseButtonDown (0)) {
				n = n + 1;
				switch (n) {
				case 1:
					texte.text = "He didn’t know what he was doing here.\n\n Strangely, he was naked…\n But that’s another story.";
					break;
				case 2:
					texte.text = "While he was waking up,\n he heard voices without knowing\n where they were coming from.\n\n These voices, sometimes sweet, sometimes aggressive,\n made him hurting the nature around him.";
					break;
				case 4:
					texte.text = "He found a torch in front of him.\n The flame spoke to him, warmed him,\n comforted him but\n lead to the madness and degradation of his soul.";
					break;
				case 5:
					texte.text = "Nature seemed to him hostile\n - The rabbits had suddenly shining eyes.\n - He could see faces on flowers.\n - Ducks had a strange behaviour.\n\n ALL THESE ANIMALS WANT HIS DEATH!";
					break;

				case 7:
					texte.text = "He had gone mad!\n But was he already before?\n\n All he knew was that he had the answer in his hands.";
					burnemSound ();

					break;
				case 8:
					texte.text = "He quickly realized that the fire\n was the only solution for his problems.\n\n All voices began to whisper, talk,\n scream, yell the same thing to him...";
					break;			
				case 9:
					texte.text = "BURN 'EM ALL.";
					texte.fontSize = 45;
					break;
				case 10:
					MainMenu.isIntro = false;
					MainMenu.DisableContinue = false;
					SceneManager.LoadScene ("Level1");
					HealthBar.cur_health = 100;
					HealthBar.life = 3;
					continueMenu.isTuto = true;
					break;
				}
			}
		}
			
	}
	public void burnemSound()
	{
		MakeSound (Burnem);
	}
	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}
