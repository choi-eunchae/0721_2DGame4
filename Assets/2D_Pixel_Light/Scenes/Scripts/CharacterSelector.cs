using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public void SelectCharacter(int characterIndex)
    {
        PlayerPrefs.SetInt("SelectdeCharacter", characterIndex);
        PlayerPrefs.Save();

        SceneTransitionManager.Instance.FadeOutAndChangeScene(1);
    }
}
