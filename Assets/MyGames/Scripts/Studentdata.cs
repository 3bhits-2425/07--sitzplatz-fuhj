using UnityEngine;

[CreateAssetMenu(fileName = "StudentData", menuName = "Set/planstudents")]

public class Studentdata : ScriptableObject
{
   public string studentName;
   public Color eyecolor;
   public Sprite StudentImage;
   public AudioClip StudentAudio;
}
