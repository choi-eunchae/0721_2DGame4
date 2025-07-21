using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] characterPrefabs;
    [SerializeField]
    private Transform spawnPoint;
    void Start()
    {
        SpawnSelectedCharacter();
    }


    void SpawnSelectedCharacter()
    {
        int selectCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);

        if (characterPrefabs != null && selectCharacter >= 0 && selectCharacter < characterPrefabs.Length)
        {
            if (spawnPoint != null)
            {
                Instantiate(characterPrefabs[selectCharacter], spawnPoint.position, spawnPoint.rotation);
            }
            else
            {
                Instantiate(characterPrefabs[selectCharacter]);
            }
        }
        else
        {
            if (characterPrefabs != null && characterPrefabs.Length > 0)
            {
                Instantiate(characterPrefabs[0]);
            }
        }
    }
}
