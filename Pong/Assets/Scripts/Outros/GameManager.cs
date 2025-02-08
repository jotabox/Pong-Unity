using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int pointPlayer1 = 0 ;
    [SerializeField] private int pointPlayer2 = 0;

    [SerializeField] private Text _points;
    private AudioSource _audio;

    

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
        ChangeText();
        if ( _points != null)
        {
            Debug.Log("o componente text , não foi atribuido no GameManager");
        }
    }
    public void AddPointPlayer1()
    {
        pointPlayer1++;
        ChangeText();
        PlayAudioGoal();
    }

    public void AddPointPlayer2()
    {
        pointPlayer2++;
        ChangeText();
        PlayAudioGoal();
    }

    private void ChangeText()
    {
        _points.text = $"{pointPlayer1} X {pointPlayer2}";

    }

    private void PlayAudioGoal()
    {
        _audio.Play();
    }
}
