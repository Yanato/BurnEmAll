using UnityEngine;
using System.Collections;

/// <summary>
/// Création d'effets sonores en toute simplicité
/// </summary>
public class SoundEffectsHelper : MonoBehaviour
{

	/// <summary>
	/// Singleton
	/// </summary>
	public static SoundEffectsHelper Instance;

	public AudioClip DuckSound;
	public AudioClip FlowerSound;
	public AudioClip BearSound;
	public AudioClip RabbitSound;


	void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}

	public void DoDuckSound()
	{
		MakeSound(DuckSound);
	}

	public void DoFlowerSound()
	{
		MakeSound(FlowerSound);
	}

	public void DoBearSound()
	{
		MakeSound(BearSound);
	}
	public void DoRabbitSound()
	{
		MakeSound(RabbitSound);
	}

	/// <summary>
	/// Lance la lecture du son
	/// </summary>
	/// <param name="originalClip"></param>
	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}
