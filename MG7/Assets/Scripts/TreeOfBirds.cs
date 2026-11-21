using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private Bird[] _birds;
    [SerializeField] private Player _player;
    [SerializeField] private float _interactDistance;

    private void Update()
    {
        for(int i=0; i<_birds.Length; i++)
        {
            if (Vector3.Distance(_birds[i].transform.position, _player.transform.position) <= _interactDistance)
            {
                _birds[i].gameObject.SetActive(true);
            }
        }
    }
}
